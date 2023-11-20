using Microsoft.AspNetCore.Mvc;

namespace ForumWars.Controllers
{
    public class SessionController : Controller
    {        
        public void InitAppSession(string username)
        {     
            
        }

        // User        
        public string GetSessionUsername() => HttpContext.Session.GetString("User") ?? "Guest";
    }
}