using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LapTimer.Models.Entities;

namespace LapTimer.Models;

public class LapTimerContext : DbContext
{
    private string _connectionString;

    public LapTimerContext()
    {
        this._connectionString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LapTimer.db");
    }

    public DbSet<LoadTransfer> LoadTransfer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source={this._connectionString}");
    }
}
