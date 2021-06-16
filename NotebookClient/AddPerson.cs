using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class AddPerson : Form
    {
        public bool save;

        public string pFirstName
        { 
            get { return FirstName.Text; } 
        }
        public string pSecondName
        { 
            get { return SecondName.Text; } 
        }
        public string pBirthday
        { 
            get { return Birthday.Text; } 
        }
        public AddPerson()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save = false;
            this.Close();
        }
    }
}
