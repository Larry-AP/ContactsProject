using Microsoft.AspNetCore.Mvc;
using WebAppMultiPage.Controllers;

namespace WebAppMultiPage.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {

        public IActionResult Index() {...};

        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List(string id = "All") { ...};

        public IActionResult Add() { ... };
        public IActionResult Update(int id) { ... };
        public IActionResult Delete(int id) { ... };

        
    }
}
