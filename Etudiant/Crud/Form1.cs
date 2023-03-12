using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crud
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, nom, post_nom, prenom, promotion;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public byte[] imgProcess()
        {
            MemoryStream memorystream = new MemoryStream();
            picImg.Image.Save(memorystream,picImg.Image.RawFormat);
            byte[] img = memorystream.ToArray();
            return img;
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

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if(openfiledialog.ShowDialog()== DialogResult.OK)
            {
                picImg.Image = Image.FromFile(openfiledialog.FileName);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            if (btnSave.Name == "btnUpdate")
            {
                DbStudent.getImage(id, picImg, "image");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text.Trim();
            string post_nom = textPost_nom.Text.Trim();
            string prenom = textPrenom.Text.Trim();
            string promotion = textPromotion.Text.Trim();
            byte[] image = imgProcess();
            if(nom == "" || post_nom == "" || prenom == "" || promotion == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
  
                if(btnSave.Name == "btnSave")
                {
                    Student student = new Student(nom, post_nom, prenom, promotion);
                    DbStudent.addStudent(student, image);
                    clear();
                    _parent.display();
                }
                if(btnSave.Name == "btnUpdate")
                {
                    Student student = new Student(nom, post_nom, prenom, promotion);
                    DbStudent.updateStudent(student, id, image); 
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
