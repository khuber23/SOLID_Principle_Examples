namespace DependencyInversion
{
    public class CharacterBuilder
    {
        private ICharacter character;

        public CharacterBuilder(ICharacter character)
        {
            this.character = character;
        }

        public void ChangeAge(int age)
        {
            this.character.Age = age;
        }

        public void ChangeEyeColor(string eyeColor)
        {
            this.character.EyeColor = eyeColor;
        }

        public void ChangeHairColor(string hairColor)
        {
            this.character.HairColor = hairColor;
        }

        public void ChangeWeight(int weight)
        {
            this.character.Weight = weight;
        }

        public override string ToString()
        {
            return $"\nType: {this.character.GetType().Name}\n Age: {this.character.Age}\nEye Color: {this.character.EyeColor}\nHair Color: {this.character.HairColor}\nWeight: {this.character.Weight}";
        }
    }
}