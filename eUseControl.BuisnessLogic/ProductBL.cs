using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Product;
using eUseControl.BusinessLogic;

namespace eUseControl.BuisnessLogic
{
    public class ProductBL : UserApi, IProduct
    {
        public List<ProductData> GetProductList()
        {
            return new List<ProductData>();
        }

        public List<ProductData> GetOrdersByUser(int UserId)
        {
            return MyOrders(UserId);
        }
    }
}
