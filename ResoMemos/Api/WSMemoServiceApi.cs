using WebSocketSharp;
using WebSocketSharp.Server;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using System;
using System.Linq;
using System.Reflection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.ComponentModel;
using RestSharp;
using System.Reflection.Metadata.Ecma335;

namespace ResoMemos
{
    public class WSMemoServiceApi : WebSocketBehavior
    {
        private MemoServiceApi? memoService;
        private Configuration? _config;
        public Configuration Config {
            get { 
                return _config; 
            }

            set {
                _config = value;
            }

        }
        public const string WS_SERVICE_ENDPOINT = "/MemoService";
        public string[] Commands;
        private string[] excludedItems = [
            "get_Config",
            "set_Config",
            "OnOpen",
            "OnMessage"
        ];

        public WSMemoServiceApi()
        {
            Commands = GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                        .Select(com => com.Name)
                        .Where(com => !excludedItems.Contains(com))
                        .ToArray();
            Console.WriteLine($"Found Commands:{Environment.NewLine + String.Join(Environment.NewLine, Commands)}");
        }

        protected override void OnOpen()
        {
            memoService = new MemoServiceApi(Config);
            base.OnOpen();
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            var _receivedDataArray = e.Data.Split(',');
            var _receivedOperation = Commands.First( com => com == _receivedDataArray[0]);
            var _receivedArgs = new string[_receivedDataArray.Length - 1];
            Array.Copy(_receivedDataArray, 1, _receivedArgs, 0, _receivedDataArray.Length - 1);

            MethodInfo ?_comMethod = GetType().GetMethod(_receivedOperation, BindingFlags.Instance | BindingFlags.Public);
            try
            {
                _comMethod.Invoke(this,_receivedArgs);
            }
            catch(Exception ex)
            {
                Send($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
            }
        }

        public void CreateMemo(string body, string visibility)
        {
            V1Visibility visEnum = (V1Visibility)int.Parse(visibility);
            var responseCreateMemo = memoService.MemoServiceCreateMemo(
                new V1CreateMemoRequest(
                    body,
                    visEnum
                )
            );

            // Normally this would send the full memo data as a response.
            // Instead we're just going to send the memo name. We can get
            // the full memo with this return if desired.
            Send(
                responseCreateMemo.Name
            );
        }
        
        public void CreateMemoComment(string name, string body, string visibility)
        {
            V1Visibility visEnum = (V1Visibility)int.Parse(visibility);
            var responseCreateMemoComment = memoService.MemoServiceCreateMemoComment(
                name,
                new V1CreateMemoRequest(
                    body,
                    visEnum
                )   
            );

            // Normally this would send the full memo data as a response.
            // Instead we're just going to send the memo name. We can get
            // the full memo with this return if desired.
            Send(
                responseCreateMemoComment.Name
            );
        }

        public void DeleteMemo(string name)
        {
            var deleteMemoResponse = memoService.MemoServiceDeleteMemo(name);
        }

        public void DeleteMemoTag(string parentMemo, string tag, string? deleteRelatedMemos)
        {
            var responseDeleteMemoTag = memoService.MemoServiceDeleteMemoTag(
                parentMemo,
                tag,
                bool.Parse(deleteRelatedMemos)
            );
        }

        public void GetMemo(string name)
        {
            var _responseGetMemo = memoService.MemoServiceGetMemo(name);
            Send(
                _responseGetMemo.ToString()
            );
        }

        public void GetUserMemosStats(string? name, string? timezone, string? filter)
        {
            var responseGetUserMemosStats = memoService.MemoServiceGetUserMemosStats(
                name,
                timezone,
                filter  
            );

            // Not really sure what this is supposed to return.
            throw new NotImplementedException();
        }

        public void ListMemoComments(string name)
        {
            var responseListMemoComments = memoService.MemoServiceListMemoComments(name);

            // We will return the names of every found memo.
            // We can later use GetMemo to get the actual contents.
            Send(
                String.Join(',', responseListMemoComments.Memos.Select(m => m.Name))
            );
        }

        public void ListMemoProperties(string name)
        {
            var responseListMemoProperties = memoService.MemoServiceListMemoProperties(
                name
            );

            Send(
                String.Join(
                    Environment.NewLine,
                    responseListMemoProperties.Properties.Select( p =>
                        String.Join(',',
                        p.HasCode,
                        p.HasLink,
                        p.HasTaskList,
                        p.Tags
                        )
                    )
                )
            );
        }

        public void ListMemoReactions(string name)
        {
            throw new NotImplementedException();
        }

        public void ListMemoRelations(string name)
        {
            throw new NotImplementedException();
        }

        public void ListMemoResources(string name)
        {
            throw new NotImplementedException();
        }

        public void ListMemoTags(string? parentMemo, string? filter)
        {
            parentMemo = parentMemo.IsNullOrEmpty() ? "memos/-" : parentMemo;
            var _responseListMemoTags = memoService.MemoServiceListMemoTags(parentMemo,filter);
            Send(
                String.Join(
                    " ",
                    _responseListMemoTags.TagAmounts.Count,
                    String.Join(
                        " ",
                        _responseListMemoTags.TagAmounts.Keys
                    )
                )
            );
        }
        
        public void ListMemos(string? pageSize, string? pageToken, string? filter)
        {
            var _responseListMemos = memoService.MemoServiceListMemos(int.Parse(pageSize),pageToken,filter);
            Send(
                String.Join(Environment.NewLine, _responseListMemos.Memos.Select(m => m.Name))
            );
        }

    }
}