using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvc.Data;

namespace WebAppMvc.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor LISTAR
        public ActionResult Index() 
        {
            var doctors = new RepositoryDoctor().List(); //agarra los elementos del repositorio doctor y los manda a la vista
            return View(doctors);
            
        }
        //CREAR EL OBJETO DESDE EL FORMULARIO
        [HttpGet]
        public ActionResult Create() //la vista del formulario para crear el objeto
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Doctor model) //accion para insertar el objeto doctor creado en el repositorio
        {
            new RepositoryDoctor().Insert(model);
            return RedirectToAction("Index");
        }

        //EDITAR UN DOCTOR
        [HttpGet]
        public ActionResult Edit(int id) //trae la vista del formulario para editar
        {
            var doctor = new RepositoryDoctor().GetById(id);
            return View(doctor);
        }

        [HttpPost]
        public ActionResult Edit(Doctor model) //actuALIZA en el repositorio
        {
            new RepositoryDoctor().Update(model);
            return RedirectToAction("Index");
        }
        //ELIMINAR UN DOCTOR

        /****delete ***/
        [HttpGet]
        public ActionResult Delete(int id) //trae la vista del formulario eliminar
        {
            var doctor = new RepositoryDoctor().GetById(id);
            return View(doctor);
        }

        [HttpPost]
        public ActionResult Delete2(int id) //elimina
        {
            new RepositoryDoctor().Delete(id);
            return RedirectToAction("Index");
        }

        /*************/


    }
}