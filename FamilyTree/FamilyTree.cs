using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class FamilyTree : IEnumerable<FamilyMember>, IFamilyTreeEnumerable
    {
        List<FamilyMember> familyMemberList = new List<FamilyMember>();
        FamilyMember relative;
        Enumerator enumerator;

        public FamilyMember this[int index]
        {
            get { return familyMemberList[index]; }
        }
        

        public void AddFamilyMember(string name, int yearOfBirth)
        {
            FamilyMember familyMember = new FamilyMember(name, yearOfBirth);
            familyMemberList.Add(familyMember);
        }

        public void AddFamilyMember(string name, int yearOfBirth, string parentName)
        {
            foreach (FamilyMember relative in familyMemberList)
            {
                if(relative.Name == parentName)
                {
                    this.relative = relative;
                    break;
                }
                //TO DO: check this.relative for null value
            }

            FamilyMember familyMember = new FamilyMember(name, yearOfBirth, this.relative);
            familyMemberList.Add(familyMember);
        }

        public IEnumerator<FamilyMember> GetEnumerator()
        {
            return familyMemberList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Enumerator IFamilyTreeEnumerable.GetEnumerator()
        {
            enumerator = new Enumerator(this);
            return enumerator;
        }
    }
}
