using PiggyBankCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Services
{
    public class FamilyMemberServices
    {
        private List<FamilyMember> family = new List<FamilyMember>()
        {
            new FamilyMember ("Me") {ID = -1},
            new FamilyMember("Cat") {ID = 1},
            new FamilyMember("Wife") {ID = 2},
            new FamilyMember("Mother") {ID = 3}
        };        
        
        public void AddFamilyMember(string name)
        {
            family.Add(new FamilyMember(name));
        }

        public FamilyMember EditFamilyMember(string newName, FamilyMember familyMemberForUpdate)
        {
            familyMemberForUpdate.Name=newName;
            return familyMemberForUpdate;
        }

        public void DeleteFamilyMember(FamilyMember familyMemberForDelete)
        {
            family.Remove(familyMemberForDelete);                    
        }

        public FamilyMember GetDefaultFamilyMember()
        {
            return family.Find(member => member.ID == -1);
        }

        public List<FamilyMember> GetFamily()
        {
            return family;
        }
        
    }
}
