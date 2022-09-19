using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Core.DBContexts.EFContext
{
    public class GriffonEFContext : DbContext
    {
        public GriffonEFContext(DbContextOptions options) : base(options)
        {
        }

        protected GriffonEFContext()
        {
        }

        #region DBSets

        #endregion
    }
}
