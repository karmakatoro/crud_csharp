﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Crud
{
    class DbStudent
    {
        public static MySqlConnection  getConnection()
        {
            string query = "datasource=localhost;port=3306;username=root;password=;database=db_student";
            MySqlConnection con = new MySqlConnection(query);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql database connnection!!! \n"+ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
               
            }
            return con;
        }
        public static void addStudent(Student student)
        {
            string query = "INSERT INTO t_student (nom,post-nom,prenom,promotion,image) VALUES (@nom,@post_nom,@prenom,@promotion,@image)";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = student.Nom;
            cmd.Parameters.Add("@post_nom", MySqlDbType.VarChar).Value = student.Post_nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = student.Prenom;
            cmd.Parameters.Add("@promotion", MySqlDbType.VarChar).Value = student.Promotion;
            cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = student.Image;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(student.Nom+" added successfully","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not inserted!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void updateStudent(Student student, string id)
        {
            string query = "UPDATE t_student SET nom = @nom,post-nom = @post_nom, prenom = @prenom, promotion = @promotion, image = @image WHERE id= @id";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = student.Nom;
            cmd.Parameters.Add("@post_nom", MySqlDbType.VarChar).Value = student.Post_nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = student.Prenom;
            cmd.Parameters.Add("@promotion", MySqlDbType.VarChar).Value = student.Promotion;
            cmd.Parameters.Add("@image", MySqlDbType.LongBlob).Value = student.Image;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(student.Nom + " updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not updated!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void deleteStudent(string studname,string id)
        {
            string query = "DELETE FROM t_student WHERE id = @id";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(studname+" deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not deleted!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void displayAndSearch(string query, DataGridView dtv)
        {
            try
            {
                MySqlConnection con = getConnection();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter msdp = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                msdp.Fill(table);
                dtv.DataSource = table;
                con.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("An error occured!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
