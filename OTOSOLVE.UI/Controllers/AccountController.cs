using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace OTOSOLVE.UI.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View(new Models.LoginVM());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(Models.LoginVM loginModel)
    {
        if (!ModelState.IsValid) return View(new Models.LoginVM());


        if ((loginModel.Email.ToString() == "admin@oto.com") && (loginModel.Password == "admin@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Firstlin"),
        new Claim(ClaimTypes.Role, "Admin"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "Administrater", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "teamlead@oto.com") && (loginModel.Password == "teamlead@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Sivan"),
        new Claim(ClaimTypes.Role, "TeamLead"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "TeamLead", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "support@oto.com") && (loginModel.Password == "support@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Kansheyam"),
        new Claim(ClaimTypes.Role, "SupportTeam"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "SupportTeam", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "hr@oto.com") && (loginModel.Password == "hr@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "William"),
        new Claim(ClaimTypes.Role, "HR"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "HumanResource", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "employee@oto.com") && (loginModel.Password == "employee@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Robert"),
        new Claim(ClaimTypes.Role, "Employee"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "Employee", new { area = "Ticket" });
        }

        return View();
    }

    public IActionResult AccessDenied()
    {
        return View();
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync("AvivClaimCookie");

        return RedirectToAction("Login", "Account");
    }
}
