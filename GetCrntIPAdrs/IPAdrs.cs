using System.Net;
using System.Configuration;

namespace GetCrntIPAdrs
{
    public static class IPAdrs
    {
        public static string getCurrentIP()
        {
            IPAddress[] myIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress item in myIP)
            {
                if (item.AddressFamily.Equals(System.Net.Sockets.AddressFamily.InterNetwork))
                    return item.ToString();
            }
            return "There is no valid IPv4 address.";
        }
    }

    //public class FIleIO
    //{
    //    public string readOrUpdateIPFile()
    //    {
    //        try
    //        {
    //            string IPfileLoc = ConfigurationManager.AppSettings["IOFILEPATH"].ToString();
    //            System.IO.FileStream fs = new System.IO.FileStream(IPfileLoc, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
    //            fs.Read();
    //        }
    //        catch
    //        {

    //        }
    //    }
    //}
}

//public static IPAddress GetIPAddress(string hostName)
//{
//    Ping ping = new Ping();
//    var replay = ping.Send(hostName);//Samarth comments: this gets only first address which on this pc is ipv6 address

//    if (replay.Status == IPStatus.Success)
//    {
//        return replay.Address;
//    }
//    return null;
//}

//public static void Main()
//{
//    Console.WriteLine("Local IP Address: " + GetIPAddress(Dns.GetHostName()));
//    Console.WriteLine("Google IP:" + GetIPAddress("google.com");
//    Console.ReadLine();
//}
