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
        string id, name, reg, @class, section;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfos()
        {
            labelAddStudent.Text = "Update Student";
            btnSave.Name = "btnUpdate";
            textName.Text = name;
            textReg.Text = reg;
            textClass.Text = @class;
            textSection.Text = section;
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
            if(name == "" || reg == "" || @class == "" || section == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if (name.Length < 3)
                {
                    MessageBox.Show("Too short name");
                }
                else
                {
                    if (reg.Length < 1)
                    {
                        MessageBox.Show("Too short reg");
                    }
                    else
                    {
                        if(btnSave.Name == "btnSave")
                        {
                            Student student = new Student(name, reg, @class, section);
                            DbStudent.addStudent(student);
                            clear();
                            _parent.display();
                        }
                        if(btnSave.Name == "btnUpdate")
                        {

                            Student student = new Student(name, reg, @class, section);
                            DbStudent.updateStudent(student, id);
                        }
                       
                    }
                }
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
