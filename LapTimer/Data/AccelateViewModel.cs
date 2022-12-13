using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LapTimer.Models;
using LapTimer.Models.Entities;
using Microsoft.AspNetCore.Components;
using LapTimer.Servicies;

namespace LapTimer.Data;

public class AccelateViewModel
{
    private LapTimerContext _dbContext;

    public AccelateViewModel(IDbService service)
    {
        this._dbContext = service.DbContext;
    }

    public async Task CreateAsync(LoadTransfer loadTransfer)
    {
        loadTransfer.CreatedAt = DateTime.Now;
        this._dbContext.LoadTransfer.Add(loadTransfer);

        _dbContext.SaveChanges();
    }
}
