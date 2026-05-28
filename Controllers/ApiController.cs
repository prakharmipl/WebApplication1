using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;


[ApiController]
[Route("[controller]")]
public class ApiController: ControllerBase
{
    //[Route("gett")]
    //[Route("get-all")]
    public string Get()
    {
        return "Hellw from controller";
    }

    //[Route("/get2")]

    public string Get2()
    {
        return "Hellw from controller2";
    }

    [Route("notget")]
    public string Notget()
    {
        return "Hellw from controller3";
    }

    //by default id is string
    [HttpGet("books/{id:alpha}")]
    public string Getid(int id, int authorId, string num )
    {
        return "Hello book id " + id + "\n" +"AuthorID " + authorId + "\n" + "num " +num;
    }

    [HttpGet("search")]
    public string search(int id, int authorId)
    {
        return "Hello book id " + id + "\n" + "AuthorID " + authorId ;
    }

    [HttpGet("customSearch")]
    public IActionResult customSearch( string countries)
    {
        return Ok(countries);
    }

    [HttpPost("CountrySearch")]
    public IActionResult customSearch(CountryModel countries)
    {
        return Ok(countries);
    }



}
