using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data.Context
{
    public class CrmContext:DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }
    }
}
