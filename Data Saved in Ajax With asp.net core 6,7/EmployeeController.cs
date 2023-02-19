using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;
using WebEmployee.Data;
using WebEmployee.Helper;
using WebEmployee.Models;

namespace WebEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Jsonjdata()
        {
            try
            {
               
                return View();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public JsonResult Jsonjdata(string name,string mobile,string address)
        {
            try
            {
                Jsondatamodel jsondatamodel= new Jsondatamodel
                {
                    Name = name,
                    Mobile = mobile,                        
                    Address = address
                };
               _context.Add(jsondatamodel);
                _context.SaveChanges();
                return Json("Success");
            }
            catch (Exception ex)
            {

              throw new Exception(ex.Message);
            }

        }
    }
}
