using System.Diagnostics;
using System.Runtime.CompilerServices;
using CW17_1.DAL;
using CW17_1.Entity;
using CW17_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CW17_1.Controllers
{

	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AppDbContext _dbContext;

		public HomeController(ILogger<HomeController> logger,AppDbContext dbContext)
		{
			_logger = logger;
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			List<User> users=new List<User>();

				 users= _dbContext.Members.Where(m=>m.IsDeleted==false).ToList();


			return View(users);
		}


		public IActionResult Create()
		{
			return View(new User());
		}
		[HttpPost]
		public IActionResult Create(User user)
		{

				_dbContext.Members.Add(user);
				_dbContext.SaveChanges();

			

			return RedirectToAction(nameof(Index));
		}


		public IActionResult CreateAddress(int userid)
		{
			
			return View(new AddAddressViewModel(){UserId = userid});
		}
		[HttpPost]
		public IActionResult CreateAddress(AddAddressViewModel address)
		{
			var entity = new Address(){Description = address.Description,Title = address.Title};
			var result=_dbContext.Addresses.Add(entity);
			//_dbContext.SaveChanges();
			_dbContext.Members.FirstOrDefault(x => x.Id == address.UserId).AddressId = result.Entity.Id;
			_dbContext.SaveChanges();



			return RedirectToAction(nameof(Index));
		}


		public IActionResult Delete(int id)
		{

				//_dbContext.Members.Remove(_dbContext.Members.FirstOrDefault(m => m.Id == id));
				_dbContext.Members.FirstOrDefault(m => m.Id == id).IsDeleted=true;
				_dbContext.SaveChanges();
			
			return RedirectToAction(nameof(Index));
		}



		[HttpPost]
		public IActionResult Edit(User user)
		{
			_dbContext.Members.FirstOrDefault(m => m.Id == user.Id).Name=user.Name;
			_dbContext.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var result=_dbContext.Members.FirstOrDefault(m => m.Id == id);
			return View(result);
		}






		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}