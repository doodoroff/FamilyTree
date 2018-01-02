using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class Enumerator
    {

        readonly FamilyTree familyTree;
        FamilyMember currentFamilyMember;

        public Enumerator(FamilyTree familyTree)
        {
            this.familyTree = familyTree;
        }

        public FamilyMember Current
        {
            get { return currentFamilyMember; }
        }

        public void Dispose()
        {

        }

        /*public bool MoveNext()
        {
            if (currentFamilyMember == null)
            {
                SetFirstElement();
            }

        }*/

        void SetFirstElement()
        {
            foreach(FamilyMember relative in familyTree)
            {
                if (relative.Parent == null)
                {
                    currentFamilyMember = relative;
                    break;
                }
            }
        }

        public void Reset()
        {
            currentFamilyMember = null;
        }
    }
}
