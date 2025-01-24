using Microsoft.AspNetCore.Mvc;

namespace OTOSOLVE.UI.Areas.Ticket.Controllers;
[Area("Ticket")]
public class TicketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Dashboard()
    {
        // Page Titles
        ViewData["pTitle"] = "Dashboard";

        // Breadcrumb
        ViewData["bGParent"] = "Admin";
        ViewData["bParent"] = "Dashboard";
        ViewData["bChild"] = "Index";

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

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "Management";
        ViewData["bChild"] = "Create";

        return View();
    }

    public IActionResult TProcess()
    {
        ViewData["pTitle"] = "Ticket Index";

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "Process";
        ViewData["bChild"] = "View";

        return View();
    }

    public IActionResult TPCreate()
    {
        ViewData["pTitle"] = "Ticket Process Creation";

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "Process";
        ViewData["bChild"] = "Create";
        return View();
    }
    public IActionResult TMWorkFlowRule()
    {
        ViewData["pTitle"] = "WorkFlow Rule Creation";

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "WorkFlow Rule";
        ViewData["bChild"] = "Create";
        return View();
    }
    public IActionResult TPView()
    {
        ViewData["pTitle"] = "Ticket Process Index";

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "Process";
        ViewData["bChild"] = "View";

        return View();
    }
    public IActionResult WFView()
    {
        ViewData["pTitle"] = "WorkFlow Rule Index";

        // Breadcrumb
        ViewData["bGParent"] = "Ticket";
        ViewData["bParent"] = "WorkFlow";
        ViewData["bChild"] = "View";

        return View();
    }
}