using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class AddressController : Controller
{
    public static List<Address> addresses = new List<Address>();

    [Route("/user/address/create")]
    public IActionResult Index()
    {
      return View("Views/Address/Create.cshtml");
    }

    [Route("/user/address/save")]
    public IActionResult Save(Address a)
    {
      addresses.Add(a);
      return RedirectToAction("Index");
    }
}

public class Address
{
	public string Street { get; set; }

	public string City { get; set; }
}
