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
            string query = "SELECT id, name, reg,class,section FROM t_student";
            DbStudent.displayAndSearch(query, dataGridView);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string toSearch = textSearch.Text.Trim();
            string query = "SELECT id, name, reg,class,section FROM t_student WHERE name LIKE'%" + toSearch +"%'";
            DbStudent.displayAndSearch(query, dataGridView);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult dialog = MessageBox.Show("Are you sure to delete this student?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    DbStudent.deleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display();
                }
            }
        }
    }
}
