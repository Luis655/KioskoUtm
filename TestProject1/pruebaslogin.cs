using Kiosko.Controllers;
using Kiosko.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicacion_Web1.Models;

using Microsoft.Extensions.Logging;


using System.Diagnostics;





namespace TestProject1
{

    [TestClass]
    public class pruebaslogin
    {
        [TestMethod]
        public void validacioncorreoycontraseña()
        {
            //arrage
            var _context = new KIOSKOUTM1Context();
            var registro = new Registrosalumno
            {

                Nombre = "luis",
                Apellidop = "macias",
                Apellidom = "hau",
                Idgradoygrupo = 3,
                Iddivisiones = 5,
                Idproyectos = 5,
                Telefono = "99999999",
                Direccion = "sin direccion",
                Fechanac = Convert.ToDateTime("2000-05-10"),
                Idstatus = 1,
                Fotoalumno = "fot.jpg",
                Correo = "elsal@fmail.com",
                Contraseña = "12345678910",
                Idcargo = 1
            };

            string correo;
            string contra;
            correo = "elsal@fmail.com";
            contra = "12345678910";

            var controller = new HomeController(_context);
            var respuesta = controller.Onpost(correo, contra);
            //act
            bool expected = false;

            //comprobar que la cuenta exista
            if (registro.Correo == correo && registro.Contraseña == contra)
            {

                expected = true;
            }

           


            
            //assert
            Assert.IsInstanceOfType(respuesta, typeof(Microsoft.AspNetCore.Mvc.RedirectToActionResult));
            Assert.IsTrue(expected);







        }
    

        
    }

}