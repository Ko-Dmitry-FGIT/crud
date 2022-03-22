using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace crud
{
    class DataProvider
    {
        public SqlConnection Connection
        {
            get; set;
        }
        public DataProvider()
        {
            Connection = new SqlConnection("Data Source = COMPUTER; Initial Catalog = crud; user id = sa; password = sa");
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Execute(string strCmd)
        {
            SqlCommand cmd = new SqlCommand(strCmd);
            cmd.ExecuteNonQuery();
        }
        public List<Actor> GetActorList()
        {
            List<Actor> ActorList;

            SqlCommand cmd = new SqlCommand("select * from Actor", Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            ActorList = new List<Actor>();
            while (reader.Read())
            {
                var actor = new Actor()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    Sex = (string)reader["sex"],
                    Birthdate = (int)reader["birthdate"],
                };
                ActorList.Add(actor);
            }
            reader.Close();
            return ActorList;
        }
        public List<Roles> GetRolesList()
        {
            List<Roles> RolesList;

            SqlCommand cmd = new SqlCommand("select * from Roles", Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            RolesList = new List<Roles>();
            while (reader.Read())
            {
                var roles = new Roles()
                {
                    Id_actor = (int)reader["Id_actor"],
                    Id_movie = (int)reader["Id_movie"],
                    Name = (string)reader["name"],
                };
                RolesList.Add(roles);
            }
            reader.Close();
            return RolesList;
        }
        public List<Movie> GetMovieList()
        {
            List<Movie> MovieList;

            SqlCommand cmd = new SqlCommand("select * from Movie", Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            MovieList = new List<Movie>();
            while (reader.Read())
            {
                var movie = new Movie()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                };
                MovieList.Add(movie);
            }
            reader.Close();
            return MovieList;
        }
        public string GetActorById(int actor_id)
        {
            SqlCommand cmd = new SqlCommand(String.Format("select name from Actor where id = {0}", actor_id), Connection);
            return (string)cmd.ExecuteScalar();
        }
        public string GetMovieById(int actor_id)
        {
            SqlCommand cmd = new SqlCommand(String.Format("select name from Movie where id = {0}", actor_id), Connection);
            return (string)cmd.ExecuteScalar();
        }
        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
