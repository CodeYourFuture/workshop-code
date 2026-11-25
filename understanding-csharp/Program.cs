using System.Net;
using System.Net.Sockets;

class DnsResolver
{
    public static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.Error.WriteLine("Expected exactly one argument, but got {0}", args.Length);
            Environment.Exit(1);
        }
        string host = args[0];
        string[] parts = host.Split(".");
        Console.WriteLine($"The top-level domain of the host {host} is {parts[^1]}");
        ResolveIp(host);
    }
    public static void ResolveIp(string host)
    {
        try
        {
            IPAddress[] results = Dns.GetHostAddresses(host);
            if (results.Length == 0)
            {
                Console.WriteLine($"{host} did not resolve to any IP addresses");
            }
            else
            {
                string suffix = results.Length > 1 ? "es" : "";
                Console.WriteLine($"{host} resolved to the following IP address{suffix}");
            }
            foreach (IPAddress addr in results)
            {
                Console.WriteLine(addr);
            }
        }
        catch (SocketException e)
        {
            Console.Error.WriteLine($"Failed to resolve to IP - Connection Problem: {e.Message}");
        }
    }
}
