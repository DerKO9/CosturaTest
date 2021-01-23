using System;
using Grpc.Core;

namespace CosturaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //CosturaUtility.Initialize();

            // Dummy code that references the troublemaker assemblies "grpc_csharp_ext.x86"
            var callCredentials = CallCredentials.FromInterceptor(async (c, m) => { });
            var credentials = ChannelCredentials.Create(new SslCredentials(), callCredentials);
            var channel = new Channel("", credentials); // System.IO.FileNotFoundException happens here

            // We want to get to here without thrown exceptions
            Console.WriteLine("No exceptions thrown!");
            Console.ReadKey();
        }
    }
}
