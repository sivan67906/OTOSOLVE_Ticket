using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OTOSOLVE.UI.Areas.Ticket.ViewModels;

namespace OTOSOLVE.UI.Areas.Ticket.Controllers;

[Area("Ticket")]
[Authorize(Policy = "AdministratorTicketPolicy")]
public class AdministratorController : Controller
{
    public IActionResult Index()
    {
        // Page Titles
        ViewData["pTitle"] = "Dashboard";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Admin", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Dashboard", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Index", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;


        // Sample data for the chart
        string[] months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        int[] ticketRequests = new[] { 60, 70, 80, 90, 85, 88, 92, 87, 84, 78, 75, 80 }; // Ticket Requests (%)
        int[] ticketApprovals = new[] { 50, 65, 75, 85, 80, 83, 88, 82, 80, 72, 70, 76 }; // Ticket Approvals (%)

        // Pass data to the view using ViewBag
        ViewBag.Months = months;
        ViewBag.TicketRequests = ticketRequests;
        ViewBag.TicketApprovals = ticketApprovals;

        return View();
    }

    public IActionResult CreateTicket() // CTicket
    {
        ViewData["pTitle"] = "Create Ticket";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "ViewTickets", Url = Url.Action("ViewTickets", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "CreateTicket", Url = Url.Action("CreateTicket", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult ViewTickets()
    {
        ViewData["pTitle"] = "View Tickets";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Tickets", Url = Url.Action("CreateTicket", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewTickets", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult CreateProcedure()
    {
        ViewData["pTitle"] = "Create Procedure";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("CreateTicket", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create Procedure", Url = Url.Action("CreateProcedure", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }

    public IActionResult EditProcedures()
    {
        ViewData["pTitle"] = "Edit Procedure";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create Procedure", Url = Url.Action("CreateProcedure", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewProcedures", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ViewProcedures()
    {
        ViewData["pTitle"] = "View Procedures";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create Procedure", Url = Url.Action("CreateProcedure", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewProcedures", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }


    public IActionResult CreateStrategy()
    {
        ViewData["pTitle"] = "Create Strategy";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Strategies", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("CreateStrategy", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }

    public IActionResult ViewStrategies()
    {
        ViewData["pTitle"] = "Strategies Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Strategy", Url = Url.Action("CreateStrategy", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult EditStrategies()
    {
        ViewData["pTitle"] = "Strategies Detail";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Strategy", Url = Url.Action("CreateStrategy", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult CreateTeam()
    {
        ViewData["pTitle"] = "Team";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Team", Url = Url.Action("CreateTeamMember", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult CreateTeamMember()
    {
        ViewData["pTitle"] = "Team";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create Team", Url = Url.Action("CreateTeam", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ViewTeam()
    {
        ViewData["pTitle"] = "Team";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Team", Url = Url.Action("CreateTeamMember", "Administrator", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "Administrator", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}
