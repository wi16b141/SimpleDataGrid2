using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataGrid2.ViewModel
{
    public class AnimalVM : ViewModelBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Family { get; set; }
        public string Habitate { get; set; }
        public int Population { get; set; }
        public bool EatsMeat { get; set; }

        public AnimalVM() { }
        public AnimalVM(AnimalVM animal) {
            Name = animal.Name;
            Age = animal.Age;
            Family = animal.Family;
            Habitate = animal.Habitate;
            Population = animal.Population;
            EatsMeat = animal.EatsMeat;
        }
        public AnimalVM(string name, int age, string family, string habitate, int population, bool eatsMeat)
        {
            Name = name;
            Age = age;
            Family = family;
            Habitate = habitate;
            Population = population;
            EatsMeat = eatsMeat;
        }

    }
}
