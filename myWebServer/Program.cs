using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace myWebServer {
    class Program {
       

        static void Main(string[] args) {       // this program tells listener to listen to yur 
            HttpListener listener = new HttpListener();
            string uri = "http://localhost:8080/";
            listener.Prefixes.Add(uri);
            listener.Start();

            while (true) {
                Console.WriteLine("\nListening on " + uri + " ...");
                HttpListenerContext context = listener.GetContext();
                Console.WriteLine("\nIncoming request received!");


                //HttpListenerRequest request = context.Request;

                //string url = request.Url.ToString();
                //Console.WriteLine("URL: " + url);
                //Console.WriteLine("Method: " + request.HttpMethod);


            }
        }
    }
}
