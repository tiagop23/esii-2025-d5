using System.ComponentModel.DataAnnotations;

namespace tp_D5;

public class Impostos
{
    [Key]
    public Guid imposto_id { get; set; }
    
    public Guid? ativo_id { get; set; }
    public AtivoFinanceiro AtivoFinanceiro { get; set; }
    
    public DateTime data_pagamento { get; set; }
    public double valor_pago { get; set; }
}