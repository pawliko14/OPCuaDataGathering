using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LocalApplicationDataGathering.Pinging
{
    class ComplexPing
    {
        private static  bool reachable;

        public static  bool getPingStatus()
            {
            return reachable;
            }

        public static void Ping_function()
        {
            Ping pingSender = new Ping();

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "00000000000000000000000000000000";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            int timeout = 2000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);

            // Send the request.
            try
            {
                PingReply reply = pingSender.Send("192.168.90.39", timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);

                    reachable = true;
                }
                else
                {
                    Console.WriteLine(reply.Status);
                    reachable = false;
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine("Ping connections exception: " + e);
            }

          
        }

    }
}
