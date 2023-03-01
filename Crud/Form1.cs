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
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void clear()
        {
            textName.Text = textReg.Text = textClass.Text = textSection.Text = string.Empty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string reg = textReg.Text.Trim();
            string @class = textClass.Text.Trim();
            string section = textSection.Text.Trim();
            if (name.Length < 3)
            {
                MessageBox.Show("Too short name");
            }
            if (reg.Length < 1)
            {
                MessageBox.Show("Too short reg");
            }
            if (@class.Length == 0)
            {
                MessageBox.Show("Invalid class");
            }
            if (section.Length == 0)
            {
                MessageBox.Show("Invalid section");
            }
            Student student = new Student(name,reg,@class,section);
            DbStudent.addStudent(student);
            clear();
            _parent.display();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
