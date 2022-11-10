// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class style setters extension methods.
/// </summary>
public static partial class AnimatorKeyFrameSetters
{
    // Avalonia.Animation.AnimatorKeyFrame.ValueProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatorKeyFrameValue(this Style style, System.Object value)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatorKeyFrameValue(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatorKeyFrameValue(this Style style, IObservable<System.Object> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatorKeyFrameValue(this KeyFrame keyFrame, System.Object value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatorKeyFrameValue(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.AnimatorKeyFrame.ValueProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatorKeyFrameValue(this KeyFrame keyFrame, IObservable<System.Object> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.AnimatorKeyFrame.ValueProperty, observable.ToBinding()));
        return keyFrame;
    }
}