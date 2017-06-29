using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitiesData
{

    public class Universities
    {
        public Dictionary<string, double> AcceptanceRates;
        public Dictionary<string, string> CampusSize;
        public Dictionary<string, string> SatScoreRange;
        public Dictionary<string, string> ActScoreRange;
        public Dictionary<string, int> UndergradStudents;
        public Dictionary<string, string> ContactInfo;
        public Dictionary<string, int> Tuition;

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
            if (ContactInfo == null || ContactInfo.Count == 0)
                InitializeContactInfo();
            if (Tuition == null || Tuition.Count == 0)
                InitializeTuition();
        }
        public void InitializeAcceptanceRates()
        {
            AcceptanceRates = new Dictionary<string, double>();
            AcceptanceRates.Add("stanford", 4.8);
            AcceptanceRates.Add("harvard", 5.4);
            AcceptanceRates.Add("mit", 7.9);
        }

        public void InitializeCampusSize()
        {
            CampusSize = new Dictionary<string, string>();
            CampusSize.Add("stanford", "Large");
            CampusSize.Add("harvard", "Midsize");
            CampusSize.Add("mit", "Midsize");
        }

        public void InitializeSatScoreRange()
        {
            SatScoreRange = new Dictionary<string, string>();
            SatScoreRange.Add("stanford", "1460-1590");
            SatScoreRange.Add("harvard", "1480-1600");
            SatScoreRange.Add("mit", "1480-1580");
        }

        public void InitializeActScoreRange()
        {
            ActScoreRange = new Dictionary<string, string>();
            ActScoreRange.Add("stanford", "");
            ActScoreRange.Add("harvard", "");
            ActScoreRange.Add("mit", "");
        }

        public void InitializeUndergradStudents()
        {
            UndergradStudents = new Dictionary<string, int>();
            UndergradStudents.Add("stanford", 7019);
            UndergradStudents.Add("harvard", 7200);
            UndergradStudents.Add("mit", 4476);
        }

        public void InitializeContactInfo()
        {
            ContactInfo = new Dictionary<string, string>();
            ContactInfo.Add("stanford", "");
            ContactInfo.Add("harvard", "");
            ContactInfo.Add("mit", "");
        }
        
        public void InitializeTuition()
        {
            Tuition = new Dictionary<string, int>();
            Tuition.Add("stanford", 0);
            Tuition.Add("harvard", 0);
            Tuition.Add("mit", 0);
        }
        
    }
}
