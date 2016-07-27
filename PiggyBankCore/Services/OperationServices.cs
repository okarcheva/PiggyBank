using PiggyBankCore.Domain;
using OperationType=PiggyBankCore.Enum.OperationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankCore.Services
{
    public class OperationServices
    {
        private List<Operation> operationDB = new List<Operation>()
        {
            new Operation(500, OperationType.Actual, new DateTime(2015,02,27), new Category("All"), new FamilyMember("Me")) {ID = 1},
            new Operation(5000, OperationType.Actual, new DateTime(2015,03,15), new Category("Electronics"), new FamilyMember("Me")) {ID = 2},
            new Operation(-1000, OperationType.Actual, new DateTime(2015,03,31), new Category("Utilities"), new FamilyMember("Me")) {ID = 3},
            new Operation(-1000, OperationType.Planned, new DateTime(2015,04,30), new Category("Utilities"), new FamilyMember("Me")) {ID = 4},
            new Operation(-800, OperationType.Planned, new DateTime(2015,04,30), new Category("Apartment"), new FamilyMember("Wife")) {ID = 5}
        };

        public void AddOperation(decimal amount, OperationType status, DateTime date, Category category, FamilyMember familyMember)
        {
            operationDB.Add(new Operation(amount,status,date,category,familyMember));          
        }

        public Operation EditOperation(decimal newAmount, OperationType newStatus, DateTime newDate, Category newCategory, FamilyMember newFamilyMember, Operation operationForUpdate)
        {
            operationForUpdate.Amount = newAmount;
            operationForUpdate.Status = newStatus;
            operationForUpdate.Date = newDate;
            operationForUpdate.Category = newCategory;
            operationForUpdate.FamilyMember = newFamilyMember;

            return operationForUpdate;
        }

        public void DeleteOperation(Operation operationForDelete)
        {
            operationDB.Remove(operationForDelete);
        }
        
        public void DeleteOperationByUser(FamilyMember familyMemberForDelete, bool reassignMemberToDefault)
        {
            FamilyMemberServices familyMemberServices = new FamilyMemberServices();
            if (reassignMemberToDefault)
            {
                foreach (Operation operation in operationDB)
                    if (operation.FamilyMember == familyMemberForDelete)
                    {
                        operation.FamilyMember = familyMemberServices.GetDefaultFamilyMember();
                        familyMemberServices.DeleteFamilyMember(familyMemberForDelete);
                    }
            }
            else
            {
                foreach (Operation operation in operationDB)
                    if (operation.FamilyMember == familyMemberForDelete)
                    {
                        DeleteOperation(operation);
                        familyMemberServices.DeleteFamilyMember(familyMemberForDelete);
                    }
            } 
        }

        public void DeleteOperationByCategory(Category categoryForDelete, bool reassignCategoryToDefault)
        {
            CategoryServices categoryServices = new CategoryServices();
            if (reassignCategoryToDefault)
            {
                foreach (Operation operation in operationDB)
                    if (operation.Category == categoryForDelete)
                    {
                        operation.Category = categoryServices.GetDefaultCategory();
                        categoryServices.DeleteCategory(categoryForDelete);
                    }
            }
            else
            {
                foreach (Operation operation in operationDB)
                    if (operation.Category == categoryForDelete)
                    {
                        DeleteOperation(operation);
                        categoryServices.DeleteCategory(categoryForDelete);
                    }
            }
        }

        public List<Operation> FilterByFamilyMembers(List<FamilyMember> familyMembers)
        {
            return operationDB.FindAll(operation => familyMembers.Contains(operation.FamilyMember));
        }

        public List<Operation> FilterByCategories(List<Category> categories)
        {
            return operationDB.FindAll(operation => categories.Contains(operation.Category));
        }

        public List<Operation> FilterByDateRange(DateTime firstDate, DateTime lastDate)
        {
            return operationDB.FindAll(operation => ((operation.Date >= firstDate) && (operation.Date <= lastDate)));
        }

        public List<Operation> FilterByDate(DateTime date)
        {
            return operationDB.FindAll(operation => operation.Date <= date);
        }

        public List<Operation> GetOperationDB()
        {
            return operationDB;
        }
    }
}
