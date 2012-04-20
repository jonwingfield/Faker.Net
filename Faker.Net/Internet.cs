using System;
using System.Linq;
using System.Text.RegularExpressions;
using Faker.Extensions;

namespace Faker
{
    public static class Internet
    {
        static Internet()
        {
            BYTE = 0.To(255).Select(item => item.ToString()).ToArray();
        }

        public static string GetEmail(string name = null)
        {
            return GetUserName(name) + '@' + GetDomainName();
        }

        /// <summary>
        /// Returns an email address of an online disposable email service (like tempinbox.com).
        /// you can really send an email to these addresses an access it by going to the service web pages.
        /// <param name="name">User Name initial value.</param>
        /// </summary>
        public static string GetDisposableEmail(string name = null)
        {
            return GetUserName(name) + '@' + DISPOSABLE_HOSTS.Rand();
        }

        public static string GetFreeEmail(string name = null)
        {
            return GetUserName(name) + "@" + HOSTS.Rand();
        }

        public static string GetUserName(string name = null)
        {
            if (name != null)
            {
                string parts = name.Split(' ').Join(new[] { ".", "_" }.Rand());
                return parts.ToLower();
            }
            else
            {
                switch (FakerRandom.Rand.Next(2))
                {
                    case 0:
                        return new Regex(@"\W").Replace(Name.GetFirstName(), "").ToLower();
                    case 1:
                        var parts = new[] { Name.GetFirstName(), Name.GetLastName() }.Select(n => new Regex(@"\W").Replace(n, ""));
						return parts.Join(new[] { ".", "_" }.Rand()).ToLower();
                    default: throw new ApplicationException();
                }
            }
        }

        public static string GetDomainName()
        {
            return GetDomainWord() + "." + GetDomainSuffix();
        }

        public static string GetDomainWord()
        {
            string dw = Company.GetName().Split(' ').First();
            dw = new Regex(@"\W").Replace(dw, "");
            dw = dw.ToLower();
            return dw;
        }

        public static string GetDomainSuffix()
        {
            return DOMAIN_SUFFIXES.Rand();
        }

        public static string GetUri(string protocol)
        {
            return protocol + "://" + GetDomainName();
        }

        public static string GetHttpUrl()
        {
            return GetUri("http");
        }

        public static string GetIP_V4_Address()
        {
            return BYTE.RandPick(4).Join(".");
        }

		[Obsolete]
        public static string Email(string name = null)
        {
			return GetEmail(name);
        }
		
		[Obsolete]
        public static string DisposableEmail(string name = null)
        {
			return GetDisposableEmail(name);
        }
		
		[Obsolete]
        public static string FreeEmail(string name = null)
        {
			return GetFreeEmail(name);
        }
		
		[Obsolete]
        public static string UserName(string name = null)
        {
			return GetUserName(name);
        }
		
		[Obsolete]
        public static string DomainName()
        {
			return GetDomainName();
        }
		
		[Obsolete]
        public static string DomainWord()
        {
			return GetDomainWord();
        }
		
		[Obsolete]
        public static string DomainSuffix()
        {
			return GetDomainSuffix();
        }
		
		[Obsolete]
        public static string Uri(string protocol)
        {
			return GetUri(protocol);
        }
		
		[Obsolete]
        public static string HttpUrl()
        {
			return GetHttpUrl();
        }
		
		[Obsolete]
        public static string IP_V4_Address()
        {
			return GetIP_V4_Address();
        }

        private static readonly string[] BYTE; //new [] { ((0..255).to_a.map { |n| n.to_s })
        static readonly string[] HOSTS = new[] { "gmail.com", "yahoo.com", "hotmail.com" };
        static readonly string[] DISPOSABLE_HOSTS = new[] { "mailinator.com", "suremail.info", "spamherelots.com", "binkmail.com", "safetymail.info", "tempinbox.com" };
        static readonly string[] DOMAIN_SUFFIXES = new[] { "co.uk", "com", "us", "uk", "ca", "biz", "info", "name" };
    }
}
