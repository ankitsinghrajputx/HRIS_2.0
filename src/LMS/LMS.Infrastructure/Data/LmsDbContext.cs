using LMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Data
{
    public class LmsDbContext(DbContextOptions<LmsDbContext> options) : DbContext(options)

    {
        public DbSet<LeaveEntity> leaves {  get; set; }
    }
}
