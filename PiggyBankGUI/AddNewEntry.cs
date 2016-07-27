using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiggyBankCore.Domain;
using PiggyBankCore.Enum;
using PiggyBankCore.Services;

namespace PiggyBankGUI
{
    public partial class AddNewEntry : Form
    {
        private BindingSource binding1;
        private CategoryServices myCategoryServices;
        private FamilyMemberServices myFamilyMemberServices;
        private OperationServices myOperationServices;
        

        public AddNewEntry(CategoryServices categoryServices, FamilyMemberServices myMemberServices, OperationServices operationServices)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.myFamilyMemberServices = myMemberServices;
            this.myCategoryServices = categoryServices;
            this.myOperationServices = operationServices;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void AddNewEntry_Load(object sender, EventArgs e)
        {
            //binding1.DataSource = myCategoryServices.GetCategoryDb();

            //CategoryCmb.DataSource = binding1;

            CategoryCmb.DataSource = myCategoryServices.GetCategoryDb();
            CategoryCmb.DisplayMember = "Name";
            CategoryCmb.ValueMember = "Name";

            MemberCmb.DataSource = myFamilyMemberServices.GetFamily();
            MemberCmb.DisplayMember = "Name";
            MemberCmb.ValueMember = "Name";
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OperationType setOperationType;
            
            decimal setAmount = Convert.ToDecimal(AmountMtb.Text);
            
            setOperationType = ActualRbtn1.Checked ? OperationType.Actual : OperationType.Planned;

            DateTime setDate = DatePicker.Value;

            var setCategory = (Category) CategoryCmb.SelectedItem;

            var setMember = (FamilyMember) MemberCmb.SelectedItem;

            myOperationServices.AddOperation(setAmount,setOperationType,setDate,setCategory, setMember);

            this.Close();

            
            

        }

        private void AmountMtb_Click(object sender, EventArgs e)
        {
            AmountMtb.SelectAll();
        }

        private void NotesRtb_Click(object sender, EventArgs e)
        {
            NotesRtb.SelectAll();
        }



    }
}
