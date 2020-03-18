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
using Task_Try_Out_Forum.Models;
namespace Task_Try_Out_Forum.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly ILogger<AdministratorController> _logger;
        private AppDBContext _AppDbContext;
        public IConfiguration Configuration;

        public AdministratorController(ILogger<AdministratorController> logger, AppDBContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
            Configuration = configuration;
        }
        public IActionResult Index(string search,string sort,string filter)
        {
            var category = (from i in _AppDbContext.threads select i.Category).Distinct();
            ViewBag.category=category;
            ViewBag.filter=filter;
            if(!String.IsNullOrEmpty(filter) || !String.IsNullOrWhiteSpace(filter))
            {
                if(!String.IsNullOrEmpty(search) || !String.IsNullOrWhiteSpace(search))
                {
                    Console.WriteLine("oke");
                    if(sort=="By DateTime")
                    {
                        var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search))&& i.Category==filter select i).OrderBy(x=>x.CreatedAt);
                        ViewBag.threads = threads;

                    }else if(sort=="By Title")
                    {
                        var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) && i.Category==filter select i).OrderBy(x=>x.Title);
                        ViewBag.threads = threads;

                    }else if(sort=="Status")
                    {
                        var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) && i.Category==filter select i).OrderBy(x=>x.Status);
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
            }else{
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
            }
            return View();
        }
        public IActionResult Detail(int id)
        {
            var detail = from i in _AppDbContext.threads where i.Id==id select i;
            ViewBag.detail = detail;
            var full = (from i in _AppDbContext.threadsfull where i.ThreadId==id select i).OrderBy(x=>x.CreatedAt);
            ViewBag.full =full;
            return View();
        }
        public IActionResult Delete(int id)
        {
            var thread = _AppDbContext.threads.Find(id);
            _AppDbContext.threads.Remove(thread);
            _AppDbContext.SaveChanges();
            return RedirectToAction("Index","Administrator");
        }
        public IActionResult ChangeStatus(int id)
        {
            var thread = _AppDbContext.threads.Find(id);
            if(thread.Status=="Lock")
            {
                thread.Status="Unlock";
            }else
            {
                thread.Status="Lock";
            }
            _AppDbContext.SaveChanges();
            return RedirectToAction("Index","Administrator");
        }
        public IActionResult ChangeRole(int id, string role)
        {
            Console.WriteLine(id);
            Console.WriteLine(role);
            var user = _AppDbContext.users.Find(id);
            if(user.Role=="Member" && user.Ban==true)
            {
                user.Ban = false;
                user.Role = role;
            }
            else
            {
                user.Role = role;
            }
            _AppDbContext.SaveChanges();
            return RedirectToAction("ListUser","Administrator");
        }
        public IActionResult ListUser()
        {
            var member = from i in _AppDbContext.users select i;
            ViewBag.member = member;
            return View();
        }
        public IActionResult BanMember(int id)
        {
            var member = _AppDbContext.users.Find(id);
            member.Ban = true;
            _AppDbContext.SaveChanges();
            return RedirectToAction("ListUser","Administrator");
        }
        public IActionResult UnbanMember(int id)
        {
            var member = _AppDbContext.users.Find(id);
            member.Ban = false;
            _AppDbContext.SaveChanges();
            return RedirectToAction("ListUser","Administrator");
        }
        public IActionResult NewThread()
        {
            return View();
        }
        public IActionResult Add(string category, string title,string body, IFormFile image)
        {
            var path ="wwwroot/images";
            Directory.CreateDirectory(path);
            var FileName = Path.Combine(path,Path.GetFileName(image.FileName));
            image.CopyTo(new FileStream(FileName,FileMode.Create));
            var file = FileName.Substring(7).Replace(@"\","/");
            var x = new Thread()
            {
                Category = category,
                Title = title,
                Body = body,
                Image = file,
                Status = "Unlock",
                CreatedAt = DateTime.Now
            };
            _AppDbContext.threads.Add(x);
            _AppDbContext.SaveChanges();
            return RedirectToAction("Index","Administrator");
        }
        public IActionResult AddUser(string name, string email, string pass, string selectadd)
        {
            var x = new User()
            {
                Nama= name,
                Email= email,
                Password = pass,
                Role = selectadd,
                Verification = true,
                Ban = false
            };
            _AppDbContext.users.Add(x);
            _AppDbContext.SaveChanges();
            return RedirectToAction("ListUser","Administrator");
        }
    }
}