using System;
using System.Collections.Generic;

namespace Ex_04.Models;

public partial class PizzaSabore
{
    public int Id { get; set; }

    public int IdPizza { get; set; }

    public int IdSabores { get; set; }

    public virtual Pizza IdPizzaNavigation { get; set; } = null!;

    public virtual Sabore IdSaboresNavigation { get; set; } = null!;
}
