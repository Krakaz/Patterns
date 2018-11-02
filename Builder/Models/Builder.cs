using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    abstract class Builder
    {
        public abstract void BuildBottle();
        public abstract void BuildWater();
        public abstract void BuildCover();
        public abstract void BuildLabel();

        public abstract Product GetProduct();
    }
}
