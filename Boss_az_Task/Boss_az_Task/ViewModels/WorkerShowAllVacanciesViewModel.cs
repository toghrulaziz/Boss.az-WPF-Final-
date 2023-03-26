using Boss_az_Task.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_az_Task.ViewModels
{
    internal class WorkerShowAllVacanciesViewModel : MainViewModel
    {
		private ObservableCollection<Vacancy>? vacancies;

		public ObservableCollection<Vacancy> Vacancies
        {
			get { return vacancies; }
			set { vacancies = value; }
		}


        public WorkerShowAllVacanciesViewModel()
        {
            string json = File.ReadAllText("Vacancies.json");
            Vacancies = JsonConvert.DeserializeObject<ObservableCollection<Vacancy>>(json);
        }

    }
}
