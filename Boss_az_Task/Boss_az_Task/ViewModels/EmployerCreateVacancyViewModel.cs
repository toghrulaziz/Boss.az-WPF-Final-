using Boss_az_Task.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;

namespace Boss_az_Task.ViewModels
{
    internal class EmployerCreateVacancyViewModel : MainViewModel
    {
        #region EmployerCreateVacancyBindingText
        private string? employerCreateVacancytxtName;

        public string? EmployerCreateVacancytxtName
        {
            get { return employerCreateVacancytxtName; }
            set { employerCreateVacancytxtName = value; }
        }

        private string? employerCreateVacancytxtTitle;

        public string? EmployerCreateVacancytxtTitle
        {
            get { return employerCreateVacancytxtTitle; }
            set { employerCreateVacancytxtTitle = value; }
        }


        private double employerCreateVacancySalary;

        public double EmployerCreateVacancySalary
        {
            get { return employerCreateVacancySalary; }
            set { employerCreateVacancySalary = value; }
        }


        private int employerCreateVacancyMinExperience;

        public int EmployerCreateVacancyMinExperience
        {
            get { return employerCreateVacancyMinExperience; }
            set { employerCreateVacancyMinExperience = value; }
        }



        private int employerCreateVacancyMaxAge;

        public int EmployerCreateVacancyMaxAge
        {
            get { return employerCreateVacancyMaxAge; }
            set { employerCreateVacancyMaxAge = value; }
        }


        private string? employerCreateVacancytxtWorkType;

        public string? EmployerCreateVacancytxtWorkType
        {
            get { return employerCreateVacancytxtWorkType; }
            set { employerCreateVacancytxtWorkType = value; }
        }

        #endregion



        public RelayCommand EmployerCreateVacancyOkCommand
        {
            get => new RelayCommand(() =>
            {
                Vacancy vacancy = new Vacancy() { Name = EmployerCreateVacancytxtName, Title = EmployerCreateVacancytxtTitle, Salary = EmployerCreateVacancySalary, MinExperience = EmployerCreateVacancyMinExperience, MaxAge = EmployerCreateVacancyMaxAge, WorkType = EmployerCreateVacancytxtWorkType };
                VacanciesJsonAddNewItem(vacancy);
                MessageBox.Show("Vacancy Created!");
            });
        }

    }
}
