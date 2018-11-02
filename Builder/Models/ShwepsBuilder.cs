using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    class ShwepsBuilder : Builder
    {
        Product Product = new Product();

        public override void BuildBottle()
        {
            Product.Add("Shweps Bottle");
        }

        public override void BuildCover()
        {
            Product.Add("Shweps Cover");
        }

        public override void BuildLabel()
        {
            Product.Add("Shweps Label");
        }

        public override void BuildWater()
        {
            Product.Add("Shweps Water");
        }

        public override Product GetProduct()
        {
            return this.Product;
        }
    }
}
