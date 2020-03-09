using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_For_COnnection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-242JGDJ\HUMBERBRIDGING;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            using(connection)
            {
                connection.Open();
                string query = "Select * from Applicant_Educations ";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                ApplicantEducation[] applicant = new ApplicantEducation[1000];
                int index = 0;
                while(reader.Read())
                {
                                        ApplicantEducation edu = new ApplicantEducation();
                    edu.id = (Guid)reader["Id"];//readerreturns object and here it is int
                    edu.Applicat = (Guid)reader["Applicant"];
                    edu.major = (string)reader["Major"];
                    edu.Startdate = (DateTime)reader["Start_Date"];

                    applicant[index] = edu;
                    
                    index++;

                }
                for(int x=0;x<1000;x++)
                {
                    Console.WriteLine(applicant[x]);
                }

            }

        }
    }

    internal class ApplicantEducation
    {
        public Guid id;
        public Guid Applicat;
        public String major;
        public DateTime Startdate;

    }
}
