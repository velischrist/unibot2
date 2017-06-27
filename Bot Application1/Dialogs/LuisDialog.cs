using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Luis.Models;
using Universities_Data;
using System.Text;

namespace Bot_Application1.Dialogs
{
    [LuisModel("ebba0822-5d77-4203-9b77-75355aecca95", "a6b1fb43ba384a698242ea1da1ed098a")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        [LuisIntent("Campus")]
        public async Task GetSize(IDialogContext context, LuisResult result)
        {
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                await context.PostAsync($"The campus of {university} is ");
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
            string university = "";
            EntityRecommendation rec;
            if (result.TryFindEntity("university", out rec))
            {
                university = rec.Entity;
                await context.PostAsync($"The acceptance rate of {university} is something");
            }
            else
            {
                await context.PostAsync("Sorry no university found.");
            }
            context.Wait(MessageReceived);
        }
        
    }
}
