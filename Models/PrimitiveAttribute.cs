using System;

namespace Liversage.Primitives;

[AttributeUsage(AttributeTargets.Struct)]
#if !IS_GENERATOR
public
#endif
sealed class PrimitiveAttribute : Attribute
{
    public PrimitiveAttribute(Features features = Features.Default) => Features = features;

    public Features Features { get; }

    public StringComparison StringComparison { get; set; } = StringComparison.Ordinal;

    public bool MarkAsNonUserCode { get; set; } = true;
}
