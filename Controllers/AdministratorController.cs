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
        public IActionResult Detail(int id)
        {
            var detail = from i in _AppDbContext.threads where i.Id==id select i;
            ViewBag.detail = detail;
            return View();
        }
        
    }
}