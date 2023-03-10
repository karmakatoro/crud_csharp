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
        public string id, nom, post_nom, prenom, promotion;
        public byte image;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfos()
        {
            labelAddStudent.Text = "Update Student";
            btnSave.Name = "btnUpdate";
            textNom.Text = nom;
            textPost_nom.Text = post_nom;
            textPrenom.Text = prenom;
            textPromotion.Text = promotion;

        }
        public void clear()
        {
            textNom.Text = textPost_nom.Text = textPrenom.Text = textPromotion.Text = string.Empty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textNom.Text.Trim();
            string reg = textPost_nom.Text.Trim();
            string @class = textPrenom.Text.Trim();
            string section = textPromotion.Text.Trim();
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
                            Student student = new Student(nom, post_nom, prenom, promotion, image);
                            DbStudent.addStudent(student);
                            clear();
                            _parent.display();
                        }
                        if(btnSave.Name == "btnUpdate")
                        {

                            Student student = new Student(nom, post_nom, prenom, promotion, image);
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
