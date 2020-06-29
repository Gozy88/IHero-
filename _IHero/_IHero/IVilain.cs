using System.Collections.Generic;

namespace _IHero
{
    internal interface IVilain
    {
        List<IHero> Data { get; }

        string SukurtiHeroju(IHero duomuo);

        void KeltiLeveli(int levelis);

        void trintiHero();
    }
}