using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Para

{
    internal class Program
    {
        static void Main(string[] args)
        {
            PARA_Lib.Class1 ok = new PARA_Lib.Class1();

            ok.StartPara = "10:10";
            ok.EndPara = "11:40";
            ok.ChillStart = "11:40";
            ok.ChillEnd = "11:50";
            ok.ZvukGolubya = " ";
        }
    }
}
