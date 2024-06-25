using CRUD.ADO.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CRUD.ADO.NET.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CategoriesController : ControllerBase
	{
		private static string connectionString = "koneksi_database";

		[HttpPost("Insert")]
		public IActionResult Insert([FromBody] Categories categories)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = @$"
									INSERT INTO Categories
									(
										 CategoryID
										,CategoryName
										,Description
										,Picture
									) 
									values 
									(
										 @CategoryID
										,@CategoryName
										,@Description
										,@Picture
									)
								";
					using (SqlCommand command = new SqlCommand
						(query, connection))
					{
						command.Parameters.AddWithValue("@CategoryID", categories.CategoryID);
						command.Parameters.AddWithValue("@CategoryName", categories.CategoryName);
						command.Parameters.AddWithValue("@Description", categories.Description);
						command.Parameters.AddWithValue("@Picture", categories.Picture);
						command.ExecuteNonQuery();

					}
					connection.Close();
					connection.Dispose();
				};

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpGet("GetRows")]
		public IActionResult GetRows()
		{
			try
			{
				List<Categories> categoriesList = new List<Categories>();
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = @$"
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

		[HttpPut("UpdateByID")]
		public IActionResult UpdateById([FromBody] Categories categories)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = @$"
										UPDATE Categories
										SET Description = @Description
										WHERE CategoryID = @CategoryID
									";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Description", categories.Description);
						command.Parameters.AddWithValue("@CategoryID", categories.CategoryID);
						command.ExecuteNonQuery();
					}
					connection.Close();
					connection.Dispose();

					return Ok();

				}
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}
		[HttpDelete("DeleteByID")]
		public IActionResult DeleteById(int id)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string query = @$"
										DELETE FROM Categories
										WHERE CategoryID = @CategoryID
									";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@CategoryID", id);
						command.ExecuteNonQuery();
					}

					return Ok();
				}
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


	}
}
