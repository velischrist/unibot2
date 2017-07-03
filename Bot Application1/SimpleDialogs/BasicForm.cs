﻿using System;
using Microsoft.Bot.Builder.FormFlow;

public enum CampusOptions { Large = 1, Midsize, Small };
public enum ColorOptions { Red = 1, White, Blue };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hello! What is your {&}?")]
    public string Name { get; set; }

    [Prompt("Which {&} size do you prefer? {||}")]
    public CampusOptions campus { get; set; }

    [Prompt("Please select your favorite {&} {||}")]
    public ColorOptions Color { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
