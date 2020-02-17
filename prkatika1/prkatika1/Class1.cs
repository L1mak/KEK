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
            if (!reg.IsMatch(@"\d${4}"))
            {
                if (!reg.IsMatch(vin)) { return false; }
                return false; 
            }
            return true;
        }
        }
        public string GetVINCountry(string vin)
        {
        Dictionary<string,string> countrydic = new Dictionary<string,string>();
            Regex country = new Regex("[A-HJ-NPR-Z0-9]{8}[1-9X][A-HN-PR-TV-Y1-9][A-HJ-NPR-Z0-9]{3}[0-9]{4}");
        if (countrydic == null){
            countrydic.Add("AA-AH","");
            countrydic.Add("AJ-AN","");
            countrydic.Add("AP-A0","");
            countrydic.Add("BA-BE", "");
            countrydic.Add("BF-BK", "");
            countrydic.Add("BL-BR", "");
            countrydic.Add("BS-B0", "");
            countrydic.Add("CA-CE", "");
            countrydic.Add("CF-CK", "");
            countrydic.Add("CL-CR", "");
            countrydic.Add("CS-C0", "");
            countrydic.Add("DA-DE", "");
            countrydic.Add("DF-DK", "");
            countrydic.Add("DL-DR", "");
            countrydic.Add("JA-JT", "");
            countrydic.Add("EA-EE", "");
            countrydic.Add("EF-EK", "");
            countrydic.Add("KA-KE", "");
            countrydic.Add("FA-FE", "");
            countrydic.Add("FF-FK", "");
            countrydic.Add("KF-KK", "");
            countrydic.Add("KL-KR", "");
            countrydic.Add("KS-K0", "");
            countrydic.Add("LA-L0", "");
            countrydic.Add("MA-ME", "");
            countrydic.Add("MF-MK", "");
            countrydic.Add("ML-MR", "");
            countrydic.Add("PA-PE", "");
            countrydic.Add("NF-NK", "");
            countrydic.Add("NL-NR", "");
            countrydic.Add("PF-PK", "");
            countrydic.Add("PL-PR", "");
            countrydic.Add("RA-RE", "");
            countrydic.Add("RF-RK", "");
            countrydic.Add("RL-RR", "");
            countrydic.Add("RS-R0", "");
            countrydic.Add("SA-SM", "");
            countrydic.Add("SN-ST", "");
            countrydic.Add("SU-SZ", "");
            countrydic.Add("S1-S4", "");
            countrydic.Add("TA-TH", "");
            countrydic.Add("TJ-TP", "");
            countrydic.Add("TR-TV", "");
            countrydic.Add("TW-T1", "");
            countrydic.Add("UH-UM", "");
            countrydic.Add("UN-UT", "");
            countrydic.Add("UU-UZ", "");
            countrydic.Add("", "");
            countrydic.Add("", "");
            countrydic.Add("", "");
            countrydic.Add("", "");
        }
        return(countryname);
        }
    }

