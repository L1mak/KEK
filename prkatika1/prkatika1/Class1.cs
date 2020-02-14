using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prkatika1
{
    public class Class1
    {
        public bool CheckVIN(string vin)
        {
            Regex reg = new Regex("[0-9A-HJ-N,P,R-Z]{17}");
            if (reg.IsMatch(@"\d${4}")){
                if (!reg.IsMatch(vin)) { return false; }
                return true;
            }
        }
        public string GetVINCountry(string vin)
        {
            Regex country = new Regex("[]");
            if 
        }
    }
}
