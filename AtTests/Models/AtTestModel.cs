using Cysharp.Diagnostics;
using System.Diagnostics;

namespace Qlab.AtTests;

class AtTestModel
{
    public AtTestViewModel ViewModel { get; }
    public AtTestModel()
    {
        ViewModel = new AtTestViewModel();
        ViewModel.LoadCommand.Subscribe(() => Task.Run(GetTests));
    }

    private async void GetTests()
    {
        if (string.IsNullOrEmpty(ViewModel.Contest.Value))
        {
            return;
        }
        try
        {
            await foreach (string item in ProcessX.StartAsync($"atcoder-tools gen {ViewModel.Contest.Value.ToLower()}"))
            {
                ViewModel.UpdateConsole(item);
            }
        }
        catch (ProcessErrorException ex)
        {
            ViewModel.UpdateConsole(ex.ToString());
        }
    }
}