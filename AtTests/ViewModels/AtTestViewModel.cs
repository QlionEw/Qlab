using System.Text;
using System.Windows.Input;
using Reactive.Bindings;

namespace Qlab.AtTests;

class AtTestViewModel
{
    public ReactiveCollection<string> Contests { get; } = new ReactiveCollection<string>();
    public ReactiveCommand LoadCommand { get; } = new ReactiveCommand();
    public ReactiveProperty<string> Contest { get; } = new ReactiveProperty<string>();
    public ReactiveProperty<string> ConsoleLog { get; } = new ReactiveProperty<string>();
    private readonly StringBuilder builder = new();

    public AtTestViewModel()
    {
        UpdateConsole("");
    }

    public void UpdateConsole(string log)
    {
        builder.Append(log);
        ConsoleLog.Value = builder.ToString();
    }
}
