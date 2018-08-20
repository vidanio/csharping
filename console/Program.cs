using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Globalization;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            byte hex = 0x11;
            Console.Write("<?xml version=\"1.0\" ?>\r\n");
            Console.Write("<Equalizer>\r\n");
            Console.Write("    <Bands>\r\n");
            Console.Write("        <Band FreqInHz=\"80\" BandWidth=\"12\" GainIndB=\"{0}\">0</Band>\r\n", eqf2edjLevel(hex));
            Console.Write("    <Bands>\r\n");
            Console.Write("<Equalizer>\r\n");

            Console.ReadKey();
        }

        public static string eqf2edjLevel(byte hex)
        {
            string res = "";
            int num = (int)hex;

            if (num == 31)
            {
                res = "0.000000";
            }
            else
            {
                res = string.Format("{0}", ((32 - num)*0.375).ToString("F6", CultureInfo.InvariantCulture));
            }

            return res;
        }
    }
}
