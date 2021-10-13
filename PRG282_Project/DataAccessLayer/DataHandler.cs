using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project.DataAccessLayer
{
    class DataHandler
    {
        string con = "server=. ;Initial Catalog= BCDatabase; Integrated Security=SSPI";
        public DataHandler() { }

        public void DeleteStudent(int student_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", student_number);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateStudent(int student_number, string student_name, DateTime student_dob, string student_gender,
                          string student_phone, string student_address)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", student_number);
                cmd.Parameters.AddWithValue("@Name", student_name);
                cmd.Parameters.AddWithValue("@DOB", student_dob);
                cmd.Parameters.AddWithValue("@Gender", student_gender);
                cmd.Parameters.AddWithValue("@Phone", student_phone);
                cmd.Parameters.AddWithValue("@Address", student_address);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddStudent(int student_number, string student_name, DateTime student_dob, string student_gender,
                           string student_phone, string student_address)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", student_number);
                cmd.Parameters.AddWithValue("@student_name", student_name);
                cmd.Parameters.AddWithValue("@student_dob", student_dob);
                cmd.Parameters.AddWithValue("@student_gender", student_gender);
                cmd.Parameters.AddWithValue("@student_phone", student_phone);
                cmd.Parameters.AddWithValue("@student_address", student_address);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AddModule(string module_code, string module_name, string module_description, string module_resources)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spAddModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@module_code", module_code);
                cmd.Parameters.AddWithValue("@module_name", module_name);
                cmd.Parameters.AddWithValue("@module_description", module_description);
                cmd.Parameters.AddWithValue("@module_resources", module_resources);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AssignStudentModule(string module_code, int student_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spAssignStudentModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@module_code", module_code);
                cmd.Parameters.AddWithValue("@module_name", student_number);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
