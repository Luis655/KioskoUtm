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


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        //[TestMethod]
        //public void TestMethod2()
        //{
        //}










       
        [TestMethod]
        public void Val_DatosEnCreateAlumno()
        {
            
            
            

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
                Contraseña = "123",
                Idcargo = 1
            };

            
            //var arch = registro.Fotoalumno =("img");
            //_context.Add(registro);


            //await
            //await _context.SaveChangesAsync();

            
            var controller = new RegistrosalumnoesController(_context);
            // var ima = controller.SubirImagen(RutaCapeta, archivo);
            
            //var expected = registro.Fotoalumno = SubirImagen("img", archivo);
            var respuesta =  controller.Create(registro);
            //var resultados = respuesta as RedirectToActionResult;
            

            Assert.IsInstanceOfType(respuesta, typeof(Microsoft.AspNetCore.Mvc.ViewResult)); 
           
        }

        

        public string SubirImagen(string RutaCarpeta, IFormFile ArchivoSubir)
        {

            //var alumno = new Registrosalumno();

            //condigo para que se guarde la imagen
            string carpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", RutaCarpeta);
            string NombreArchivo = Guid.NewGuid().ToString() + "_" + ArchivoSubir.FileName;
            //union de las carpetas
            string RutaArchivoUnico = Path.Combine(carpeta, NombreArchivo);
            //adjuntar la imagen en la carpeta
            using (var InfoArchivo = new FileStream(RutaArchivoUnico, FileMode.Create)) ArchivoSubir.CopyTo(InfoArchivo);
            return NombreArchivo;




        }


        [TestMethod]
        public void Val_DatosincorrectosEnCreateAlumno()
        {

            var _context = new KIOSKOUTM1Context();
            var registro = new Registrosalumno
            {
                Nombre = "lklklklklklklklklklklklklkzlkslkslkalklaklklklksadasdasasasd",
                Apellidop = "macias",
                Apellidom = "hau",
                Idgradoygrupo = 3,
                Iddivisiones = 5,
                Idproyectos = 5,
                Telefono = "9999999999",
                Direccion = "sin direccion",
                Fechanac = Convert.ToDateTime("2000-05-10"),
                Idstatus = 1,
                Fotoalumno = "fot.jpg",
                Correo = "elsal@fmail.com",
                Contraseña = "1234567899",
                Idcargo = 1
            };

           // var arch = registro.Fotoalumno = ("img");
            //_context.Add(registro);


            bool expected = false;


            var controller = new RegistrosalumnoesController(_context);
            var respuesta = controller.validacioncamposcorrectos(registro);
            //var resultados = respuesta as RedirectToActionResult;
            Assert.AreEqual(expected, respuesta);
        }



        [TestMethod]
        public void Val_todoslosDatosvaciosEnCreateAlumno()
        {

            var _context = new KIOSKOUTM1Context();
            var registro = new Registrosalumno
            {
                Nombre = null,
                Apellidop = null,
                Apellidom = null,
                Idgradoygrupo = null,
                Iddivisiones = null,
                Idproyectos = null,
                Telefono = null,
                Direccion = null,
                Fechanac = null,
                Idstatus = null,
                Fotoalumno = null,
                Correo = null,
                Contraseña = null,
                Idcargo = null
                
            };
            

            bool expected = false;
            //_context.Add(registro);


            var controller = new RegistrosalumnoesController(_context);
            var respuesta = controller.validaciontodoscamposvacios(registro);


            Assert.AreEqual(expected, respuesta);
            
            



        }



        [TestMethod]
        public void Val_cuandonohayfotoEnCreateAlumno()
        {

            var _context = new KIOSKOUTM1Context();
            var registro = new Registrosalumno
            {
                Nombre = "luis",
                Apellidop = "macias",
                Apellidom = "hau",
                Idgradoygrupo = 3,
                Iddivisiones = 5,
                Idproyectos = 5,
                Telefono = "9999999999",
                Direccion = "sin direccion",
                Fechanac = Convert.ToDateTime("2000-05-10"),
                Idstatus = 1,
                Fotoalumno = null,
                Correo = "elsal@fmail.com",
                Contraseña = "123",
                Idcargo = 1
            };
            bool expected = false;
            


            var controller = new RegistrosalumnoesController(_context);
            var respuesta = controller.validarfotovalida(registro);
            //var resultados = respuesta as RedirectToActionResult;
            Assert.AreEqual(respuesta, expected);



        }



        [TestMethod]
        public void Val_cuandohayfechavalidaCreateAlumno()
        {
            
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
                Fechanac = Convert.ToDateTime("01-01-2000"),
                Idstatus = 1,
                Fotoalumno = "foto.jpg",
                Correo = "elsal@fmail.com",
                Contraseña = "123",
                Idcargo = 1
            };

            //var arch = registro.Fotoalumno = ("img");
            //_context.Add(registro);

            bool expected = false;
            


            var controller = new RegistrosalumnoesController(_context);
            var respuesta = controller.validarfechasvalidas( registro);
            //var resultados = respuesta as RedirectToActionResult;
            Assert.AreEqual(respuesta, expected);



        }




    }

}


