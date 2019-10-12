using System.Linq;
namespace ControlTesisCore.Models
{
    public class UsuarioModel
    {
        BD.controltesisContext ct = new BD.controltesisContext();
        public IQueryable<BD.Usuario>ValidarUsuario(BD.Usuario user){
            var result = (from us in ct.Usuario where us.Carnet==user.Carnet && us.Contraseña==user.Contraseña select us);
            return result;
        }
    }
}