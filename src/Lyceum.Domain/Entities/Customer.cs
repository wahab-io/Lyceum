namespace Lyceum.Domain
{
    public class Customer
    {
        public Customer(
            CustomerId id,
            FirstName firstName,
            LastName lastName,
            EmailAddress emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public readonly CustomerId Id;
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public EmailAddress EmailAddress { get; set; }
    }
}