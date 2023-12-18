using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Monster : ICharacter
    {
        public int Age { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }

        public int Weight { get; set; }
    }
}
