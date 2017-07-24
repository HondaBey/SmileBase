using SmileBase.Accounting;
using SmileBase.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainToolbarsManager_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "AddStudentButton":
                    var newStudentForm = new NewStudentForm();
                    newStudentForm.StartPosition = FormStartPosition.CenterParent;
                    newStudentForm.ShowDialog();
                    break;
                case "Show Students":
                    var testMdiChildForm = new NewStudentForm();
                    testMdiChildForm.MdiParent = this;
                    testMdiChildForm.Dock = DockStyle.Fill;
                    testMdiChildForm.Show();
                    break;
                case "MainMenuExitButton":
                    Close();
                    break;
                case "Show George Account":
                    var georgeAccountForm = new GeorgeAccountForm();
                    georgeAccountForm.Dock = DockStyle.Fill;
                    georgeAccountForm.Show();
                    break;


            }

        }

    }
}

