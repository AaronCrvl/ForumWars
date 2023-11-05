using ForumWars.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ForumWars.Controllers
{
    public class SessionController : Controller
    {
        public void InitAppSession(string username)
        {            
            HttpContext.Session.SetString("User", username);
        } 

        // User        
        public string GetSessionUsername() => return HttpContext.Session.GetString("User");                    
    }
}