using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    class Student
    {
        private string nom;
        private string post_nom;
        private string prenom;
        private string promotion;
        private byte image;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Post_nom
        {
            get
            {
                return post_nom;
            }

            set
            {
                post_nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Promotion
        {
            get
            {
                return promotion;
            }

            set
            {
                promotion = value;
            }
        }

        public byte Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public Student(string nom, string post_nom, string prenom, string promotion, byte image)
        {
            this.nom = nom;
            this.post_nom = post_nom;
            this.prenom = prenom;
            this.promotion = promotion;
            this.image = image;
        }
    }
}
