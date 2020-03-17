using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using Task_Try_Out_Forum.Models;

namespace Task_Try_Out_Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDBContext _AppDbContext;
        public IConfiguration Configuration;

        public HomeController(ILogger<HomeController> logger, AppDBContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
            Configuration = configuration;
        }
        public IActionResult Index(string search,string sort)
        {
            Console.WriteLine(sort);
            Console.WriteLine(search);
            if(!String.IsNullOrEmpty(search) || !String.IsNullOrWhiteSpace(search))
            {
                Console.WriteLine("oke");
                if(sort=="By DateTime")
                {
                    var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) select i).OrderBy(x=>x.CreatedAt);
                    ViewBag.threads = threads;

                }else if(sort=="By Title")
                {
                    var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) select i).OrderBy(x=>x.Title);
                    ViewBag.threads = threads;

                }else if(sort=="Status")
                {
                    var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) select i).OrderBy(x=>x.Status);
                    ViewBag.threads = threads;

                }
            }
            else
            {
                if(sort=="By Title")
                {
                    var threads1 = (from i in _AppDbContext.threads select i).OrderBy(x=>x.Title);
                    ViewBag.threads = threads1;

                }else if(sort=="Status")
                {
                    var threads1 = (from i in _AppDbContext.threads select i).OrderBy(x=>x.Status);
                    ViewBag.threads = threads1;
                }
                else
                {
                    var threads1 = (from i in _AppDbContext.threads select i).OrderBy(x=>x.CreatedAt);
                    ViewBag.threads = threads1;
                }
                
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterPost(string pass, string username, string email, IFormFile image1)
        {
            if(image1!=null)
            {
                var path ="wwwroot/images";
                Directory.CreateDirectory(path);
                var FileName = Path.Combine(path,Path.GetFileName(image1.FileName));
                image1.CopyTo(new FileStream(FileName,FileMode.Create));
                var file = FileName.Substring(7).Replace(@"\","/");
                var newuser = new User()
                {
                    Nama= username,
                    Email = email,
                    Password = pass,
                    Images=file,
                    Role="Member",
                    Verification=false,
                    Ban = false
                };
                _AppDbContext.users.Add(newuser);
                _AppDbContext.SaveChanges();
                var user = (from i in _AppDbContext.users select i).OrderBy(x=>x.Id).LastOrDefault();
                var iduser = user.Id;
                
                    //Send email confirmation
                    var msg = new MimeMessage();
                    var nama = username;
                    var emailAddress = email;
                    msg.From.Add(new MailboxAddress("Forum","Forum@bsi.co.id"));
                    msg.To.Add(new MailboxAddress(nama,emailAddress));
                    msg.Subject ="Verification Email";
                    msg.Body = new TextPart("Plain")
                    {
                        Text = "Please visit to this link to verification your account.\n"
                                +"192.168.17.109/Home/Verification?id="+iduser
                    };
                    using(var client = new MailKit.Net.Smtp.SmtpClient())
                    {
                    client.ServerCertificateValidationCallback = (s,c,h,e) => true;
                    client.Connect ("smtp.mailtrap.io", 587, false);
                    client.Authenticate ("900355b6c6565e", "c41b8aeb4da4ab");
                    client.Send (msg);
                    client.Disconnect (true);
                    }
                return RedirectToAction("Login","Home");
            }
            else
            {
                return RedirectToAction("Register","Home");
            }
        }
        public IActionResult Verification(int id)
        {
            var user= _AppDbContext.users.Find(id);
            ViewBag.user = user;
            return View();
        }
        public IActionResult SuccessVerif(int id)
        {
            var user = _AppDbContext.users.Find(id);
            Console.WriteLine("masuksuccess");
            user.Verification=true;
            // _AppDbContext.Add(user); 
            _AppDbContext.SaveChanges();
            return RedirectToAction("Login","Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginPost(string username, string pass)
        {
            Console.WriteLine(username);
            Console.WriteLine(pass);
            var user = from i in _AppDbContext.users select i;
            foreach(var i in user)
            {
                if(i.Nama==username && i.Password==pass && i.Role=="Member" && i.Verification==true)
                {
                    return RedirectToAction("Index","Member");
                
                }else if(i.Nama==username && i.Password==pass && i.Role=="Moderator" && i.Verification==true)
                {
                    Console.WriteLine("MODERATOR");
                    return RedirectToAction("Index","Moderator");
                }else if(i.Nama==username && i.Password==pass && i.Role=="Administrator" && i.Verification==true)
                {
                    return RedirectToAction("Index","Administrator");
                }
            }
            return RedirectToAction("Login","Home");
        }
        public IActionResult Detail(int id)
        {
            var detail = from i in _AppDbContext.threads where i.Id==id select i;
            ViewBag.detail = detail;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
