using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace tp_D5;

public class AtivoFinanceiro
{
    [Key]
    public Guid ativo_id { get; set; }
    
    public TipoAtivoFinanceiro TipoAtivoFinanceiro { get; set; }
    public String nome { get; set; }
    public DateTime data_inicio { get; set; }
    public DateTime data_fim { get; set; }
    public float imposto { get; set; }
        
    public Guid? user_id { get; set; }
    public Utilizador Utilizador { get; set; }
}