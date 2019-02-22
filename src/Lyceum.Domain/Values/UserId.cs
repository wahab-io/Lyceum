namespace Lyceum.Domain
{
    using Guards;
    public class UserId
    {
        public UserId(long id)
        {
            Guard.ArgumentIsNotNegative(id, nameof(UserId));
            Value = id;
        }

        public readonly long Value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is UserId))
                return false;

            var userId = obj as UserId;
            return Value == userId.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}