using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IHero
{
    internal class Herojus : IHero
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Levelis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IHero.Herojus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Supermentas : IHero
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Herojus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Levelis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Jokeris : IVilain
    {
        public List<IHero> Data => throw new NotImplementedException();

        public void KeltiLeveli(int levelis)
        {
        }

        public string SukurtiHeroju(IHero duomuo)
        {
            Supermentas supermentas = new Supermentas();
            return supermentas.Herojus;
        }

        public void trintiHero()
        {
        }
    }

    internal class Vilain : IVilain
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

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}