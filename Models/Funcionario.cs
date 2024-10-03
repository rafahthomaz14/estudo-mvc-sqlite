using System;
using System.Collections.Generic;

namespace estudo_mvc.Models;

public partial class Funcionario
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Cargo { get; set; }
}
