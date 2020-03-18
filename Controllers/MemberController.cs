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
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        private AppDBContext _AppDbContext;
        public IConfiguration Configuration;

        public MemberController(ILogger<MemberController> logger, AppDBContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
            Configuration = configuration;
        }
        public IActionResult Index(string sort, string search,string filter)
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
                        var threads = (from i in _AppDbContext.threads where (i.Title.Contains(search) || i.Body.Contains(search)) && i.Category==filter select i).OrderBy(x=>x.CreatedAt);
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
            }else
            {
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
            var comment = from i in _AppDbContext.comments where i.Thread_Id==id select i;
            ViewBag.comments=comment;
            ViewBag.commentcount = comment.Count();
            return View();
        }
        public IActionResult NewThread()
        {
            return View();
        }
        public IActionResult Add(string category, string title,string body, IFormFile image)
        {
            if(image!=null)
            {
                var path ="wwwroot/images";
                Directory.CreateDirectory(path);
                var FileName = Path.Combine(path,Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(FileName,FileMode.Create));
                var file = FileName.Substring(7).Replace(@"\","/");
                var cek = from i in _AppDbContext.threads where i.Title==title && i.Category==category select i;
                Console.WriteLine(cek);
                if(cek.Count()<1)
                {
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
                }else
                {
                    var threadlast = (from i in _AppDbContext.threads where i.Category==category && i.Title==title select i).OrderBy(x=>x.CreatedAt);
                    var last = threadlast.LastOrDefault();
                    var idthread = last.Id;
                    var x = new ThreadsFull()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        Image = file,
                        CreatedAt = DateTime.Now,
                        ThreadId=idthread
                    };
                    _AppDbContext.threadsfull.Add(x);
                    _AppDbContext.SaveChanges();
                }
            }else
            {
                var cek = from i in _AppDbContext.threads where i.Title==title && i.Category==category select i;
                Console.WriteLine(cek);
                if(cek.Count()<1)
                {
                    var x = new Thread()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        Status = "Unlock",
                        CreatedAt = DateTime.Now
                    };
                    _AppDbContext.threads.Add(x);
                    _AppDbContext.SaveChanges();
                }else
                {
                    var threadlast = (from i in _AppDbContext.threads where i.Category==category && i.Title==title select i).OrderBy(x=>x.CreatedAt);
                    var last = threadlast.LastOrDefault();
                    var idthread = last.Id;
                    var x = new ThreadsFull()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        CreatedAt = DateTime.Now,
                        ThreadId=idthread
                    };
                    _AppDbContext.threadsfull.Add(x);
                    _AppDbContext.SaveChanges();
                }
            }
            return RedirectToAction("Index","Member");
        }
        public IActionResult AddThread(string category, string title,string body, IFormFile image)
        {
            if(image!=null)
            {
                var path ="wwwroot/images";
                Directory.CreateDirectory(path);
                var FileName = Path.Combine(path,Path.GetFileName(image.FileName));
                image.CopyTo(new FileStream(FileName,FileMode.Create));
                var file = FileName.Substring(7).Replace(@"\","/");
                var cek = from i in _AppDbContext.threads where i.Title==title && i.Category==category select i;
                if(cek.Count()<1)
                {
                    Console.WriteLine("kurang dari 1");
                    var x = new Thread()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        Image = file,
                        CreatedAt = DateTime.Now
                    };
                    _AppDbContext.threads.Add(x);
                    _AppDbContext.SaveChanges();
                }else
                {
                    Console.WriteLine("lebih dari 1");
                    var threadlast = (from i in _AppDbContext.threads where i.Category==category && i.Title==title select i).OrderBy(x=>x.CreatedAt);
                    var last = threadlast.LastOrDefault();
                    var idthread = last.Id;
                    var x = new ThreadsFull()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        Image = file,
                        CreatedAt = DateTime.Now,
                        ThreadId=idthread
                    };
                    _AppDbContext.threadsfull.Add(x);
                    _AppDbContext.SaveChanges();
                    var lanjutthread = from i in _AppDbContext.threads where i.Id ==idthread select i;
                    ViewBag.lanjutthread = lanjutthread;
                }
            }else{
                var cek = from i in _AppDbContext.threads where i.Title==title && i.Category==category select i;
                if(cek.Count()<1)
                {
                    Console.WriteLine("kurang dari 1");
                    var x = new Thread()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        CreatedAt = DateTime.Now
                    };
                    _AppDbContext.threads.Add(x);
                    _AppDbContext.SaveChanges();
                }else
                {
                    Console.WriteLine("lebih dari 1");
                    var threadlast = (from i in _AppDbContext.threads where i.Category==category && i.Title==title select i).OrderBy(x=>x.CreatedAt);
                    var last = threadlast.LastOrDefault();
                    var idthread = last.Id;
                    var x = new ThreadsFull()
                    {
                        Category = category,
                        Title = title,
                        Body = body,
                        CreatedAt = DateTime.Now,
                        ThreadId=idthread
                    };
                    _AppDbContext.threadsfull.Add(x);
                    _AppDbContext.SaveChanges();
                    var lanjutthread = from i in _AppDbContext.threads where i.Id ==idthread select i;
                    ViewBag.lanjutthread = lanjutthread;
                }
            }
            return RedirectToAction("NextThread","Member");
        }
        public IActionResult NextThread()
        {
            var x = (from i in _AppDbContext.threads select i).OrderBy(z=>z.CreatedAt);
            var last = x.LastOrDefault();
            ViewBag.lanjutthread = last;
            return View();
        }
        public IActionResult SendComment(string comment, int id)
        {
            var x = new Comment()
            {
                Comments = comment,
                Thread_Id = id,
                User_Name="Uha"
            };
            _AppDbContext.comments.Add(x);
            _AppDbContext.SaveChanges();
            return Redirect("Detail?id="+id);
        }
    }
}