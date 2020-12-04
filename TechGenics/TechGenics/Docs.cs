using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Word;
//using Application = Microsoft.Office.Interop.Word.Application;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using DataTable = System.Data.DataTable;
using TechGenics.Models;
using System.Runtime.Remoting.Contexts;
using Microsoft.VisualBasic;

namespace TechGenics
{
    public partial class Docs : Form
    {
        public Docs()
        {
            InitializeComponent();
            controls.SetInitial(this);
        }

        private void btnSaveDocToDB_Click(object sender, EventArgs e)
        {
            string projectName = "";
            string projectPhase = "";

        }

       
        private void btnDocBack_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rgbExcel.Checked && (cmbOpen.Text == "Planning"))
            {
                string assemblyPath = Application.StartupPath;
                
                string filename = Application.StartupPath + "\\Templates\\Planning\\_Create_New_File_.xlsx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbWord.Checked && (cmbOpen.Text == "Planning"))
            {
                
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Planning\\_Create_New_File_.docx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbExcel.Checked && (cmbOpen.Text== "Initiation"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Initiation\\_Create_New_File_.xlsx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbWord.Checked && (cmbOpen.Text == "Initiation"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Initiation\\_Create_New_File_.docx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbExcel.Checked && (cmbOpen.Text == "Execution"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Execution\\_Create_New_File_.xlsx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbWord.Checked && (cmbOpen.Text == "Execution"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Execution\\_Create_New_File_.docx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbExcel.Checked && (cmbOpen.Text == "CloseOut"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Closure\\_Create_New_File_.xlsx";

                System.Diagnostics.Process.Start(filename);
            }
            else if (rgbWord.Checked && (cmbOpen.Text == "CloseOut"))
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Closure\\_Create_New_File_.docx";

                System.Diagnostics.Process.Start(filename);
            }
        }

        private void radExistingDoc_CheckedChanged(object sender, EventArgs e)
        {
            pnlTemp.Visible = true;
            pnlTemp.BringToFront();

            pnlNew.Visible = false;
        }

        private void rgbInitiation_CheckedChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Templates\\Initiation";
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Path");

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name, path + "\\" + file.Name);
            }

            cmbTemplate.DataSource = table;
            cmbTemplate.DisplayMember = "File Name";
            cmbTemplate.ValueMember = "File Path";
        }

        private void rgbPlanning_CheckedChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Templates\\Planning";
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Path");

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name, path + "\\" + file.Name);
            }

            cmbTemplate.DataSource = table;
            cmbTemplate.DisplayMember = "File Name";
            cmbTemplate.ValueMember = "File Path";
        }

        private void rgbExecution_CheckedChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Templates\\Execution";
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Path");

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name, path + "\\" + file.Name);
            }

            cmbTemplate.DataSource = table;
            cmbTemplate.DisplayMember = "File Name";
            cmbTemplate.ValueMember = "File Path";
        }

        private void rgbCloseOut_CheckedChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Templates\\Closure";
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Path");

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name, path + "\\" + file.Name);
            }

            cmbTemplate.DataSource = table;
            cmbTemplate.DisplayMember = "File Name";
            cmbTemplate.ValueMember = "File Path";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (rgbClose.Checked)
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Closure\\" + cmbTemplate.Text;

                System.Diagnostics.Process.Start(filename);

            }
            else if (rgbExecution.Checked)
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Execution\\" + cmbTemplate.Text;

                System.Diagnostics.Process.Start(filename);

            }
            else if (rgbInitiation.Checked)
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Initiation\\" + cmbTemplate.Text;

                System.Diagnostics.Process.Start(filename);

            }
            else if (rgbPlanning.Checked)
            {
                string assemblyPath = Application.StartupPath;

                string filename = Application.StartupPath + "\\Templates\\Planning\\" + cmbTemplate.Text;

                System.Diagnostics.Process.Start(filename);

            }
        }

        private void radNewDoc_CheckedChanged(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
            pnlTemp.Visible = false;
            pnlNew.BringToFront();
        }

        private void Docs_Load(object sender, EventArgs e)
        {
            cmbOpen.Text = "Initiation";
        }
    }
}
