using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASTNETAssignment.Models;

namespace ASTNETAssignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //Domain/Nashtech/Home/......(vd: MalePerson)
    public List<Person> MalePerson()
    {

        return GetMalePerson(GetList());
        return GetFullNamePerson(GetList());
    }
    public List<Person> FullName()
    {

        return GetFullNamePerson(GetList());
    }
    public List<Person> Over2000()
    {

        return GetPersonOver2000(GetList());
    }
    public List<Person> Is2000()
    {

        return GetPersonIs2000(GetList());
    }
    public List<Person> Under2000()
    {

        return GetPersonUnder2000(GetList());
    }
    public List<Person> BornHN()
    {

        return GetPersonBornInHN(GetList());
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
       public FileResult DownloadFile(){
        return File("Assets/Person.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Person.xlsx");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
