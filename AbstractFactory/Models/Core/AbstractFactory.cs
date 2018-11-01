using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models.Core
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();

        public abstract AbstractBottle CreateBottle();

        public abstract AbstractCover CreateCover();

        public abstract AbstractLabel CreateLabel();
    }
}
