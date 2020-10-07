using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eTicaret.Business.Abstract;
using eTicaret.WebUI.Models;
using System.Net.Mail;
using System.Net;

namespace eTicaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(new ProductListModel() {
                Products = _productService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(string subject,string name,string email,string message)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("bitirmeemailonayiicin@gmail.com", "321654987Abc.");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("bitirmeemailonayiicin@gmail.com", "E Ticaret");
            mail.To.Add("bitirmeemailonayiicin@gmail.com");
            mail.Subject = $"{subject} - {name} - {email}"; mail.IsBodyHtml = true; mail.Body = message;
            sc.Send(mail);
            return View();
        }
    }
}