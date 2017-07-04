using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;
using System.Net.Http;
using System.Web.Http;
/// This dialog is the main bot dialog, which will call the Form Dialog and handle the results

namespace Bot_Application1.Dialogs
{
    [Serializable]
    public class MainDecide : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
            return Task.CompletedTask;
        }
        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            var message = await argument;
            context.Call(Decide.BuildFormDialog(FormOptions.PromptInStart), FormComplete);
        }
        private async Task FormComplete(IDialogContext context, IAwaitable<Decide> result)
        {
            try
            {
                var form = await result;
                if (form != null)
                {
                    if (form.Like.GetHashCode() == 1)
                    {

                        await context.PostAsync("Ask whatever you want.");
                    }
                    else
                    {
                        await context.PostAsync("Answer the following questions so tha we can determine which university suits you the best.");
                        //             await Conversation.SendAsync(IMessageActivity, () => new Dialogs.MainDialog());
                    }
                }
                else
                {
                    await context.PostAsync("Form returned empty response! Type anything to restart it.");
                }
            }
            catch (OperationCanceledException)
            {
                await context.PostAsync("You canceled the form! Type anything to restart it.");
                context.Wait(MessageReceivedAsync);
            }
        }
    }
}