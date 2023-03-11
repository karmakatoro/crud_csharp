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
            string query = "SELECT id,nom,post_nom,prenom,promotion FROM t_student";
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
            string query = "SELECT id,nom,post_nom,prenom,promotion FROM t_student WHERE nom LIKE'%" + toSearch +"%' OR post_nom LIKE'%"+ toSearch+"%' OR prenom LIKE'%"+toSearch+"%'";
            DbStudent.displayAndSearch(query, dataGridView);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {

            }
            if(e.ColumnIndex == 1)
            {
                form.clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nom = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.post_nom = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.prenom = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.promotion = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.updateInfos();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string studid = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string studname = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string studpost_name = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
                DialogResult dialog = MessageBox.Show("Are you sure to delete "+studname+" "+studpost_name+"?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dialog == DialogResult.Yes)
                {
                    DbStudent.deleteStudent(studname, studid);
                    display();
                }
            }
        }
    }
}
