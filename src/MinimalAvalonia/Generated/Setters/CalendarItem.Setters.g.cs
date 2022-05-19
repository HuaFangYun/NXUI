// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class CalendarItemSetters
{
    // HeaderBackgroundProperty

    public static Style SetCalendarItemHeaderBackground(this Style style, Avalonia.Media.IBrush value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, value));
        return style;
    }

    public static Style SetCalendarItemHeaderBackground(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding));
        return style;
    }

    public static Style SetCalendarItemHeaderBackground(this Style style, IObservable<Avalonia.Media.IBrush> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetCalendarItemHeaderBackground(this KeyFrame keyFrame, Avalonia.Media.IBrush value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetCalendarItemHeaderBackground(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetCalendarItemHeaderBackground(this KeyFrame keyFrame, IObservable<Avalonia.Media.IBrush> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, observable.ToBinding()));
        return keyFrame;
    }

    // DayTitleTemplateProperty

    public static Style SetCalendarItemDayTitleTemplate(this Style style, Avalonia.Controls.ITemplate<Avalonia.Controls.IControl> value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, value));
        return style;
    }

    public static Style SetCalendarItemDayTitleTemplate(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding));
        return style;
    }

    public static Style SetCalendarItemDayTitleTemplate(this Style style, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetCalendarItemDayTitleTemplate(this KeyFrame keyFrame, Avalonia.Controls.ITemplate<Avalonia.Controls.IControl> value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetCalendarItemDayTitleTemplate(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetCalendarItemDayTitleTemplate(this KeyFrame keyFrame, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, observable.ToBinding()));
        return keyFrame;
    }
}