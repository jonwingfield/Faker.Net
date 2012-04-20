using System;
using Faker.Extensions;

namespace Faker
{
    public static class Education
    {
        public static string GetDegreeShort()
        {
            return DEGREE_SHORT_PREFIX.Rand() + " in " + GetMajor();
        }

        public static string GetDegree()
        {
            return DEGREE_PREFIX.Rand() + " in " + GetMajor();
        }

        public static string GetMajor()
        {
            return MAJOR_ADJ.Rand() + " " + MAJOR_NOUN.Rand();
        }

        public static string GetSchoolName()
        {
            return SCHOOL_PREFIX.Rand() + SCHOOL_SUFFIX.Rand();
        }

        public static string GetSchoolGenericName()
        {
            switch (FakerRandom.Rand.Next(2))
            {
                case 0: return Address.GetUSState();
                default: return GetSchoolName();

            }
        }

        public static string GetSchool()
        {
            switch (FakerRandom.Rand.Next(5))
            {
                case 0:
                case 1: return  GetSchoolName()+ " " +SCHOOL_TYPE.Rand();
                case 2: return  GetSchoolGenericName()+ " " + SCHOOL_ADJ.Rand() + " " + SCHOOL_TYPE.Rand();
                case 3: return  SCHOOL_UNI.Rand() + " of " + GetSchoolGenericName();
                default: return GetSchoolGenericName() + " " + SCHOOL_TYPE.Rand() + " of " + MAJOR_NOUN.Rand();
            }
        }
		
		[Obsolete]
        public static string DegreeShort()
        {
			return GetDegreeShort();
        }
		
		[Obsolete]
        public static string Degree()
        {
			return GetDegree();
        }
		
		[Obsolete]
        public static string Major()
        {
			return GetMajor();
        }
		
		[Obsolete]
        public static string SchoolName()
        {
			return GetSchoolName();
        }
		
		[Obsolete]
        public static string SchoolGenericName()
        {
			return GetSchoolGenericName();
        }
		
		[Obsolete]
        public static string School()
        {
			return GetSchool();
        }

        static readonly string[] DEGREE_SHORT_PREFIX = new[] { "AB", "BS", "BSc", "MA", "MD", "DMus", "DPhil" };
        static readonly string[] DEGREE_PREFIX = new[] { "Bachelor of Science", "Bachelor of Arts", "Master of Arts", "Doctor of Medicine", "Bachelor of Music", "Doctor of Philosophy" };
        static readonly string[] MAJOR_ADJ = new[] { "Business", "Systems", "Industrial", "Medical", "Financial", "Marketing", "Political", "Social", "Human", "Resource" };
        static readonly string[] MAJOR_NOUN = new[] { "Science", "Arts", "Administration", "Engineering", "Management", "Production", "Economics", "Architecture", "Accountancy", "Education", "Development", "Philosophy", "Studies" };

        static readonly string[] SCHOOL_PREFIX = new[] { "Green", "South", "North", "Wind", "Lake", "Hill", "Lark", "River", "Red", "White" };
        static readonly string[] SCHOOL_SUFFIX = new[] { "wood", "dale", "ridge", "ville", "point", "field", "shire", "shore", "crest", "spur", "well", "side", "coast" };
        static readonly string[] SCHOOL_ADJ = new[] { "International", "Global", "Polytechnic", "National" };
        static readonly string[] SCHOOL_TYPE = new[] { "School", "University", "College", "Institution", "Academy" };
        static readonly string[] SCHOOL_UNI = new[] { "University", "College" };
    }
}
