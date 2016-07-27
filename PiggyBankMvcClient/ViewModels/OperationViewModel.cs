using PiggyBankCore.Domain;
using PiggyBankCore.Enum;
using System;
using System.Web.Mvc;

namespace PiggyBankMvcClient.ViewModels
{
    public class OperationViewModel
    {
        public int ID { get; set; }
        public SelectList CategoriesList { get; set; }
        public SelectList FamilyMembersList { get; set; }
        public Category SelectedCategory { get; set; }
        public FamilyMember SelectedFamilyMember { get; set; }
        public decimal Amount { get; set; }
        public OperationType Status { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}