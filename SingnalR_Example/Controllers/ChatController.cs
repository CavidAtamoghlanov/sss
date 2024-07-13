
using Microsoft.AspNetCore.Mvc;

namespace SingnalR_Example.Controllers;

public class ChatController : Controller
{
    public IActionResult AddUserToHub()
    {
        return View();
    }

    public IActionResult SendMessageToAllUserpage()
    {
        return View();
    }
}
