using System;

namespace LiskovSubstitution
{
    public class CantFlyException : Exception
    {
        public override string ToString()
        {
            return "This animal can't fly.";
        }
    }
}