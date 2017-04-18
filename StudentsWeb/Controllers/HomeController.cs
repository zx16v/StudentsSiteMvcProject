using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ShimiTest
{
    public class HomeController : Controller
    {
        private StudentsLogic logic = new StudentsLogic();

        public ActionResult Index()
        {
            ViewBag.CurrentPage = 1;
            ViewBag.LastPage = Math.Ceiling(Convert.ToDouble(logic.DB.Students.Count()) / 2);
            return View(logic.GetAllStudents().Take(2));

        }

        [HttpPost]
        public ActionResult Index(int CurrentPage, int LastPage)
        {
           ViewBag.CurrentPage = CurrentPage;
           ViewBag.LastPage = LastPage;
           return PartialView("_studentsGrid", logic.GetAllStudents().OrderBy(c => c.ID).Skip((CurrentPage - 1)*2).Take(2));
       }

        public ActionResult Edit(int id)
        {
            return View(logic.GetStudent(id));
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            logic.DB.Entry(student).State = System.Data.Entity.EntityState.Modified;
            logic.DB.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult GetCities(string term)
        {
           logic.DB.Configuration.ProxyCreationEnabled = false;
            List<City> cities = null;
            cities = logic.DB.Cities.Where(x => x.CityName.StartsWith(term)).ToList();
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult _getCities(string term)
        {
            List<City> cities = null;
            cities = logic.DB.Cities.Where(x => x.CityName.StartsWith(term)).ToList();
            string json = JsonConvert.SerializeObject(cities, Formatting.Indented);
              return Content(json, "application/json");
        }

        public ActionResult Add()
        {
            ViewModelStudentAndCities combindeModel = new ViewModelStudentAndCities();
            combindeModel.Cities = logic.DB.Cities.Select(x => x).ToList();
            return View(combindeModel);
        }

        [HttpPost]
        public ActionResult Add(ViewModelStudentAndCities student)
        {
            Student ConvStudent = new Student();
            if (ModelState.IsValid)
            {
                ConvStudent.Date_of_birth = student.Date_of_birth;
                ConvStudent.Description_ = student.Description_;
                ConvStudent.First_name_ = student.First_name_;
                ConvStudent.Israeli_ID_ = student.Israeli_ID_;
                ConvStudent.Last_name_ = student.Last_name_;
                if (student.SelectedCity.Id == 0)
                    ConvStudent.CityId = null;
                else ConvStudent.CityId = student.SelectedCity.Id;
                logic.DB.Students.Add(ConvStudent);
                logic.DB.SaveChanges();
            }
            return RedirectToAction("Index");
        }

       [HttpPost]
        public ActionResult DeleteAJAX(int studentid)
        {
            var student = logic.DB.Students.Where(x => x.ID.Equals(studentid)).SingleOrDefault();
            logic.DB.Students.Remove(student);
            logic.DB.SaveChanges();
            ViewBag.LastPage = Math.Ceiling(Convert.ToDouble(logic.DB.Students.Count()) / 2);
            ViewBag.CurrentPage = ViewBag.LastPage;
            return PartialView("_studentsGrid", logic.GetAllStudents().OrderBy(c => c.ID).Skip(0).Take(2));
        }

        public JsonResult GetCitiesNames(string term)
        {
            List<string> citiesNames = null;
            citiesNames = logic.DB.Cities.Where(x => x.CityName.StartsWith(term)).Select(y => y.CityName).ToList();
            return Json(citiesNames, JsonRequestBehavior.AllowGet);
        }

    }
}