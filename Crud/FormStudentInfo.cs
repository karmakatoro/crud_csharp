using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormStudentInfo : Form
    {
        public FormStudentInfo()
        {
            InitializeComponent();
            display();
        }
        public void display()
        {
            DbStudent.displayAndSearch("SELECT id,name,reg,class,section FROM t_student", dataGridView);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(this);
            form.ShowDialog();
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
