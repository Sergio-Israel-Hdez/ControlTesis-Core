using System.Linq;
namespace ControlTesisCore.Models
{
    public class EstudianteModel
    {
        BD.controltesisContext ct = new BD.controltesisContext();
        public IQueryable<BD.Estudiante>DatoEstudiante(int idusuario){
            var result =(from es in ct.Estudiante where es.Idusuario==idusuario select es);
            return result;
        }
        public IQueryable<BD.CabezaGrupoEstudiante>CabezaGrupoEstudiante(int idusuario){
            var result = (from user in ct.Usuario 
                        join estu in ct.Estudiante on user.Idusuario equals estu.Idusuario
                        join cuerp_grup in ct.CuerpoGrupo on estu.Idestudiante equals cuerp_grup.Idestudiante
                        join cabez_grup in ct.CabezaGrupo on cuerp_grup.Idgrupo equals cabez_grup.Idgrupo
                        join docen in ct.Docente on cabez_grup.Iddocente equals docen.Iddocente
                        where user.Idusuario==idusuario
                        select new BD.CabezaGrupoEstudiante { IdGrupo = cabez_grup.Idgrupo,
                                    Docente = docen.Nombre+' '+docen.Apellido,
                                    Tema = cabez_grup.Tema,
                                    Nota = cabez_grup.Nota});
            return result;
        }
        public IQueryable<BD.CuerpoGrupoEstudiante>CuerpoGrupoEstudiantes(int idGrupo){
            var result =(from user in ct.Usuario 
                        join estu in ct.Estudiante on user.Idusuario equals estu.Idusuario
                        join cuerp_grup in ct.CuerpoGrupo on estu.Idestudiante equals cuerp_grup.Idestudiante
                        join carre in ct.Carrera on estu.Idcarrera equals carre.Idcarrera
                        where cuerp_grup.Idgrupo ==idGrupo
                        select new BD.CuerpoGrupoEstudiante { 
                                    Carnet = user.Carnet,
                                    Nombre = estu.Nombre+' '+estu.Apellido,
                                    Carrera = carre.Nombre,
                                    Telefono = estu.Telefono,
                                    Correo = estu.Correo
                                    });
            return result;            
        }
    }
}