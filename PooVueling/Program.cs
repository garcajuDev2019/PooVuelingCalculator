using log4net;
using log4net.Config;

namespace PooVueling
{
     public class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));
        }
    }
}
