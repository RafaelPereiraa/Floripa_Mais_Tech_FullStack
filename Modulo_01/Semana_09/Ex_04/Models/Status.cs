using System;
using System.Collections.Generic;

namespace Ex_04.Models;

public partial class Status
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
