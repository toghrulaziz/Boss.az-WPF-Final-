using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_az_Task.Models
{
    internal class CV
    {
        public string? Specialty { get; set; }
        public string? University { get; set; }
        public string[]? Skills { get; set; }
        public string[]? Companies { get; set; }
        public string[]? Languages { get; set; }
        public string? GitLink { get; set; }
        public string? Linkedin { get; set; }

        public CV()
        {
            
        }
        public CV(string? specialty, string? university, string[]? skills, string[]? companies, string[]? languages, string? gitLink, string? linkedin)
        {
            Specialty = specialty;
            University = university;
            Skills = skills;
            Companies = companies;
            Languages = languages;
            GitLink = gitLink;
            Linkedin = linkedin;
        }
    }
}
