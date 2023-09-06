using CRUDUsingEntity.Data;
using CRUDUsingEntity.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingEntity.Controllers
{
    public class StudentController : Controller
    {
        private readonly MVCDemoDBContext db;
        public StudentController(MVCDemoDBContext db) {
            this.db = db;
        }
        public IActionResult Index()
        {
            var result = db.MyProperty.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentModel createStudentRequest)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var student = new StudentModel()
                    {

                        Name = createStudentRequest.Name,
                        Email = createStudentRequest.Email,
                        Course = createStudentRequest.Course,
                        DateOFBirth = createStudentRequest.DateOFBirth
                    };

                    db.MyProperty.Add(student);
                    db.SaveChanges();
                    TempData["AlertMessage"] = "Student Added In List !!! ";
                    return RedirectToAction("index");
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


        public IActionResult Delete(int Id)
        {
            var res = db.MyProperty.Where(x => x.Id == Id).FirstOrDefault();
            db.MyProperty.Remove(res);
            db.SaveChanges();
            TempData["AlertMessage"] = "Student Deleted In List !!! ";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var res = db.MyProperty.Where(x => x.Id == Id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(StudentModel std)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var res = db.MyProperty.Where(x => x.Id == std.Id).FirstOrDefault();
                    res.Name = std.Name;
                    res.Email = std.Email;
                    res.Course = std.Course;
                    res.DateOFBirth = std.DateOFBirth;
                    db.SaveChanges();
                    TempData["AlertMessage"] = "Student Listis Edited!!! ";
                    return RedirectToAction("Index");
                  
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
        public IActionResult ShowData(int Id)
        {
            var res = db.MyProperty.Where(x => x.Id == Id).FirstOrDefault();

            return View(res);
        }
    }
}
