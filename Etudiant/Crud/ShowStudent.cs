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
    public partial class ShowStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, nom, post_nom, prenom, promotion;

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            DbStudent.getImage(id, picImg, "image");
        }

        public byte image;
        public ShowStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void initInfos()
        {
            textNom.Text = nom;
            textPost_nom.Text = post_nom;
            textPrenom.Text = prenom;
            textPromotion.Text = promotion;
        }
    }
}
