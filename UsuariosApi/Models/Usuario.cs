using Org.BouncyCastle.Math;

namespace UsuariosApi.Models
{
    public class Usuario
    {
        public BigInteger Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
