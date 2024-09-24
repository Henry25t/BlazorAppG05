using System.ComponentModel.DataAnnotations.Schema;
using SysSeguridadG05.EN;

namespace BlazorAppG05.Data
{
    public class RolDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }
        List<Usuario> usuarios { get; set; }
    }
}
