namespace DependencyInversion
{
    public class Human : ICharacter
    {
        public int Age { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }

        public int Weight { get; set; }
    }
}