using Raftel.Domain.BaseTypes;

namespace InkDesk.Domain.Customers.ValueObjects;

public sealed record CustomerId : TypedGuidId
{
    public CustomerId(Guid value) : base(value)
    {
    }

    public static CustomerId New() => new(Guid.NewGuid());
}

public readonly record struct Name
{
    private readonly string _value;

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be empty.", nameof(value));
        }

        _value = value;
    }

    public override string ToString() => _value;

    public static implicit operator string(Name name) => name._value;
    public static implicit operator Name(string value) => new(value);
}