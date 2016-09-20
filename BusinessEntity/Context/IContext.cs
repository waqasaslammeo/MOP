using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BusinessEntity.SMS;

namespace BusinessEntity.Context
{
    public interface IContext
    {
        DbSet<Role> Roles { get; set; }
    }
}