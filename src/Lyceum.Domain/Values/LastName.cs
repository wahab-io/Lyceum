using System;
using Guards;

namespace Lyceum.Domain
{
    public class LastName
    {
        public LastName(string value)
        {
            Guard.ArgumentNotNullOrEmpty(value, nameof(LastName));
            Value = value;
        }
        public readonly string Value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is LastName))
                return false;

            var lastName = obj as LastName;
            return string.Equals(Value, lastName.Value, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}