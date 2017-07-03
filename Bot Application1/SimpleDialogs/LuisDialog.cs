using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Luis.Models;
using UniversitiesData;
using System.Text;
using Microsoft.Bot.Connector;

namespace Bot_Application1.Dialogs
{
    [LuisModel("ebba0822-5d77-4203-9b77-75355aecca95", "a6b1fb43ba384a698242ea1da1ed098a")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        [LuisIntent("Campus")]
        public async Task GetSize(IDialogContext context, LuisResult result)
        {
            Universities sizes = new Universities();
            string size = "";
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (sizes.CampusSize.TryGetValue($"{university}", out size))
                {
                    await context.PostAsync($"The campus of {university} is {size} ");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }

            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
            context.Wait(MessageReceived);
        }
        [LuisIntent("AcceptanceRate")]
        public async Task GetAccRate(IDialogContext context, LuisResult result)
        {
            Universities accrates = new Universities();
            double accrate = 0.0;
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if(accrates.AcceptanceRates.TryGetValue($"{university}", out accrate))
                {
                    await context.PostAsync($"The acceptance rate of {university} is {accrate}. ");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("NumberOfUndergraduateStudents")]
        public async Task GetUndergradStudents(IDialogContext context, LuisResult result)
        {
            Universities undergradstudents = new Universities();
            int numberofundergraduatestudents = 0;
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (undergradstudents.UndergradStudents.TryGetValue($"{university}", out numberofundergraduatestudents))
                {
                    await context.PostAsync($"{university} has {numberofundergraduatestudents} undergraduate students");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("TestScores")]

        public async Task GetScores(IDialogContext context, LuisResult result)
        {
            Universities testscores = new Universities();
            string satscore = "";
            string actscore = "";
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (testscores.ActScoreRange.TryGetValue($"{university}", out actscore) & testscores.SatScoreRange.TryGetValue($"{university}", out satscore))
                {
                    await context.PostAsync($"{university}'s total sat's 25th - 75th percentile is {satscore} and its composite act 25th - 75th percentile is {actscore}");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found");
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("ContactInfo")]

        public async Task GetContactInfo(IDialogContext context, LuisResult result)
        {
            Universities contactinfo = new Universities();
            string contact = "";
            string university = "";
            EntityRecommendation rec;
            if(result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (contactinfo.ContactInfo.TryGetValue($"{university}", out contact))
                {
                    await context.PostAsync($"To contact {university}  follow the link: {contact}.");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found");
            }
        }

        [LuisIntent("Tuition")]
        public async Task GetTuition(IDialogContext context, LuisResult result)
        {
            Universities tuition = new Universities();
            int cost = 0;
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (tuition.Tuition.TryGetValue($"{university}", out cost))
                {
                    await context.PostAsync($"The total price for undergraduate students in {university} is {tuition}.");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found");
            }
        }

        [LuisIntent("Location")]
        public async Task GetLocation(IDialogContext context, LuisResult result)
        {
            Universities location = new Universities();
            string address = "";
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (location.Location.TryGetValue($"{university}", out address))
                {
                    await context.PostAsync($"{university} is located in {address}");
                }
                else
                {
                    await context.PostAsync("Sorry no university found.");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found");
            }
        }

        [LuisIntent("ApplicationDeadlines")]

        public async Task GetApplicationDeadlines(IDialogContext context, LuisResult result)
        {
            Universities applicationdeadlines = new Universities();
            string deadlines = "";
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if(applicationdeadlines.ApplicationDeadlines.TryGetValue($"{university}", out deadlines))
                {
                    await context.PostAsync("");
                }
                else
                {
                    await context.PostAsync("Sorry no university found");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
        }

        [LuisIntent("HowToApply")]

        public async Task GetHowToApply(IDialogContext context, LuisResult result)
        {
            Universities howtoapply = new Universities();
            string how = "";
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                if (howtoapply.HowToApply.TryGetValue($"{university}", out how))
                {
                    await context.PostAsync("");
                }
                else
                {
                    await context.PostAsync("Sorry no university found");
                }
            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
        }

    }
}
