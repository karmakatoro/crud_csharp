namespace Crud
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.PictureBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.labelAddStudent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnErase = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.textPromotion = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textPost_nom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnErase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnQR);
            this.panel1.Controls.Add(this.picQR);
            this.panel1.Controls.Add(this.labelAddStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 115);
            this.panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = global::Crud.Properties.Resources.icons8_print_64;
            this.btnPrint.Location = new System.Drawing.Point(276, 62);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(39, 34);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 13;
            this.btnPrint.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQR.Image = global::Crud.Properties.Resources.icons8_qr_code_64;
            this.btnQR.Location = new System.Drawing.Point(277, 12);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(39, 34);
            this.btnQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQR.TabIndex = 12;
            this.btnQR.TabStop = false;
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(322, 12);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(84, 84);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 12;
            this.picQR.TabStop = false;
            this.picQR.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelAddStudent
            // 
            this.labelAddStudent.AutoSize = true;
            this.labelAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStudent.ForeColor = System.Drawing.Color.White;
            this.labelAddStudent.Location = new System.Drawing.Point(30, 40);
            this.labelAddStudent.Name = "labelAddStudent";
            this.labelAddStudent.Size = new System.Drawing.Size(103, 21);
            this.labelAddStudent.TabIndex = 1;
            this.labelAddStudent.Text = "Add Student";
            this.labelAddStudent.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddImg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picImg);
            this.panel2.Controls.Add(this.btnErase);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.textPromotion);
            this.panel2.Controls.Add(this.textPrenom);
            this.panel2.Controls.Add(this.textPost_nom);
            this.panel2.Controls.Add(this.textNom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(34, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 221);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddImg
            // 
            this.btnAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImg.Image = global::Crud.Properties.Resources.icons8_image_file_add_64;
            this.btnAddImg.Location = new System.Drawing.Point(229, 163);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(39, 34);
            this.btnAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddImg.TabIndex = 11;
            this.btnAddImg.TabStop = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image";
            // 
            // picImg
            // 
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Location = new System.Drawing.Point(229, 36);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(129, 114);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImg.TabIndex = 8;
            this.picImg.TabStop = false;
            // 
            // btnErase
            // 
            this.btnErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErase.Image = global::Crud.Properties.Resources.erase_60px;
            this.btnErase.Location = new System.Drawing.Point(274, 163);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(39, 34);
            this.btnErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnErase.TabIndex = 7;
            this.btnErase.TabStop = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::Crud.Properties.Resources.save_48px;
            this.btnSave.Location = new System.Drawing.Point(319, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 34);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textPromotion
            // 
            this.textPromotion.Location = new System.Drawing.Point(20, 177);
            this.textPromotion.Name = "textPromotion";
            this.textPromotion.Size = new System.Drawing.Size(201, 20);
            this.textPromotion.TabIndex = 3;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(20, 130);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(201, 20);
            this.textPrenom.TabIndex = 3;
            // 
            // textPost_nom
            // 
            this.textPost_nom.Location = new System.Drawing.Point(20, 83);
            this.textPost_nom.Name = "textPost_nom";
            this.textPost_nom.Size = new System.Drawing.Size(201, 20);
            this.textPost_nom.TabIndex = 3;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(20, 36);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(201, 20);
            this.textNom.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Promotion";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prenom";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Post-nom";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnErase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPromotion;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textPost_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnErase;
        private System.Windows.Forms.PictureBox btnAddImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.PictureBox btnQR;
    }
}