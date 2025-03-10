using System.ComponentModel.DataAnnotations;

namespace tp_D5;

public class Invoice
{
    [Key]
    public Guid invoice_id { get; set; }
    
    public Guid? user_id { get; set; }
    public Utilizador Utilizador { get; set; }
    
    public DateTime data_invoice { get; set; }
    public String descricao { get; set; }
}