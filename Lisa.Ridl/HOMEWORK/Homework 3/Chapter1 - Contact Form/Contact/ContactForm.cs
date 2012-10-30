using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0.\nWritten By: Lisa Ridl", "About");
            MessageBox.Show("Test Text");
            MessageBox.Show("Test");

        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
