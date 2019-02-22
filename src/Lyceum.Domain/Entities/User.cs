namespace Lyceum.Domain
{
    public class User
    {
        public User(
            UserId id,
            FirstName firstName,
            LastName lastName,
            EmailAddress emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public readonly UserId Id;
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public EmailAddress EmailAddress { get; set; }
    }
}