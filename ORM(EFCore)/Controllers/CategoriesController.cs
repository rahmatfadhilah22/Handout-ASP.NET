using Microsoft.AspNetCore.Mvc;
using ORM_EFCore_.DBContext;
using ORM_EFCore_.Models;

namespace ORM_EFCore_.Controllers
{
	public class CategoriesController : Controller
	{

		private readonly DataContext _context;
		public CategoriesController(DataContext context)
		{
			_context = context;
		}


		[HttpGet("GetRecords")]
		public ActionResult<List<Categories>> GetRecords()
		{
			try
			{
				var result = _context.Categories.ToList();
				return Ok(result);

			}
			catch (Exception ex)
			{ 
				return BadRequest(ex.Message);
			}
		}

		[HttpGet("GetRecord")]
		public ActionResult<Categories> GetRecord(int id)
		{
			try
			{
				var result = _context.Categories.Where(c => c.CategoryID == id);
				if (result == null)
					return NotFound();

				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPost("Insert")]
		public ActionResult<int> Insert([FromBody] Categories category)
		{
			try
			{
				var newCategory = _context.Categories.Add(category);
				int result = _context.SaveChanges();
				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("Update")]
		public ActionResult<int> Update([FromBody] Categories category)
		{
			try
			{
				var Categories = _context.Categories.Find(category.CategoryID);

				Categories.Description = category.Description;
				int result = _context.SaveChanges();
				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("Delete")]
		public ActionResult<int> Delete(int id)
		{
			try
			{
				var Categories = _context.Categories.Find(id);
				_context.Categories.Remove(Categories);
				int result = _context.SaveChanges();

				return Ok(result);


			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

	}
}
