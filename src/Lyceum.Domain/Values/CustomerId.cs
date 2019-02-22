using System;

namespace Lyceum.Domain
{
    public class CustomerId
    {
        public CustomerId(long id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(CustomerId));

            Value = id;
        }

        public readonly long Value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CustomerId))
                return false;
                
            var customerId = obj as CustomerId;
            return Value == customerId.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}