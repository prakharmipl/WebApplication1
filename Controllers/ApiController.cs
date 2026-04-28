using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;


[ApiController]
[Route("[controller]/[action]")]
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

    //[Route("/notget")]
    public string Notget()
    {
        return "Hellw from controller3";
    }


    //[HttpGet("books/{id}")]
    public string Getid(int id, int authorId, string num )
    {
        return "Hello book id " + id + "\n" +"AuthorID " + authorId + "\n" + "num " +num;
    }

    [HttpGet("search")]
    public string search(int id, int authorId)
    {
        return "Hello book id " + id + "\n" + "AuthorID " + authorId ;
    }

}
