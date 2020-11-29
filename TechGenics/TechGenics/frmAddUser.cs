using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGenics.Models;

namespace TechGenics
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            List<User> _users = new List<User>();
            DataAccess db = new DataAccess();
            _users = db.GetUsers();
            DataSet dsUsers = new DataSet();
            dsUsers = ListToDataSet.ToDataSet(_users);

            DataView viewUserNames= new DataView(dsUsers.Tables[0]);
            DataTable dtUserNames = viewUserNames.ToTable(true, "UserId", "UserName");

            cboUserName.ValueMember = "UserId";
            cboUserName.DisplayMember = "UserName";
            cboUserName.DataSource = dtUserNames;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string userName = cboUserName.Text;
            string usePassword = txtUserPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            bool initiation = cbxInitiation.Checked;
            bool planning = cbxPlanning.Checked;
            bool execution = cbxExecution.Checked;
            bool closeOut = cbxCloseOut.Checked;

            bool validUserName = false;
            bool validPassword = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validEmail = false;

            if (!String.IsNullOrWhiteSpace(userName))
            {
                validUserName = true;
            }
            if (validUserName == false)
            {
                MessageBox.Show("Please enter a user name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(usePassword))
            {
                validPassword = true;
            }
            if (validPassword == false)
            {
                MessageBox.Show("Please enter a user password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(firstName))
            {
                validFirstName = true;
            }
            if (validFirstName == false)
            {
                MessageBox.Show("Please enter a first name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(lastName))
            {
                validLastName = true;
            }
            if (validLastName == false)
            {
                MessageBox.Show("Please enter a last name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(email))
            {
                validEmail = true;
            }
            if (validEmail == false)
            {
                MessageBox.Show("Please enter an email.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validUserName == true && validPassword == true && validFirstName == true && validLastName == true && validEmail == true)
            {
                db.InsertUserByAdmin(userName, usePassword, firstName, lastName, email, initiation, planning, execution, closeOut);
                load();
                MessageBox.Show("The new user has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int userId = (int)cboUserName.SelectedValue;
            string userName = cboUserName.Text;
            string usePassword = txtUserPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            bool initiation = cbxInitiation.Checked;
            bool planning = cbxPlanning.Checked;
            bool execution = cbxExecution.Checked;
            bool closeOut = cbxCloseOut.Checked;

            bool validUserName = false;
            bool validPassword = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validEmail = false;

            if (!String.IsNullOrWhiteSpace(userName))
            {
                validUserName = true;
            }
            if (validUserName == false)
            {
                MessageBox.Show("Please enter a user name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(usePassword))
            {
                validPassword = true;
            }
            if (validPassword == false)
            {
                MessageBox.Show("Please enter a user password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(firstName))
            {
                validFirstName = true;
            }
            if (validFirstName == false)
            {
                MessageBox.Show("Please enter a first name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(lastName))
            {
                validLastName = true;
            }
            if (validLastName == false)
            {
                MessageBox.Show("Please enter a last name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(email))
            {
                validEmail = true;
            }
            if (validEmail == false)
            {
                MessageBox.Show("Please enter an email.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validUserName == true && validPassword == true && validFirstName == true && validLastName == true && validEmail == true)
            {
                db.UpdateUser(userId, userName, usePassword, firstName, lastName, email, initiation, planning, execution, closeOut);
                load();
                MessageBox.Show("The user has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int userId = (int)cboUserName.SelectedValue;
            string userName = cboUserName.Text;

            bool validUserName = false;

            if (!String.IsNullOrWhiteSpace(userName))
            {
                validUserName = true;
            }
            if (validUserName == false)
            {
                MessageBox.Show("Please enter a user name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validUserName == true)
            {
                db.DeleteUser(userId);
                load();
                MessageBox.Show("The user has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
