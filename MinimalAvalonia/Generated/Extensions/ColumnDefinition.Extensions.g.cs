// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ColumnDefinitionExtensions
{
    // MaxWidthProperty

    public static T MaxWidth<T>(this T obj, System.Double value) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.MaxWidthProperty] = value;
        return obj;
    }

    public static T MaxWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.MaxWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding MaxWidth(this Avalonia.Controls.ColumnDefinition obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ColumnDefinition.MaxWidthProperty.Bind().WithMode(mode)];
    }

    // MinWidthProperty

    public static T MinWidth<T>(this T obj, System.Double value) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.MinWidthProperty] = value;
        return obj;
    }

    public static T MinWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.MinWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding MinWidth(this Avalonia.Controls.ColumnDefinition obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ColumnDefinition.MinWidthProperty.Bind().WithMode(mode)];
    }

    // WidthProperty

    public static T Width<T>(this T obj, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.WidthProperty] = value;
        return obj;
    }

    public static T Width<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ColumnDefinition
    {
        obj[Avalonia.Controls.ColumnDefinition.WidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Width(this Avalonia.Controls.ColumnDefinition obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ColumnDefinition.WidthProperty.Bind().WithMode(mode)];
    }
}