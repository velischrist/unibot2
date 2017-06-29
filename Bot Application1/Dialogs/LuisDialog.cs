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

    }
}
