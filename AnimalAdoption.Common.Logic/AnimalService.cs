using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Panda A", Age = 5, Description = "Panda A" },
            new Animal { Id = 2, Name = "Panda B", Age = 6, Description = "Panda B" },
            new Animal { Id = 3, Name = "Panda C", Age = 7, Description = "Panda C" },
        };
    }
}
