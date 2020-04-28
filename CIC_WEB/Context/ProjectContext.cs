using CIC_WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIC_WEB.Context
{
    public class ProjectContext: DbContext
    {
       
            public DbSet<Project> Projects { get; set; }

       

    }
}