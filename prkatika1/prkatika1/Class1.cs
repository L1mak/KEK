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
            if (reg.IsMatch(@"\d${4}"))
            {
                if (!reg.IsMatch(vin)) { return false; }
                return true;
            }
            return true;
        }
        }
        public string GetVINCountry(string vin)
        {
        Dictionary<string,string> countrydic = new Dictionary<string,string>();
            Regex country = new Regex("[A-HJ-NPR-Z0-9]{8}[1-9X][A-HN-PR-TV-Y1-9][A-HJ-NPR-Z0-9]{3}[0-9]{4}");
        if (countrydic == null){
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
            countrydic.Add();
        }
        return(countryname);
        }
    }

