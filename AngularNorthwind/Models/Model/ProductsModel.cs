using AngularNorthwind.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularNorthwind.Models.Model
{
    public class ProductsModel
    {
        public List<Products> plist { get; set; }
        public List<CategoriesSelect> clist { get; set; }
        public List<SuppliersSelect> slist { get; set; }
    }
}