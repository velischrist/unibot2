using System;
using Microsoft.Bot.Builder.FormFlow;


public enum decision { AskAboutUniversities = 1, FindOutWhichUniversitySuitsYou }
// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class Decide
{
    [Prompt("What would you {&} to do? {||}")]
    public decision Like { get; set; }
    public static IForm<Decide> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<Decide>().Build();
    }

    public static IFormDialog<Decide> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
