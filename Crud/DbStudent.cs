using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


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
                MessageBox.Show("MySql connnection!!! \n"+ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
               
            }
            return con;
        }
        public static void addStudent(Student student)
        {
            string query = "INSERT INTO t_student(NULL,@name,@reg, @class, @section, NULL)";

        }
    }
}
