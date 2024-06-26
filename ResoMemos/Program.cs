using System;
using System.Data;
using System.Linq;
using System.Net;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using WebSocketSharp;
using WebSocketSharp.Server;
using Microsoft.Extensions.Configuration;

namespace ResoMemos
{
    class Program
    {
        private static Configuration memoApiConfig;
        private static V1User userProfile;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            var resoMemosSettings = new ResoMemosSettings();
            configuration.GetSection("ResoMemosSettings").Bind(resoMemosSettings);

            memoApiConfig = new Configuration(
                new Dictionary<string,string>
                {
                    {"Authorization",$"Bearer {resoMemosSettings.Token}"}
                },
                new Dictionary<string,string>(),
                new Dictionary<string,string>(),
                resoMemosSettings.BasePath
            );

            userProfile = new AuthServiceApi(memoApiConfig).AuthServiceGetAuthStatus();
            var wsserver = new WebSocketServer(resoMemosSettings.WebsocketPort);
            wsserver.AddWebSocketService<WSMemoServiceApi>(
                WSMemoServiceApi.WS_SERVICE_ENDPOINT,
                () => {
                    var s = new WSMemoServiceApi {Config = memoApiConfig};
                    return s;
                });
            wsserver.Start();
            Console.WriteLine($"Started WebSocket Server at ws://{Dns.GetHostName()}:{resoMemosSettings.WebsocketPort}");
            Console.ReadKey(true);
            wsserver.Stop();
        }
    }
}
