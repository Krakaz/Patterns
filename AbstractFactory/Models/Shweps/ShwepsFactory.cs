using AbstractFactory.Models.Core;

namespace AbstractFactory.Models.Shweps
{
    class ShwepsFactory : Core.AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new ShwepsWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new ShwepsBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new ShwepsCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new ShwepsLabel();
        }
    }
}
