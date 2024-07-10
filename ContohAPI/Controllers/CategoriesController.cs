using ContohAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace ContohAPI.Controllers
{
    public class CategoriesController : Controller
    {
        private static string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=true;";

        [HttpGet("MendapatkanData")]
        public IActionResult GetData()
        {
            try
            {
                    List<Categories> categoriesList = new List<Categories>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"
                                         SELECT * FROM Categories
                                    ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                            
                                Categories category = new Categories();
                                category.CategoryID = reader.GetInt32(0);
                                category.CategoryName = reader.GetString(1);
                                category.Description = reader.GetString(2);
                                categoriesList.Add(category);
                            }
                        }
                    }
                    connection.Close();
                    connection.Dispose();
                }

                return Ok(categoriesList);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
