using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface ICharacter
    {
        int Age { get; set; }

        string EyeColor { get; set; }

        string HairColor { get; set; }

        int Weight { get; set; }
    }
}
