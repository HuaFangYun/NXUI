namespace MinimalAvalonia.Controls;

public static class AnimationSetterExtensions
{
    public static T Animator<T>(this T animationSetter, Type value) where T : IAnimationSetter
    {
        Animation.SetAnimator(animationSetter, value);
        return animationSetter;
    }
}