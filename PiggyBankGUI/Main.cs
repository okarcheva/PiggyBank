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
using PiggyBankCore.Services;

namespace PiggyBankGUI
{
    public partial class Main : Form
    {
        private CategoryServices myCategoryServices;
        private OperationServices myOperationServices;
        private FamilyMemberServices myMemberServices;

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myCategoryServices = new CategoryServices();
            myOperationServices = new OperationServices();
            myMemberServices = new FamilyMemberServices();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEntry formAddNewEntry = new AddNewEntry(myCategoryServices,myMemberServices,myOperationServices);
            formAddNewEntry.ShowDialog();
            //OperationsGrid.DataSource = myOperationServices.GetOperationDB();
            
            OperationsGrid.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCategories formManageCategories = new ManageCategories();
            formManageCategories.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageMembers formManageMembers = new ManageMembers();
            formManageMembers.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by ...");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CategoryLstbx.DataSource = myCategoryServices.GetCategoryDb();
            CategoryLstbx.DisplayMember="Name";

            MemberLstbx.DataSource = myMemberServices.GetFamily();
            MemberLstbx.DisplayMember = "Name";

            OperationsGrid.DataSource = new BindingList<Operation>(myOperationServices.GetOperationDB());
            
        }





    }
}
