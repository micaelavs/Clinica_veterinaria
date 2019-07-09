using ClientPatientManagement.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvc.Data;

namespace WebAppMvc.Controllers
{
    public class ClientController : Controller
    {
        // GET: cliente LISTAR
        public ActionResult Index()
        {
            var clients = new RepositoryClient().List(); 
            return View(clients);

        }
        //CREAR EL OBJETO DESDE EL FORMULARIO
        [HttpGet]
        public ActionResult Create() //la vista del formulario para crear el objeto
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Client model) //accion para insertar el objeto doctor creado en el repositorio
        {
            new RepositoryClient().Insert(model);
            return RedirectToAction("Index");
        }

        //EDITAR UN cliente
        [HttpGet]
        public ActionResult Edit(int id) //trae la vista del formulario para editar
        {
            var client = new RepositoryClient().GetById(id);
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Client model) //actuALIZA en el repositorio
        {
            new RepositoryClient().Update(model);
            return RedirectToAction("Index");
        }
        //ELIMINAR UN cliente

        /****delete ***/
        [HttpGet]
        public ActionResult Delete(int id) //trae la vista del formulario eliminar
        {
            var client = new RepositoryClient().GetById(id);
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete2(int id) //elimina
        {
            new RepositoryClient().Delete(id);
            return RedirectToAction("Index");
        }

        /*************/


    }
}