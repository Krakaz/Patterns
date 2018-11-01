using AbstractFactory.Models.Core;

namespace AbstractFactory.Models.CocaCola
{
    class CocaColaFactory : Core.AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new CocaColaLabel();
        }
    }
}
