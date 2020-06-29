using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IHero
{

    interface IHero
    {
        
        int Id { get; set; }
        string Herojus { get; set; }
        int Levelis { get; set }

    }
    interface IVilain {
        List<IHero> Data { get; }

        string SukurtiHeroju(IHero duomuo);
        void KeltiLeveli(int levelis);

        void trintiHero();
    }

    class Herojus : IHero
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Levelis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IHero.Herojus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Vilain : IVilain
    {
        public List<IHero> Data => throw new NotImplementedException();

        public void KeltiLeveli(int levelis)
        {
            throw new NotImplementedException();
        }

        public string SukurtiHeroju(IHero duomuo)
        {
            throw new NotImplementedException();
        }

        public void trintiHero()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
