using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.model
{
    internal class Subject
    {
        static string thdc = "Tin học đại cương";
        static string gt = "Giải tích F1";
        static string TA = "Tiếng Anh A0";
        static string TH = "Triết học Mác - Lênin";
        static string VL = "Vật lý F1";

        List<string> list = new List<string>();
        public Subject()
        {
            list.Add(thdc);
            list.Add(gt);
            list.Add(TA);
            list.Add(TH);
            list.Add(VL);
        }
        public int TC(string name)
        {
            if (list[0] == name || list[3] == name) return 2;
            else return 3;
        }
    }
}
