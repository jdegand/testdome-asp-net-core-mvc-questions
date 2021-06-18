using System;
using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    [Route("/users")]
    public IActionResult GetUsers()
    {
      return Content("List of all users.");
    }

    [Route("/users/{userId}")]
    public IActionResult GetUserById(string userId)
    {
      return Content("User with id: " + userId);
    }
}
