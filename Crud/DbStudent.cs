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
            string query = "Server=localhost;Database=t_crud;Uid=root;Pwd=;";
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
            string query = "INSERT INTO t_student VALUES (NULL,@name,@reg, @class, @section, NULL)";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = student.name;
            cmd.Parameters.Add("@reg", MySqlDbType.VarChar).Value = student.reg;
            cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = student.@class;
            cmd.Parameters.Add("@section", MySqlDbType.VarChar).Value = student.section;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(student.name+" added successfully","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not inserted!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void updateStudent(Student student, string id)
        {
            string query = "UPDATE t_student SET name = @name,reg = @reg, class = @class, section = @section WHERE id= @id";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = student.name;
            cmd.Parameters.Add("@reg", MySqlDbType.VarChar).Value = student.reg;
            cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = student.@class;
            cmd.Parameters.Add("@section", MySqlDbType.VarChar).Value = student.section;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(student.name + " updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not updated!!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
