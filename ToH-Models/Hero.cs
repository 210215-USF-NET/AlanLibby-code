using System;

namespace ToH_Models
{
    /// <summary>
    /// Data structure used for modeling a hero
    /// </summary>
    public class Hero
    {
        private string heroName;

        /* HeroName is a property (smart field) of the Hero class
         * Its backing field is heroName (note capitalization)
         * C# classes also have fields, methods, and constructors just like in Java.
         */
        public string HeroName { get { return heroName; } set { 
            if (value.Equals(null)) {
                throw new Exception("Hero name cannot be null.");
            }
            heroName = value;
         } }
    }
}
