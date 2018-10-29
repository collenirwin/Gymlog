/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Gymlog.Models;
using Microsoft.Extensions.Configuration;

namespace Gymlog.Exercise
{
    public class ExerciseData
    {
        private IConfiguration configuration;

        public ExerciseData(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int AddUser(WorkoutFormModel exercise)
        {
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "Insert into [dbo].[sets]([set], [reps], [rest_time], [comments]) VALUES(@setP, @repsP, @rest_timeP, @commentsP)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@setP", exercise.Set);
            cmd.Parameters.AddWithValue("@repsP", exercise.Reps);
            cmd.Parameters.AddWithValue("@rest_timeP", "Fixed");
            cmd.Parameters.AddWithValue("@commentsP", "something");

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int uID = Convert.ToInt32(reader[0].ToString());

            conn.Close();

            return uID;
        }
    }
}
*/