﻿using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static partial class Templates
{
    public static string BuildersHeaderTemplate = """ 
// <auto-generated />
namespace NXUI;

/// <summary>
/// The avalonia builders.
/// </summary>
public static partial class Builders
{
""";

    public static string BuildersTemplate = """
    /// <summary>
    /// Creates a new instance of the <see cref="%ClassType%"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="%ClassType%"/> class.</returns>
    public static %ClassType% %ClassName%() => new();

    /// <summary>
    /// Creates a new instance of the <see cref="%ClassType%"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="%ClassType%"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="%ClassType%"/> class.</returns>
    public static %ClassType% %ClassName%(out %ClassType% @ref) => @ref = new();
""";

    public static string BuildersFooterTemplate = """
}
""";
}
