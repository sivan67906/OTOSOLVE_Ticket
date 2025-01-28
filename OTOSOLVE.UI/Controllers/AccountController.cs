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


        if ((loginModel.Email.ToString() == "admin@gmail.com") && (loginModel.Password == "admin@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Admin1"),
        new Claim(ClaimTypes.Role, "Admin"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "Administrater", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "teamlead@gmail.com") && (loginModel.Password == "teamlead@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "TeamLeadUser1"),
        new Claim(ClaimTypes.Role, "TeamLead"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "TeamLead", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "support@gmail.com") && (loginModel.Password == "support@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "SupportUser1"),
        new Claim(ClaimTypes.Role, "SupportTeam"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "SupportTeam", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "hr@gmail.com") && (loginModel.Password == "hr@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "HRUser1"),
        new Claim(ClaimTypes.Role, "HR"),
    };
            var identity = new ClaimsIdentity(claims, "AvivClaimCookie");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("AvivClaimCookie", claimsPrincipal);

            return RedirectToAction("Dashboard", "HumanResource", new { area = "Ticket" });
        }

        else if ((loginModel.Email.ToString() == "employee@gmail.com") && (loginModel.Password == "employee@123"))
        {
            // Creating Security Context
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "EmployeeUser1"),
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

        return RedirectToAction("Index", "Home");
    }
}
