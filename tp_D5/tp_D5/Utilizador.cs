using System.ComponentModel.DataAnnotations;

namespace tp_D5;

public class Utilizador
{
    [Key]
    public Guid user_id { get; set; }
    
    public String nome { get; set; }
    public String email { get; set; }
    public String password { get; set; }
    
    public TipoUtilizador TipoUtilizador { get; set; }
}