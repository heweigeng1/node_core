using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UI.DI;
using System.Threading;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDateTime _datetime;
        /// <summary>
        /// ���캯��ע��
        /// </summary>
        /// <param name="datetime"></param>
        public HomeController(IDateTime datetime)
        {
            _datetime = datetime;
        }
        public IActionResult Index()
        {
            ViewData["time"] = _datetime.Now.ToString();
            return View();
        }
        /// <summary>
        /// FromServices ���ע��
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public IActionResult Error([FromServices] IDateTime datetime)
        {
            ViewData["time"] = $"����ʱ��Ϊ:{datetime.Now}";
            return View();
        }
        
    }
}