using System;
using System.Linq;

namespace DnsReproduce
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(0, 1000);
            foreach (var item in range)
            {
                var hostName = System.Net.Dns.GetHostName();
                var entry = System.Net.Dns.GetHostEntry(hostName);
                var ips = entry.AddressList.Select(x => x.ToString());
                Console.WriteLine($"Call {item} {string.Join(", ", ips)}");
            }
        }
    }
}
