using System;
namespace Pets
{
    class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base(string.Empty, name, owner,weight)
        {
            this.petName = name;
            this.petOwner = owner;
            this.petWeight = weight;
        }
        public string bark(int count)
        {
            string sound = "";
            for (int i = 0; i < count; i++)
            {
                sound = sound + "bark!";
            }
            return sound;
        }
    }
}
