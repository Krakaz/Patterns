using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    class PepsiBuilder : Builder
    {
        Product Product = new Product();

        public override void BuildBottle()
        {
            Product.Add("Pepsi Bottle");
        }

        public override void BuildCover()
        {
            Product.Add("Pepsi Cover");
        }

        public override void BuildLabel()
        {
            Product.Add("Pepsi Label");
        }

        public override void BuildWater()
        {
            Product.Add("Pepsi Water");
        }

        public override Product GetProduct()
        {
            return this.Product;
        }
    }
}
