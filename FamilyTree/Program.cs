using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyTree familyTree = new FamilyTree();
            TreeTraveler treeTravaller = new TreeTraveler(familyTree);

            familyTree.AddFamilyMember("DinastyFounder", 1601);

            familyTree.AddFamilyMember("FirstGenSonI", 1621, "DinastyFounder");
            familyTree.AddFamilyMember("FirstGenSonII", 1623, "DinastyFounder");
            familyTree.AddFamilyMember("FirstGenSonIII", 1625, "DinastyFounder");
            familyTree.AddFamilyMember("FirstGenSonIV", 1628, "DinastyFounder");

            familyTree.AddFamilyMember("SecondGenSonI", 1630, "FirstGenSonI");
            familyTree.AddFamilyMember("SecondGenSonII", 1632, "FirstGenSonI");
            familyTree.AddFamilyMember("SecondGenSonBI", 1633, "FirstGenSonII");
            familyTree.AddFamilyMember("SecondGenSonDI", 1640, "FirstGenSonIV");
            familyTree.AddFamilyMember("SecondGenSonDII", 1642, "FirstGenSonIV");
            familyTree.AddFamilyMember("SecondGenSonDIII", 1644, "FirstGenSonIV");

            familyTree.AddFamilyMember("ThirdGenSonI", 1650, "SecondGenSonI");
            familyTree.AddFamilyMember("ThirdGenSonII", 1652, "SecondGenSonI");
            familyTree.AddFamilyMember("ThirdGenSonIII", 1654, "SecondGenSonI");
            familyTree.AddFamilyMember("ThirdGenSonBI", 1650, "SecondGenSonII");
            familyTree.AddFamilyMember("ThirdGenSonEI", 1650, "SecondGenSonDII");

            treeTravaller.GetAllInheritors("FirstGenSonI");
            Console.WriteLine();
            treeTravaller.GetAllInheritors("FirstGenSonIV");
            Console.WriteLine();
            treeTravaller.GetAllInheritors("DinastyFounder");
            Console.ReadKey();
        }
    }
}
