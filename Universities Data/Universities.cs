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
        public Dictionary<string, string> Location;
        public Dictionary<string, string> ApplicationDeadlines;
        public Dictionary<string, string> HowToApply;

        public Universities()
        {
            if(AcceptanceRates == null || AcceptanceRates.Count == 0)
                InitializeAcceptanceRates();
            if (CampusSize == null || CampusSize.Count == 0)
                InitializeCampusSize();
            if (SatScoreRange == null || SatScoreRange.Count == 0)
                InitializeSatScoreRange();
            if (ActScoreRange == null || ActScoreRange.Count == 0)
                InitializeActScoreRange();
            if (UndergradStudents == null || UndergradStudents.Count == 0)
                InitializeUndergradStudents();
            if (ContactInfo == null || ContactInfo.Count == 0)
                InitializeContactInfo();
            if (Tuition == null || Tuition.Count == 0)
                InitializeTuition();
            if (Location == null || Location.Count == 0)
                InitializeLocation();
            if (ApplicationDeadlines == null || ApplicationDeadlines.Count == 0)
                InitializeApplicationDeadlines();
            if (HowToApply == null || HowToApply.Count == 0)
                InitializeHowToApply();
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
            ActScoreRange.Add("stanford", "31-35");
            ActScoreRange.Add("harvard", "32-35");
            ActScoreRange.Add("mit", "33-35");
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
            ContactInfo.Add("stanford", "https://www.stanford.edu/contact/");
            ContactInfo.Add("harvard", "https://www.harvard.edu/contact-harvard");
            ContactInfo.Add("mit", "https://www.mitadmissions.org/pages/contact-us");
        }
        
        public void InitializeTuition()
        {
            Tuition = new Dictionary<string, int>();
            Tuition.Add("stanford", 64782);
            Tuition.Add("harvard", 65609);
            Tuition.Add("mit", 67430);
        }
        
        public void InitializeLocation()
        {
            Location = new Dictionary<string, string>();
            Location.Add("stanford", "Stanford, California");
            Location.Add("harvard", "Cambridge and Boston, Massachusetts");
            Location.Add("mit", "Cambridge, Massachusetts");
        }

        public void InitializeApplicationDeadlines()
        {
            ApplicationDeadlines = new Dictionary<string, string>();
            ApplicationDeadlines.Add("stanford", "The deadlines for Stanford are: 11/01/2017 for Restrictive Early Action and 01/03/2018 for Regular Decision");
            ApplicationDeadlines.Add("harvard", "The deadlines for harvard are: 11/01/2017 for Restrictive Early Action and 01/01/2018 for Regular Decision");
            ApplicationDeadlines.Add("mit", "The deadlines for mit are: 11/01/2017 for Early Action and 01/01/2018 for Regular Decision");
        }

        public void InitializeHowToApply()
        {
            HowToApply = new Dictionary<string, string>();
            HowToApply.Add("stanford", "Visit the link: http://www.commonapp.org/ and apply now");
            HowToApply.Add("harvard", "Visit the link: http://www.commonapp.org/ and apply now");
            HowToApply.Add("mit", "Visit the link: https://my.mit.edu/uaweb/login.htm and apply now");
        }
    }
}