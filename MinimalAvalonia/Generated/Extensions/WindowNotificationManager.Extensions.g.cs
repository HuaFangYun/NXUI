// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class WindowNotificationManagerExtensions
{
    // PositionProperty

    public static T Position<T>(this T obj, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = value;
        return obj;
    }

    public static T Position<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Position(this Avalonia.Controls.Notifications.WindowNotificationManager obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty.Bind().WithMode(mode)];
    }

    public static T PositionTopLeft<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.TopLeft;
        return obj;
    }

    public static T PositionTopRight<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.TopRight;
        return obj;
    }

    public static T PositionBottomLeft<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.BottomLeft;
        return obj;
    }

    public static T PositionBottomRight<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.BottomRight;
        return obj;
    }

    // MaxItemsProperty

    public static T MaxItems<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty] = value;
        return obj;
    }

    public static T MaxItems<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding MaxItems(this Avalonia.Controls.Notifications.WindowNotificationManager obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty.Bind().WithMode(mode)];
    }
}