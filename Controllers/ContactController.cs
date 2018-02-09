using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("/contact")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpPost("/contact")]
        public ActionResult Create()
        {
            string name = Request.Form["name"];
            string phone = Request.Form["phone"];
            string address = Request.Form["address"];
            Contact newContact = new Contact(name, phone, address);
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult NewContactForm()
        {
            return View();
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult Details(int id)
        {
            Contact chosenContact = Contact.FindById(id);
            return View(chosenContact);
        }

        [HttpPost("/contacts/clear")]
        public ActionResult Clear()
        {
            Contact.ClearAllContacts();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }
    }
}
