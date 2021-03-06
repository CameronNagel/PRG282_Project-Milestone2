using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282_Project.DataAccessLayer
{
    class DataHandler
    {
        string con = "server= (local) ;Initial Catalog= BCDatabase; Integrated Security=SSPI";
        public DataHandler() { }

        public DataTable DisplayStudents()
        {
            SqlConnection connect = new SqlConnection(con);
            SqlDataAdapter adapt = new SqlDataAdapter("spGetStudent", connect);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;

        }

        public DataTable DisplayModules()
        {
            SqlConnection connect = new SqlConnection(con);
            SqlDataAdapter adapt = new SqlDataAdapter("spGetModules", connect);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;

        }

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

        public void DeleteModule(int module_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modcode", module_number);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(int student_number, string student_name, DateTime student_dob, string student_gender,
                          string student_phone, string student_city, string student_province, string student_street)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                //student_city, student_province and student_street
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", student_number);
                cmd.Parameters.AddWithValue("@Name", student_name);
                cmd.Parameters.AddWithValue("@DOB", student_dob);
                cmd.Parameters.AddWithValue("@Gender", student_gender);
                cmd.Parameters.AddWithValue("@Phone", student_phone);
                cmd.Parameters.AddWithValue("@City", student_city);
                cmd.Parameters.AddWithValue("Province", student_province);
                cmd.Parameters.AddWithValue("@Street", student_street);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateModule(int module_number, string module_name,string mod_desc, string mod_resources)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", module_number);
                cmd.Parameters.AddWithValue("@modname", module_name);
                cmd.Parameters.AddWithValue("@moddesc", mod_desc);
                cmd.Parameters.AddWithValue("@modresources", mod_resources);

                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddStudent(int student_number, string student_name, DateTime student_dob, string student_gender,
                           string student_phone, string student_city, string student_province, string student_street)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertStudent", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@number", student_number);
                    cmd.Parameters.AddWithValue("@Name", student_name);
                    cmd.Parameters.AddWithValue("@Image", "");
                    cmd.Parameters.AddWithValue("@DOB", student_dob);
                    cmd.Parameters.AddWithValue("@Gender", student_gender);
                    cmd.Parameters.AddWithValue("@Phone", student_phone);
                    cmd.Parameters.AddWithValue("@City", student_city);
                    cmd.Parameters.AddWithValue("Province", student_province);
                    cmd.Parameters.AddWithValue("@Street", student_street);

                    MessageBox.Show("Student has been stored");

                    connect.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Student was not stored");
                }
            }
        }
        public void AddModule(string module_code, string module_name, string module_description, string module_resources)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spInsertModule", connect);
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
                SqlCommand cmd = new SqlCommand("spStudentModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modcode", module_code);
                cmd.Parameters.AddWithValue("@studentnum", student_number);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchStudent(int student_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudent", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stunum", student_number);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public DataTable SearchModule(int student_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearcModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stunum", student_number);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public void StudentsInModule(string module_code)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spStudentsInModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@modcode", module_code);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AllModulesOfSudent(int student_number)
        {
            using (SqlConnection connect = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spStudentsInModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stunum ", student_number);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
