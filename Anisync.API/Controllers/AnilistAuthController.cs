using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Anisync.API.Controllers;

[Route("[controller]")]
public class AnilistAuthController : Controller
{
    [HttpGet]
    public IActionResult Get(string code)
    {
        Console.WriteLine(code);
        return Ok();
    }
}
