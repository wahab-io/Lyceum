using System;
using System.Text.RegularExpressions;
using Guards;

namespace Lyceum.Domain
{
    public class EmailAddress
    {
        public EmailAddress(string value)
        {
            Guard.ArgumentNotNullOrEmpty(value, nameof(EmailAddress));
            try
            {
                if (!Regex.IsMatch(value, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                    throw new ArgumentException(string.Format("Invalid Email Address.\nParameter name: {0}", nameof(EmailAddress)));
                Value = value;
            }
            catch (RegexMatchTimeoutException)
            {
                throw new ArgumentException(string.Format("Invalid Email Address.\nParameter name: {0}", nameof(EmailAddress)));
            }            
        }

        public readonly string Value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is EmailAddress))
                return false;

            var emailAddress = obj as EmailAddress;
            return Value == emailAddress.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}