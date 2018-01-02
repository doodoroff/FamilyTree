using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class TreeTraveler
    {
        FamilyTree familyTree;
        FamilyMember currentRelative;
        IEnumerator<FamilyMember> relativesListTravaller;
        IFamilyTreeEnumerable familyTreeMod;
        Enumerator familyTreeTravaller;
        List<FamilyMember> inharitorsList;
        int inharritorIndex;
        bool firsInheritorFlag;

        public TreeTraveler(FamilyTree familyTree)
        {
            this.familyTree = familyTree;
            this.familyTreeMod = familyTree;

            this.relativesListTravaller = familyTree.GetEnumerator();
            this.familyTreeTravaller = familyTreeMod.GetEnumerator();
        }

        public void GetAllInheritors(string inheritorName)
        {
            FindByName(inheritorName);

            SetSearchDefaults();

            SearchInheritors(currentRelative);

            ShowInharitors();
        }

        void FindByName(string name)
        {
            foreach (FamilyMember relative in familyTree)
            {
                if (relative.Name == name)
                {
                    this.currentRelative = relative;
                }
            }
        }

        void SetSearchDefaults()
        {
            inharitorsList = new List<FamilyMember>();
            firsInheritorFlag = true;
            inharritorIndex = 0;
        }

        void SearchInheritors(FamilyMember relative)
        {
            foreach (FamilyMember inharitor in familyTree)
            {
                if (inharitor.Parent == relative && !inharitorsList.Contains(inharitor))
                {
                    inharitorsList.Add(inharitor);
                }
            }

            if (inharritorIndex < inharitorsList.Count)
            {
                SearchInheritors(inharitorsList[GetIndexOfInheritor()]);
            }
        }

        int GetIndexOfInheritor()
        {
            if (firsInheritorFlag)
            {
                firsInheritorFlag = false;
                return inharritorIndex;
            }
            else
            {
                return inharritorIndex++;
            }
        }

        void ShowInharitors()
        {
            foreach (FamilyMember inharitor in inharitorsList)
            {
                Console.WriteLine(inharitor.Name);
            }
        }

        public void FindByYear(int year)
        {
            foreach (FamilyMember relative in familyTree)
            {
                if (relative.YearOfBirth == year)
                {
                    Console.WriteLine(relative.Name);
                }
            }
        }


    }
}
