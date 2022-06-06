using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eUseControl.Domain.Entities.Product;

namespace eUseControl.BuisnessLogic.DBModel
{
    public class ProductContext : DbContext
    {
        public ProductContext() :
            base("name=eUseControl")
        {

        }

        public virtual DbSet<DbProduct> Products { get; set; }
    }
}
