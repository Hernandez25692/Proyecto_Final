﻿using Proyecto_Final.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;



namespace Proyecto_Final.Controllers
{
	[ValidarSesion] //ejecuta la validacion de iniciar sesion que esta en la clase ValidarSesionAttribute de la carpeta permisos 
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult CerrarSecion()
		{
			Session["usuario"] = null;
			return RedirectToAction("Login", "Acceso");
			 
			
		}
	}
}