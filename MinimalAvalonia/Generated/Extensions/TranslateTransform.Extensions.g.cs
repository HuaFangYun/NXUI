// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TranslateTransformExtensions
{
    // XProperty

    public static T X<T>(this T obj, System.Double value) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.XProperty] = value;
        return obj;
    }

    public static T X<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding X(this Avalonia.Media.TranslateTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode)];
    }

    // YProperty

    public static T Y<T>(this T obj, System.Double value) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.YProperty] = value;
        return obj;
    }

    public static T Y<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.TranslateTransform
    {
        obj[Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Y(this Avalonia.Media.TranslateTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode)];
    }
}