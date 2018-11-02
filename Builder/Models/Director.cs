namespace Builder.Models
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildBottle();
            builder.BuildWater();
            builder.BuildCover();
            builder.BuildLabel();
        }
    }
}
