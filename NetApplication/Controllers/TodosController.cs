using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NetApplication.Models;

namespace NetApplication.Controllers
{
    public class TodosController : ApiController
    {
		Todos[] todos = new Todos[]
		{
			new Todos { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
			new Todos { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
			new Todos { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
		};

		public IEnumerable<Todos> GetAllProducts()
		{
			return todos;
		}

		public IHttpActionResult GetProduct(int id)
		{
			var product = todos.FirstOrDefault((p) => p.Id == id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}
	}
}
