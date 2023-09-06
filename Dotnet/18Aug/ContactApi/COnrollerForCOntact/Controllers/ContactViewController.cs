using Microsoft.AspNetCore.Mvc;
using ConrollerForContact.Models;
namespace ConrollerForContact.Controllers
{
    public class ContactViewController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44370/api");
        private readonly HttpClient _httpClient;

        public ContactViewController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }
        [HttpGet]
        public IActionResult Index()
        {
          //  List<ContactViewModel> contactList = new List<ContactViewModel>();
          //  HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/contact/Get");
            return View();
        }
    }
}
