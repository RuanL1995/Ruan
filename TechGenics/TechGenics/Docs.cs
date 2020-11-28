using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using Word = Microsoft.Office.Interop.Word;

namespace TechGenics
{
    public partial class Docs : Form
    {
        public Docs()
        {
            InitializeComponent();
        }

        private void btnSaveDocToDB_Click(object sender, EventArgs e)
        {
            string projectName = "";
            string projectPhase = "";

        }

        private void Template_SelectedIndexChanged(object sender, EventArgs e)
        {
            object readOnly = true;
            object visible = true;
            object save = false;
            object fileName = "";
            if (cmbTemplate.SelectedIndex == 0)
            {
                //Selects the proposal template.
                fileName = System.IO.Path.GetFullPath(@"..\..\Templates\Request for Proposal.doc");
            }

            if (cmbTemplate.SelectedIndex == 1)
            {
                //Selects the Feasibility study template.
                fileName = System.IO.Path.GetFullPath(@"..\..\Templates\Business Case.doc");
            }

            if (cmbTemplate.SelectedIndex == 2)
            {
                //Selects the Business Case template.
                fileName = System.IO.Path.GetFullPath(@"..\..\Templates\Business Case.doc");
            }
            object missing = Type.Missing;
            object newTemplate = false;
            object docType = 0;
            Microsoft.Office.Interop.Word._Document oDoc = null;
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
            oDoc = oWord.Documents.Open(
                    ref fileName, ref missing, ref readOnly, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref visible,
                    ref missing, ref missing, ref missing, ref missing);
            oDoc.ActiveWindow.Selection.WholeStory();
            //Copies word content
            oDoc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            TextEditor.Rtf = data.GetData(DataFormats.Rtf).ToString();
            oWord.Quit(ref missing, ref missing, ref missing);
        }

        private void AutosaveDoc_TextChanged(object sender, EventArgs e)
        {
            if (AutoSave.Checked)
            {
                if (cmbTemplate.SelectedIndex == 0)
                {
                    //Automatically saves the Proposal to the docs folder
                    TextEditor.SaveFile(System.IO.Path.GetFullPath(@"../../Docs/ProjectName_Proposal.doc"));
                }

                if (cmbTemplate.SelectedIndex == 1)
                {
                    //Automatically saves the feasibility study to the docs folder
                    TextEditor.SaveFile(System.IO.Path.GetFullPath(@"../../Docs/ProjectName_Feasibility Study.doc"));
                }

                if (cmbTemplate.SelectedIndex == 2)
                {
                    //Automatically saves the business case to the docs folder
                    TextEditor.SaveFile(System.IO.Path.GetFullPath(@"../../Docs/ProjectName_Business Case.doc"));
                }
            }
        }

        private void AutoSave_IsChecked(object sender, EventArgs e)
        {
            if(AutoSave.Checked)
            {
                MessageBox.Show("You have activated the AutoSave, this document will be saved as you type.", "AutoSave is On", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("AutoSave is off, this document will be saved as you type.", "AutoSave is Off", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
