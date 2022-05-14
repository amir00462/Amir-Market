using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AmirMarket.Entities;

namespace AmirMarket.DAL
{
    public class ProductDao

    {

        public List<Product> GetAllProducts()
        {

            string sqlConnectionString = "Data Source=FARADARS;Initial Catalog=model;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(sqlConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand("SELECT Id, name, price, teacher FROM Product", con))
                {

                    List<Product> products = new List<Product>();

                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        while (sdr.Read())
                        {

                            products.Add(new Product
                            {

                                id = Convert.ToInt32(sdr["Id"]),
                                name = sdr["name"].ToString(),
                                price = sdr["price"].ToString(),
                                teacher = sdr["teacher"].ToString()

                            });

                        }
                    }
                    con.Close();

                    return products;
                }
            }
        }

        public void AddToDatabase(Product product)
        {

            // connect to database
            string sqlConnectionString = "Data Source=FARADARS;Initial Catalog=model;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            // my query
            string query = "INSERT INTO Product (name, price, teacher)";
            query += " VALUES (@name, @price, @teacher)";

            // create command
            SqlCommand myCommand = new SqlCommand(query, sqlConnection);
            myCommand.Parameters.AddWithValue("@name", product.name);
            myCommand.Parameters.AddWithValue("@price", product.price);
            myCommand.Parameters.AddWithValue("@teacher", product.teacher);

            // run command
            myCommand.ExecuteNonQuery();

            // close database
            sqlConnection.Close();

        }

        public void RemoveFromDatabase(string name)
        {

            // connect to database
            string sqlConnectionString = "Data Source=FARADARS;Initial Catalog=model;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            // my query
            string query = "DELETE FROM Product WHERE name = @name";

            // create command
            SqlCommand myCommand = new SqlCommand(query, sqlConnection);
            myCommand.Parameters.AddWithValue("@name", name);

            // run command
            myCommand.ExecuteNonQuery();

            // close database
            sqlConnection.Close();

        }

    }
}
