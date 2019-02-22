namespace Lyceum.Domain
{
    public class TenantId
    {
        public TenantId(long value) => Value = value;

        public readonly long Value;
        

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TenantId))
                return false;

            var tenantId = obj as TenantId;
            return Value == tenantId.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}