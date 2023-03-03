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
        FormStudent form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
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
            form.clear();
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
                form.clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.reg = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.@class = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.section = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.updateInfos();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult dialog = MessageBox.Show("Are you sure to delete this student?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    string studid = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string studname = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
                    DbStudent.deleteStudent(studname, studid);
                    display();
                }
            }
        }
    }
}
