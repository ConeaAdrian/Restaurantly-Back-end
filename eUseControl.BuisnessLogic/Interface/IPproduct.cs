﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Product;



namespace eUseControl.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        List<ProductData> GetProductList();



        List<ProductData> GetOrdersByUser(int UserId);



    }
}