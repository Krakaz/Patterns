using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    class CocaColaBuilder : Builder
    {
        Product Product = new Product();

        public override void BuildBottle()
        {
            Product.Add("CocaCola Bottle");
        }

        public override void BuildCover()
        {
            Product.Add("CocaCola Cover");
        }

        public override void BuildLabel()
        {
            Product.Add("CocaCola Label");
        }

        public override void BuildWater()
        {
            Product.Add("CocaCola Water");
        }

        public override Product GetProduct()
        {
            return this.Product;
        }
    }
}
