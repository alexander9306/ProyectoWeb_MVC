﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWeb.Controllers
{
    public class ServiciosController : Controller
    {
        public IActionResult Servicios()
        {
            return View();
        }
    }
}