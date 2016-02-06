using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HttpEcho.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HttpEcho.Controllers
{
    public class EchoController : Controller
    {
        //[HttpPost]
        //[HttpGet]
        public IActionResult Index()
        {
            if (Request.Query.Keys.Count > 0 || Request.HasFormContentType)
            {
                var viewModel = new EchoViewModel();
                viewModel.Action = Request.Path.HasValue ? Request.Path.Value : "NO Action?";
                viewModel.Method = Request.Method;

                if (Request.HasFormContentType)
                {
                    foreach (var item in Request.Form)
                    {
                        viewModel.RequestVariables.Add(item.Key, item.Value);

                    }
                }

                foreach (var item in Request.Query)
                {
                    viewModel.QueryString.Add(item.Key, item.Value);
                }


                foreach (var item in Request.Headers)
                {
                    viewModel.RequestVariables.Add(string.Format("hdr: {0}", item.Key), item.Value);
                }


                return View(viewModel);
            }

            else
            {
                return View();
            }
        }
    }
}
