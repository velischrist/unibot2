using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universities_Data
{
    public class Universities
    {
        private static Dictionary<string, double> AcceptanceRates;
        private static Dictionary<string, string> CampusSize;
        private static Dictionary<string, string> SatScoreRange;
        private static Dictionary<string, string> ActScoreRange;
        private static Dictionary<string, int> UndergradStudents;
       // private static Dictionary<string, string> ContactInfo;

        public Universities()
        {
            if(AcceptanceRates == null || AcceptanceRates.Count == 0)
                InitializeAcceptanceRates();
            if (CampusSize == null || CampusSize.Count == 0)
                InitializeCampusSize();
            if (SatScoreRange == null || SatScoreRange.Count == 0)
                InitializeAcceptanceRates();
            if (ActScoreRange == null || ActScoreRange.Count == 0)
                InitializeActScoreRange();
            if (UndergradStudents == null || UndergradStudents.Count == 0)
                InitializeUndergradStudents();
        //    if (ContactInfo == null || ContactInfo.Count == 0)
          //      InitializeContactInfo();
        }
        public void InitializeAcceptanceRates()
        {
            AcceptanceRates = new Dictionary<string, double>();
            AcceptanceRates.Add("Stanford", 4.8);
            AcceptanceRates.Add("Harvard", 5.4);
            AcceptanceRates.Add("MIT", 7.9);
        }

        public void InitializeCampusSize()
        {
            CampusSize = new Dictionary<string, string>();
            CampusSize.Add("Stanford", "Large");
            CampusSize.Add("Harvard", "Midsize");
            CampusSize.Add("MIT", "Midsize");
        }

        public void InitializeSatScoreRange()
        {
            SatScoreRange = new Dictionary<string, string>();
            SatScoreRange.Add("Stanford", "");
            SatScoreRange.Add("Harvard", "");
            SatScoreRange.Add("MIT", "");
        }

        public void InitializeActScoreRange()
        {
            ActScoreRange = new Dictionary<string, string>();
            ActScoreRange.Add("Stanford", "1460-1590");
            ActScoreRange.Add("Harvard", "1480-1600");
            ActScoreRange.Add("MIT", "1480-1580");
        }

        public void InitializeUndergradStudents()
        {
            UndergradStudents = new Dictionary<string, int>();
            UndergradStudents.Add("Stanford", 7019);
            UndergradStudents.Add("Harvard", 7200);
            UndergradStudents.Add("MIT", 4476);
        }

      //  public void InitializeContactInfo()
      //  {
     //       ContactInfo = new Dictionary<string, int>();
       //     ContactInfo.Add("Stanford", 7019);
         //   ContactInfo.Add("Harvard", 7200);
           // ContactInfo.Add("MIT", 4476);
        //}
        
    }
}
