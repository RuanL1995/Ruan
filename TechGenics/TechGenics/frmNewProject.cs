using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechGenics
{
    public partial class frmNewProject : Form
    {
        public frmNewProject()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            pnlTasks.SendToBack();
            pnlNewTask.SendToBack();

            pnlViewTask.Visible = true;
            pnlViewTask.BringToFront();

            label12.Text = btnTask1.Text;

           
        }

        private void button14_Click(object sender, EventArgs e)
        {

            //pnlTasks.Visible = false;
            
            pnlTasks.SendToBack();
            pnlViewTask.SendToBack();

            pnlNewTask.Visible = true;
            pnlNewTask.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskname = txtbxTaskName.Text;
            int numofMiniTasks = Convert.ToInt32(txtbxNumMiniTasks.Text);
            string nameofMiniTasks = txtbxMiniTasks.Text;
            string assignedTo = txtbxAssignedTo.Text;
            string taskDescription = rTxtbxTaskDescrip.Text;
            bool minitask = false;

            if(taskname == "" || assignedTo == "" || taskDescription == "")
            {
                MessageBox.Show("Please fill in all necessary task information!", "Invalid Task Entries");
            }

            if(numofMiniTasks > 0 && nameofMiniTasks == "")
            {
                MessageBox.Show("Please Enter information for mini tasks!", "Invalid information for mini tasks!");
            }

            if (numofMiniTasks > 0 && nameofMiniTasks != "")
            {
                minitask = true;
            }


            else if(taskname != "" && (minitask == true || numofMiniTasks == 0) && assignedTo != "" && taskDescription != "")
            {
                MessageBox.Show(taskname + " task, saved to database!", "Task Successfully saved!");
                pnlNewTask.Visible = false;
                pnlNewTask.SendToBack();

                pnlTasks.Visible = true;
                pnlTasks.BringToFront();

                txtbxTaskName.Clear();
                txtbxNumMiniTasks.Clear();
                txtbxMiniTasks.Clear();
                rTxtbxTaskDescrip.Clear();
                txtbxAssignedTo.Clear();

            }
        }

        private void pnlNewTask_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlNewTask.Visible = false;
            pnlNewTask.SendToBack();

            pnlTasks.Visible = true;
            pnlTasks.BringToFront();

            txtbxTaskName.Clear();
            txtbxNumMiniTasks.Clear();
            txtbxMiniTasks.Clear();
            rTxtbxTaskDescrip.Clear();
            txtbxAssignedTo.Clear();





        }

        private void button19_Click(object sender, EventArgs e)
        {
            pnlViewTask.Visible = false;
            pnlViewTask.SendToBack();
            pnlNewTask.Visible = false;
            pnlNewTask.SendToBack();

            pnlTasks.Visible = true;
            pnlTasks.BringToFront();

            

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
