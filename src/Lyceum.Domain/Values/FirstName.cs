using System;
using Guards;

namespace Lyceum.Domain
{
    public class FirstName
    {
        public FirstName(string value)
        {
            Guard.ArgumentNotNullOrEmpty(value, nameof(FirstName));
            Value = value;
        }

        public readonly string Value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is FirstName))
                return false;

            var firstName = obj as FirstName;
            return string.Equals(Value, firstName.Value, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}