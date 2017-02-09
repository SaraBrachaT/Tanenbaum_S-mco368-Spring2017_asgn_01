using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentialEligibilityClassLibrary
{
    public class EligibilityChecker
    {

        bool naturalBorn;
        int age;
        int residentYears;
        bool presLessThanTwice;
        bool convicted;
        bool rebellious;

        public EligibilityChecker(bool nBorn, int age, int resYears, bool presLessThanTwice, bool convicted, bool rebellious)
        {
            naturalBorn = nBorn;
            this.age = age;
            residentYears = resYears;
            this.presLessThanTwice = presLessThanTwice;
            this.convicted = convicted;
            this.rebellious = rebellious;
        }

        public bool check()
        {
            if (naturalBorn == true && age >= 35 && residentYears >= 14 && presLessThanTwice == true && convicted == false && rebellious == false)
                return true;
            return false;
        }
    }
}