using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputtext = Console.ReadLine();
            string inputtext2 = inputtext;

            int endOfProtocol = inputtext.IndexOf("://");

            string protocol = "";
            string server = "";
            string resource = "";
            string serverAndresource = "";

            if (endOfProtocol != -1) //if we found anything
            {
                protocol = inputtext.Remove(endOfProtocol);
                serverAndresource = inputtext2.Remove(0, endOfProtocol + 3); 
            }
            else
            {
                serverAndresource = inputtext2;
            }
            
            int startOfResource = serverAndresource.IndexOf("/");

            if (startOfResource != -1) //if we found anything
            {
                server = serverAndresource.Remove(startOfResource,serverAndresource.Length-startOfResource);
                resource = serverAndresource.Remove(0, startOfResource + 1);
            }
            else
            {
                server = serverAndresource;
                
            }

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
            
        }
}
}
