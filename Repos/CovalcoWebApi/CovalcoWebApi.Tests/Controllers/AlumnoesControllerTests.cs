using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovalcoWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using CovalcoWebApi.Models;
using System.Web.Http;
using System.Web.Http.Results;

using System.Text;
using System.Threading.Tasks;

namespace CovalcoWebApi.Controllers.Tests
{
    [TestClass()]
    public class AlumnoesControllerTests
    {
        [TestMethod()]
        public void GetAlumnoesTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IQueryable<Alumno> alumnos = controller.GetAlumnoes();
            Assert.IsTrue(alumnos.Count<Alumno>() > 0);
        }

        [TestMethod()]
        public void GetAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionResult = controller.GetAlumno(1);

            var contentResult = actionResult as
                 OkNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.Id);


        }

        [TestMethod()]
        public void PutAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionnResult = controller.PutAlumno(1,
                new
                Alumno
                {Id=1, Nombre ="Ferran" , Apellidos="Ferrer", Dni="23234434z"});
            Assert.IsNotNull(actionnResult);
        }

        [TestMethod()]
        public void PostAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionnResult =
                controller.PostAlumno(
                new
                Alumno
                { Id = 1, Nombre = "Ferran", Apellidos = "Ferrer", Dni = "23234434z" });
            var contentResult = actionnResult as
                CreatedAtRouteNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(actionnResult);
            Assert.IsTrue(contentResult.RouteName=="DefaultApi");
            
        }

        [TestMethod()]
        public void DeleteAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionnResult = controller.PostAlumno(
                new
                Alumno
                { Id = 1, Nombre = "Ferran", Apellidos = "Ferrer", Dni = "23234434z" });
            var contentResult = actionnResult as
                CreatedAtRouteNegotiatedContentResult<Alumno>;

            IHttpActionResult actionDeleteResult =
                controller.DeleteAlumno(contentResult.Content.Id);

            var contentDeleteResult = actionDeleteResult as
                OkNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(contentDeleteResult);
            Assert.IsNotNull(contentDeleteResult.Content);



        }
    }
}