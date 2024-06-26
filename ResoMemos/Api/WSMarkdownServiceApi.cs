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

namespace ResoMemos
{
    public class WSMarkdownServiceApi : WebSocketBehavior
    {
        private MarkdownServiceApi markdownService;
        public const string WS_SERVICE_ENDPOINT = "/MarkdownService";
        public string[] Commands;

        public WSMarkdownServiceApi()
        {
            Commands = GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                        .Select(com => com.Name.ToUpper())
                        .ToArray();
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            base.OnMessage(e);
        }
        
        public void Parse(string _markdown)
        {
            throw new NotImplementedException();
        }
    }
}