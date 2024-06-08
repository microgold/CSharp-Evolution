using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_Chapter6
{
    public class AnimalClassifier
    {
        public string ClassifyAnimal(string species) =>
            species switch
            {
                "dog" => "Mammal",
                "crocodile" => "Reptile",
                "robin" => "Bird",
                _ => "Unknown"  // Discard case handles all other possibilities
            };
    }
}
