namespace ModularMonolith.Net.FeatureOne.Domain.ValueObjects;

/// <summary>
/// A sample value object with custom equality.
/// </summary>
public readonly record struct FeatureOneValueObject(string Value)
{
    /// <summary>
    /// Creates a new instance of <see cref="FeatureOneValueObject"/>.
    /// </summary>
    /// <param name="value">The value to initialize with.</param>
    /// <returns>A new <see cref="FeatureOneValueObject"/> instance.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is null or whitespace.</exception>
    public static FeatureOneValueObject Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be empty", nameof(value));
        }
        return new FeatureOneValueObject(value);
    }

    /// <summary>
    /// Determines whether this instance and another <see cref="FeatureOneValueObject"/> are equal.
    /// Equality is case-insensitive.
    /// </summary>
    /// <param name="other">The other <see cref="FeatureOneValueObject"/> to compare.</param>
    /// <returns><c>true</c> if the instances are equal; otherwise, <c>false</c>.</returns>
    public bool Equals(FeatureOneValueObject other)
    {
        return string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Returns the hash code for this instance.
    /// </summary>
    /// <returns>A hash code based on the value.</returns>
    public override int GetHashCode()
    {
        return StringComparer.OrdinalIgnoreCase.GetHashCode(Value);
    }
}