using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Faker
{
    public static class Education
    {
        public static string DegreeShort()
        {
            return DEGREE_SHORT_PREFIX.Rand() + " in " + Major();
        }

        public static string Degree()
        {
            return DEGREE_PREFIX.Rand() + " in " + Major();
        }

        public static string Major()
        {
            return MAJOR_ADJ.Rand() + " " + MAJOR_NOUN.Rand();
        }

        public static string SchoolName()
        {
            return SCHOOL_PREFIX.Rand() + SCHOOL_SUFFIX.Rand();
        }

        public static string SchoolGenericName()
        {
            switch (new Random().Next(2))
            {
                case 0: return Address.USState();
                default: return SchoolName();

            }
        }

        public static string School()
        {
            switch (new Random().Next(5))
            {
                case 0:
                case 1: return  SchoolName()+ " " +SCHOOL_TYPE.Rand();
                case 2: return  SchoolGenericName()+ " " + SCHOOL_ADJ.Rand() + " " + SCHOOL_TYPE.Rand();
                case 3: return  SCHOOL_UNI.Rand() + " of " + SchoolGenericName();
                default: return SchoolGenericName() + " " + SCHOOL_TYPE.Rand() + " of " + MAJOR_NOUN.Rand();
            }
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
