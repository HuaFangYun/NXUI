// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class RadioButtonSetters
{
    // GroupNameProperty

    public static Style SetRadioButtonGroupName(this Style style, System.String value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, value));
        return style;
    }

    public static Style SetRadioButtonGroupName(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, binding));
        return style;
    }

    public static Style SetRadioButtonGroupName(this Style style, IObservable<System.String> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, System.String value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, IObservable<System.String> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, observable.ToBinding()));
        return keyFrame;
    }
}