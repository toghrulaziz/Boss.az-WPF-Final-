using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Documents.DocumentStructures;

namespace Boss_az_Task.Models
{
    internal class Vacancy
    {
        public int Id { get; set; }
        public static int StaticId = 1;
        public string? Name { get; set; }
        public string? Title { get; set; }
        public double Salary { get; set; }
        public int MinExperience { get; set; }
        public int MaxAge { get; set; }
        public string? WorkType { get; set; }


        public Vacancy()
        {
            Id = StaticId++;
        }


        public Vacancy(string? name, string? title, double salary, int minExperience, int maxAge, string? workType)
        {
            Id = StaticId++;
            Name = name;
            Title = title;
            Salary = salary;
            MinExperience = minExperience;
            MaxAge = maxAge;
            WorkType = workType;
        }


    }
}
