using System;
namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base(String.Empty, name, owner, weight)
        {
            this.petName = name;
            this.petOwner = owner;
            this.petWeight = weight;
        }
        public string meow(int count)
        {
            string sound = "";
            for (int i = 0; i < count; i++)
            {
                sound = sound + "meow";
            }
            return sound;
        }
    }
}
