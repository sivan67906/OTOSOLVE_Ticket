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