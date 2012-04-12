using System;
using System.Collections.Generic;
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

        public static string Email(string name = null)
        {
            return UserName(name) + '@' + DomainName();
        }

        /// <summary>
        /// returns an email address of an online disposable email service (like tempinbox.com).
        /// you can really send an email to these addresses an access it by going to the service web pages.
        /// </summary>
        public static string DisposableEmail(string name = null)
        {
            return UserName(name) + '@' + DISPOSABLE_HOSTS.Rand();
        }

        public static string FreeEmail(string name = null)
        {
            return UserName(name) + "@" + HOSTS.Rand();
        }

        public static string UserName(string name = null)
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
                        return new Regex(@"\W").Replace(Name.FirstName(), "").ToLower();
                    case 1:
                        var parts = new[] { Name.FirstName(), Name.LastName() }.Select(n => new Regex(@"\W").Replace(n, ""));
						return parts.Join(new[] { ".", "_" }.Rand()).ToLower();
                    default: throw new ApplicationException();
                }
            }
        }

        public static string DomainName()
        {
            return DomainWord() + "." + DomainSuffix();
        }

        public static string DomainWord()
        {
            string dw = Company.name().Split(' ').First();
            dw = new Regex(@"\W").Replace(dw, "");
            dw = dw.ToLower();
            return dw;
        }

        public static string DomainSuffix()
        {
            return DOMAIN_SUFFIXES.Rand();
        }

        public static string Uri(string protocol)
        {
            return protocol + "://" + DomainName();
        }

        public static string HttpUrl()
        {
            return Uri("http");
        }

        public static string IP_V4_Address()
        {
            return BYTE.RandPick(4).Join(".");
        }

        private static readonly string[] BYTE; //new [] { ((0..255).to_a.map { |n| n.to_s })
        static readonly string[] HOSTS = new[] { "gmail.com", "yahoo.com", "hotmail.com" };
        static readonly string[] DISPOSABLE_HOSTS = new[] { "mailinator.com", "suremail.info", "spamherelots.com", "binkmail.com", "safetymail.info", "tempinbox.com" };
        static readonly string[] DOMAIN_SUFFIXES = new[] { "co.uk", "com", "us", "uk", "ca", "biz", "info", "name" };
    }
}
