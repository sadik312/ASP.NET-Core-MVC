using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Movie.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld/
    public string Index() {
        return "Default action method";
    }

    // GET: /HelloWorld/Welcome/
    public string Welcome() {
        return "Welcome action method";
    }
}