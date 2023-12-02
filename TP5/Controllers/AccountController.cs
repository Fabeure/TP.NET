using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity;


namespace TPIdentity.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    // 
    // GET: /Account/All
    public AccountController(UserManager<IdentityUser> _userManager){
        this._userManager = _userManager;
    }

    public IActionResult Index(){
        var users = _userManager.Users;
        return View(users);
    }
}