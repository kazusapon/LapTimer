using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LapTimer.Models;
using LapTimer.Models.Entities;
using Microsoft.Maui;

namespace LapTimer.Servicies;

public  class DbService : IDbService
{
    private LapTimerContext _dbContext;

    public LapTimerContext DbContext
    {
        get
        {
            if (this._dbContext == null)
            {
                _dbContext = new LapTimerContext();
                _dbContext.Database.Migrate();
            }

            return _dbContext;
        }
    }
}
