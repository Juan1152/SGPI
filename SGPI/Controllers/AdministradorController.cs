using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;


namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {

        SGPIDBContext context= new SGPIDBContext();

        [HttpPost]
        public IActionResult Login(Usuario user)
        {

            var usuario = context.Usuarios//Login si el usuario es correcto entra
                .Where(consulta => consulta.NumeroDocumento == user.NumeroDocumento
                && consulta.Password == user.Password).FirstOrDefault();

            if (usuario != null)
            {
                if(usuario.IdRol == 1){ 
                    return Redirect("Administrador/MenuAdmBuscar");//redirije a menu administrador
                }
                else if(usuario.IdRol == 2){
                    return Redirect("Coordinador/MenuCoordinadorBuscar");//redirije a menu coordinador
                }
                else if (usuario.IdRol == 3){
                    return Redirect("Estudiante/ActualizarEstudiante");//redirijhe a estudiante
                }
                else{
                
                }
            }
            else{ }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult OlvidarContrasena()
        {
            return View();
        }

        public IActionResult MenuRegistro() //registro de usuarios
        {
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.programa = context.Programas.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MenuRegistro(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.programa = context.Programas.ToList();

            return View();
        }

        public IActionResult MenuAdmBuscar()
        {
            ViewBag.documento = context.Documentos.ToList();// buscar usuario

            return View();

          
        }
        [HttpPost]

        public IActionResult MenuAdmBuscar(Usuario usuario)
        {
            var us = context.Usuarios
                .Where(u => u.NumeroDocumento == usuario.NumeroDocumento
                && u.IdDoc == usuario.IdDoc).FirstOrDefault();


            if (us != null)
            {
                ViewBag.documento = context.Documentos.ToList();
                return View(us);
            }

            else
            {
                ViewBag.documento = context.Documentos.ToList();
                return View();
            }
        }

        public IActionResult MenuAdmModificar(int?IdUsuario)//modificar usuario

        {
            Usuario usuario = context.Usuarios.Find(IdUsuario);
            if (usuario != null)
            {
                ViewBag.genero = context.Generos.ToList();
                ViewBag.documento = context.Documentos.ToList();
                ViewBag.rol = context.Rols.ToList();
                ViewBag.programa = context.Programas.ToList();
                return View(usuario);
            }
            else
                return Redirect("Administrador/MenuAdmBuscar");
        }
        [HttpPost]

        public IActionResult MenuAdmModificar(Usuario user)
        {
            context.Update(user);
            context.SaveChanges();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.programa = context.Programas.ToList();
            return Redirect("Administrador/MenuAdmBuscar");




        }
        public ActionResult Delete(int ?IdUsuario) {

            Usuario usuario = context.Usuarios.Find(IdUsuario);

            if (usuario != null)
            {
                context.Remove(usuario);
                context.SaveChanges();
                return Redirect("/Administrador/MenuAdmBuscar");
            }
            else

                return View();

        }


        public IActionResult Reportes()


        {
            return View();
        }
    }
}
