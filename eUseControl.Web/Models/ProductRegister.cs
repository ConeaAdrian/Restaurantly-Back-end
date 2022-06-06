using System.Collections.Generic;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Product;
using System.ComponentModel.DataAnnotations;

namespace eUseControl.Web.Models
{
    public class ProductRegister 
    {
        [Required(ErrorMessage = "The name field is empty.")]
        [Display(Name = "Product Name")]
        [StringLength(256, ErrorMessage = "Name must be more than 1 characters and less than 256 characters")]
        public string Prod_Name { get; set; }

        [Required(ErrorMessage = "The description field is empty.")]
        [Display(Name = "Description")]
        [StringLength(1000, ErrorMessage = "Description must be less than 256 characters.")]
        public string Prod_Desc { get; set; }

        [Required(ErrorMessage = "The price field is empty.")]
        [Display(Name = "Product Price")]
        [StringLength(256, ErrorMessage = "Price must be more than 1 characters.")]
        public string Prod_Price { get; set; }
    }
}