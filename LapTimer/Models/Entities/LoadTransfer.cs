using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTimer.Models.Entities;

public class LoadTransfer
{
    public int Id { get; set; }

    public double AccelerateX { get; set; }

    public double AccelerateY { get; set; }

    public double AccelerateZ { get; set; }

    public double LocationX { get; set; }

    public double LocationY { get; set; }

    public DateTime CreatedAt { get; set; }
}
