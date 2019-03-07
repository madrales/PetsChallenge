using System;
namespace Pets
{
    public class Pet
    {
        public string petType { set; get; }
        public string petName { set; get; }
        public string petOwner { set; get; }
        public double petWeight { set; get; }

        public Pet(string t = "No Type.", string n = "No Name.", string o = "No owner.", double w = 0)
        {
            petType = t;
            petName = n;
            petOwner = o;
            petWeight = w;
        }

        public string getTag()
        {
            return("If lost, call " + petOwner + ".");
        }

    }
}