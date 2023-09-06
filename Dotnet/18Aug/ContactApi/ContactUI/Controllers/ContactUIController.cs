using ContactUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace ContactUI.Controllers
{
    public class ContactUIController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7238");
        private readonly HttpClient _httpClient;

        public ContactUIController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }
        [HttpGet]

        public IActionResult Index()
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:7238/api/Contact/GetContacts");
                var res = JsonConvert.DeserializeObject<IList<ContactUIModel>>(response);
                return View(res);
            }
        }




        public IActionResult IndexTo(ContactUIModel id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ContactUIModel st)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (WebClient webclient = new WebClient())
                    {
                        webclient.Headers.Add("Content-type:application/json");
                        webclient.Headers.Add("Accept:application/json");
                        string response = webclient.UploadString("https://localhost:7238/api/Contact/AddContacts", JsonConvert.SerializeObject(st));
                        return RedirectToAction("Create");
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return View();
                }
            }
            else
            {
                return View();

            }

        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {

            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:7238/api/Contact/GetContact/" +id);
                var res = JsonConvert.DeserializeObject<ContactUIModel>(response);
                return View(res);


            }

          
        }


        [HttpPost]
        public IActionResult Edit(ContactUIModel cn)
        {
            using (WebClient webclient = new WebClient())
            {

                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.UploadString("https://localhost:7238/api/Contact/UpdateContact/" + cn.Id, JsonConvert.SerializeObject(cn));
                var res = JsonConvert.DeserializeObject<ContactUIModel>(response);
                return RedirectToAction(nameof(Index));

            }
               
        }
        
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            using (WebClient webclient = new WebClient())
            {

                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:7238/api/Contact/DeleteContact/" + id);
                
                return RedirectToAction(nameof(Index));

            }
        }
        
       

    }
}

