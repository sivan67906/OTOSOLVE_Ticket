using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OTOSOLVE.UI.Areas.Ticket.ViewModels;

namespace OTOSOLVE.UI.Areas.Ticket.Controllers;
[Area("Ticket")]
[Authorize(Policy = "TeamLeadPolicy")]
public class TeamLeadController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Dashboard()
    {
        // Page Titles
        ViewData["pTitle"] = "Dashboard";

        //// Breadcrumb
        //ViewData["bGParent"] = "Admin";
        //ViewData["bParent"] = "Dashboard";
        //ViewData["bChild"] = "Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Admin", Url = Url.Action("TicketViewTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Dashboard", Url = Url.Action("Dashboard", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Index", Url = Url.Action("Dashboard", "Ticket", new { area = "Ticket" }) }
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
    public IActionResult CreateTicketTL()
    {
        ViewData["pTitle"] = "Ticket Process Creation";
        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TicketViewTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Process", Url = Url.Action("ProcessViewTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("CreateTicketTL", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }
    public IActionResult ProcessViewTL()
    {
        ViewData["pTitle"] = "Ticket Process Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Process", Url = Url.Action("CreateTicketTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ProcessViewTL", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }
    public IActionResult WorkFlowTL()
    {
        ViewData["pTitle"] = "WorkFlow Rule Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "WorkFlow", Url = Url.Action("WorkFlowTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("WFView", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }
    public IActionResult TicketViewTLTL()
    {
        ViewData["pTitle"] = "Tickets Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "List", Url = Url.Action("TicketViewTL", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("TicketViewTL", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }

}
