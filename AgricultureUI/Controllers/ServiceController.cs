using AgricultureUI.Models;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService serviceService;

        public ServiceController(IServiceService serviceService)
        {
            this.serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values=serviceService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }


        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                serviceService.AddT(new Service()
                {
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description
                });

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult DeleteService(int id)
        {
            var values = serviceService.GetById(id);
            serviceService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values=serviceService.GetById(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceService.Update(service);
            return RedirectToAction("Index");
        }

        public IActionResult Denemee()
        {
            return View();
        }
    }
}
