using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapTimer.Models;

namespace LapTimer.Servicies;

public interface IDbService
{
    public LapTimerContext DbContext { get; }
}
