﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OTOSOLVE.UI.Areas.Ticket.ViewModels;

namespace OTOSOLVE.UI.Areas.Ticket.Controllers;
[Area("Ticket")]
[Authorize(Policy = "TeamLeadPolicy")]
public class TeamLeadController : Controller
{

    public IActionResult Index()
    {
        // Page Titles
        ViewData["pTitle"] = "Dashboard";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Dashboard", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Index", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) }
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
            new BreadcrumbItem { Name = "Dashboard", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "ViewTickets", Url = Url.Action("ViewTickets", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "CreateTicket", Url = Url.Action("CreateTicket", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult AssignTicket() // CTicket
    {
        ViewData["pTitle"] = "Assign Ticket";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "ViewTickets", Url = Url.Action("ViewTickets", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "CreateTicket", Url = Url.Action("AssignTicket", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult EditAssignTicket() // CTicket
    {
        ViewData["pTitle"] = "Edit Assign Ticket";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "ViewTickets", Url = Url.Action("ViewTickets", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "CreateTicket", Url = Url.Action("AssignTicket", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult ViewTickets()
    {
        ViewData["pTitle"] = "View Tickets";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Tickets", Url = Url.Action("CreateTicket", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewTickets", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult ViewProcedures()
    {
        ViewData["pTitle"] = "View Procedures";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Procedure", Url = Url.Action("ViewStrategies", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewProcedures", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult ViewStrategies()
    {
        ViewData["pTitle"] = "Strategies Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Strategy", Url = Url.Action("ViewProcedures", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewStrategies", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ViewTeam()
    {
        ViewData["pTitle"] = "Team Structure";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("Index", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "Ticket", Url = Url.Action("CreateTicket", "TeamLead", new { area = "Ticket" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewTeam", "TeamLead", new { area = "Ticket" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

}
