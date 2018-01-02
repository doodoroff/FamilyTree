using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class FamilyMember
    {
        readonly string name;
        readonly int yearOfBirth;
        readonly FamilyMember parent;

        public FamilyMember(string name, int yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
        }

        public FamilyMember(string name, int yearOfBirth, FamilyMember parent)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.parent = parent;
        }

        public string Name
        {
            get { return name; }
        }

        public int YearOfBirth
        {
            get { return yearOfBirth; }
        }

        public FamilyMember Parent
        {
            get { return parent; }
        }

    }
}
