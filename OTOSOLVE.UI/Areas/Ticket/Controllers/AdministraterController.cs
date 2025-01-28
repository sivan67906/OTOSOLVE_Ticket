using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OTOSOLVE.UI.Areas.Ticket.ViewModels;

namespace OTOSOLVE.UI.Areas.Ticket.Controllers;
[Area("Ticket")]
[Authorize(Policy = "AdminPolicy")]
public class AdministraterController : Controller
{
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
            new BreadcrumbItem { Name = "Admin", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
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
    public IActionResult TCreate()
    {
        ViewData["pTitle"] = "Ticket Create Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Management", Url = Url.Action("TPView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("TProcess", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult TProcess()
    {
        ViewData["pTitle"] = "Ticket Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Process", Url = Url.Action("TPView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("TProcess", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult TPCreate()
    {
        ViewData["pTitle"] = "Ticket Process Creation";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Process", Url = Url.Action("TPView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("TPCreate", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }
    public IActionResult TMWorkFlowRule()
    {
        ViewData["pTitle"] = "WorkFlow Rule Creation";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "WorkFlow Rule", Url = Url.Action("WFView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("TMWorkFlowRule", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;
        return View();
    }
    public IActionResult TPView()
    {
        ViewData["pTitle"] = "Ticket Process Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Process", Url = Url.Action("TPCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("TPView", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult WFView()
    {
        ViewData["pTitle"] = "WorkFlow Rule Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "WorkFlow", Url = Url.Action("TMWorkFlowRule", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("WFView", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult TicketView()
    {
        ViewData["pTitle"] = "Tickets Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("TCreate", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "List", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("TicketView", "Ticket", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}
