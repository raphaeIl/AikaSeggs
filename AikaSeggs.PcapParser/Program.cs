using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaSeggs.PcapParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PcapParser.Instance.LoadAllPackets();

            var a = PcapParser.Instance.packets;


            Console.WriteLine();
        }
    }
}
