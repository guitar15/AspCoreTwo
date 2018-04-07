using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NamespaceName
{
  public class UserController : Controller
  {

    public IActionResult Index()
    {
      
      return View();
    }
  }
}