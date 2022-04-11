using System;
using System.Data.SqlClient;
using DemoMsSql;

namespace DemoMsSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft SQL Server:");
            Console.WriteLine(new string('-', 25));
            SqlConnection dbConn = new SqlConnection
                (
                "Server=.;Database=master;Integrated Security=true"
                );
            dbConn.Open();
            using (dbConn)
            {
                SqlCommand cmd1 = new SqlCommand
                    ("CREATE DATABASE MinionsOne", dbConn);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("USE MinionsOne", dbConn);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand
                    (
                    "INSERT INTO minions(id, name, age) VALUES ('1', 'Kevin', '15');" +
                    "INSERT INTO minions(id, name, age) VALUES ('2', 'Bob', '22');" +
                    "INSERT INTO minions(id, name, age) VALUES ('3', 'Steward', '42');", dbConn
                    );
                cmd4.ExecuteNonQuery();
                SqlCommand cmd5 = new SqlCommand("SELECT name,age FROM minions;", dbConn);
                SqlDataReader reader = cmd5.ExecuteReader();
                while(reader.Read())
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
            }
        }
    }
}
