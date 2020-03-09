using System;
using System.Data.SqlClient;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-242JGDJ\HUMBERBRIDGING;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            using (connection)
            {
                connection.Open();
                string query = "select * from Applicant_Educations";
                SqlCommand cmd = new SqlCommand();
                Console.WriteLine("Connected");
                cmd.Connection = connection;
                cmd.CommandText = query;

              /*  ApplicantEducation[] applicantEducations =
                    new ApplicantEducation[1000];
                int index = 0;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ApplicantEducation edu = new ApplicantEducation();
                    edu.Id = (Guid)reader["Id"];
                    edu.Applicant = (Guid)reader["Applicant"];
                    edu.Major = (string)reader["Major"];
                    edu.StartDate = (DateTime)reader["Start_Date"];

                    applicantEducations[index] = edu;
                    index++;
                }*/

            }
        }
    }
}
