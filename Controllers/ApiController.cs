using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;


[ApiController]
[Route("test/[action]")]
public class ApiController: ControllerBase
{
    //[Route("/get")]
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
        return "Hellw from controller2";
    }
}
