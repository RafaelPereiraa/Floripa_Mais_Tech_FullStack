using System;
using System.Collections.Generic;

namespace Ex_04.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int IdPizza { get; set; }

    public int IdStatus { get; set; }

    public virtual Pizza IdPizzaNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;
}
