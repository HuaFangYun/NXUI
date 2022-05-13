// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SplitButtonExtensions
{
    // CommandProperty

    public static T Command<T>(this T obj, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.CommandProperty] = value;
        return obj;
    }

    public static T Command<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Command<T>(this T obj, IObservable<System.Windows.Input.ICommand> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCommand(this Avalonia.Controls.SplitButton obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Windows.Input.ICommand> ObserveCommand(this Avalonia.Controls.SplitButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitButton.CommandProperty);
    }

    public static T OnCommand<T>(this T obj, Action<IObservable<System.Windows.Input.ICommand>> handler) where T : Avalonia.Controls.SplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitButton.CommandProperty);
        handler(observable);
        return obj;
    }
}