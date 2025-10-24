using System;
using System.Collections.Generic;

namespace Nguyenvanbac_231230717_de01.Models;

public partial class NvbComputer
{
    public int NvbComId { get; set; }

    public string? NvbComName { get; set; }

    public decimal? NvbComPrice { get; set; }

    public string? NvbComImage { get; set; }

    public bool? NvbComStatus { get; set; }
}
