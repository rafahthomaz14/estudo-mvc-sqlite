using System;
using System.Collections.Generic;

namespace estudo_mvc.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Endereco { get; set; }
}
