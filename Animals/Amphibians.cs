﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_18_exercise_1
{
    class Amphibians : IAnimal //реализация интерфейса
    {
        public string TypeAnimal { get; set; }
        public string Genus { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Amphibians(string TypeAnimal, string Genus, string Name, string Breed, int Age)
        {
            this.TypeAnimal = TypeAnimal;
            this.Genus = Genus;
            this.Name = Name;
            this.Breed = Breed;
            this.Age = Age;
        }
        //public override string ToString() //перезапить ToString для вывода данных
        //{
        //    return $"{this.TypeAnimal} {this.Genus} {this.Name} {this.Breed} {this.Age}";
        //}
    }
}
