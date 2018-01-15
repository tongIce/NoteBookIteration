using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteBookUI
{
    public partial class frmReClass : BaseForm
    {
        public frmReClass()
        {
            InitializeComponent();
        }
        private void btnReName_Click(object sender, EventArgs e)
        {
            MainForm frm = (MainForm)this.Owner;
            frm.nclassname = txtClass.Text.Trim();
            this.Close();
        }
    }
}
