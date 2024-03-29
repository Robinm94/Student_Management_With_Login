using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class StudentSelectionForm : Form
    {
        public int selectedStudentIndex = -1;
        public StudentSelectionForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelectStudent_Click(object sender, EventArgs e)
        {
            selectedStudentIndex = lstStudentSelection.SelectedIndex;
            this.Close();
        }

        private void LstStudentSelection_DoubleClick(object sender, EventArgs e)
        {
            if(lstStudentSelection.SelectedIndex >= 0)
            {
                selectedStudentIndex = lstStudentSelection.SelectedIndex;
                this.Close();
            }
        }
    }
}
