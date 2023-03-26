using Boss_az_Task.Models;
using Boss_az_Task.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D.Converters;

namespace Boss_az_Task.ViewModels
{
    internal class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private UserControl? _currentControl;

        public UserControl? CurrentControl
        {
            get { return _currentControl; }
            set { _currentControl = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            CurrentControl = new EmployerOrWorkerView();

            Workers = new ObservableCollection<Worker>
            {
                new Worker(){Name = "Togrul",Surname = "Azizli",Password = "1234", Phone = "773780123", Address = "Baku", Age = 18 },
                new Worker(){Name = "Elon",Surname = "Musk",Password = "1234", Phone = "8899889988", Address = "New-York", Age = 40 }
            };


            Employers = new ObservableCollection<Employer>
            {
                new Employer(){Name = "Togrul",Surname = "Azizli",Password = "4321", Phone = "773780123", Address = "Baku", Age = 18 },
                new Employer(){Name = "Elon",Surname = "Musk",Password = "4321", Phone = "8899889988", Address = "New-York", Age = 40 }
            };


            Vacancies = new ObservableCollection<Vacancy>
            {
                new Vacancy(){Name = "Vacancy 1", Title = "Back end Developer",Salary = 1500,MinExperience = 2, MaxAge = 50,WorkType = "Remoute"},
                new Vacancy(){Name = "Vacancy 2", Title = "Front end Developer",Salary = 1000,MinExperience = 3, MaxAge = 55,WorkType = "Freelance"}
            };


            WriteToFileFromListForWorker(Workers);

            WriteToFileFromListForEmployers(Employers);

            WriteToFileFromListForVacancies(Vacancies);




        }

        public RelayCommand ShowEmployerSign
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new EmployerSignInOrSignUpView();
            });
        }

        public RelayCommand ShowWorkerSign
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new WorkerSignInOrSignUpView();
            });
        }


        ////////////// Employer Sign In/Up /////////////

        public RelayCommand ShowEmployerSignIn
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new EmployerSignIn();
            });
        }

        public RelayCommand ShowEmployerSignUp
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new EmployerSignUp();
            });
        }

        ////////////////////////////////////////////////



        ////////////// Worker Sign In/Up ////////////

        public RelayCommand ShowWorkerSignIn
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new WorkerSignIn();
            });
        }

        public RelayCommand ShowWorkerSignUp
        {
            get => new RelayCommand(() =>
            {
                CurrentControl = new WorkerSignUp();
            });
        }

        ////////////////////////////////////////

        #region WorkerSignInBindingText

        private string workerSignIntxtName;

        public string WorkerSignIntxtName
        {
            get { return workerSignIntxtName; }
            set { workerSignIntxtName = value; }
        }



        private string? workerSignIntxtPassword;

        public string? WorkerSignIntxtPassword
        {
            get { return workerSignIntxtPassword; }
            set { workerSignIntxtPassword = value; }
        }


        #endregion


        #region EmployerSignInBindingText

        private string employerSignIntxtName;

        public string EmployerSignIntxtName
        {
            get { return employerSignIntxtName; }
            set { employerSignIntxtName = value; }
        }


        private string? employerSignIntxtPassword;

        public string? EmployerSignIntxtPassword
        {
            get { return employerSignIntxtPassword; }
            set { employerSignIntxtPassword = value; }
        }


        #endregion


        #region WorkerSignUpBindingTexts

        private string? workerSignUptxtName;

        public string? WorkerSignUptxtName
        {
            get { return workerSignUptxtName; }
            set { workerSignUptxtName = value; }
        }


        private string? workerSignUptxtSurname;

        public string? WorkerSignUptxtSurname
        {
            get { return workerSignUptxtSurname; }
            set { workerSignUptxtSurname = value; }
        }


        private string? workerSignUptxtPassword;

        public string? WorkerSignUptxtPassword
        {
            get { return workerSignUptxtPassword; }
            set { workerSignUptxtPassword = value; }
        }


        private string? workerSignUptxtPhone;

        public string? WorkerSignUptxtPhone
        {
            get { return workerSignUptxtPhone; }
            set { workerSignUptxtPhone = value; }
        }


        private string? workerSignUptxtAddress;

        public string? WorkerSignUptxtAddress
        {
            get { return workerSignUptxtAddress; }
            set { workerSignUptxtAddress = value; }
        }


        private int workerSignUpAge;

        public int WorkerSignUpAge
        {
            get { return workerSignUpAge; }
            set { workerSignUpAge = value; }
        }


        private DateTime workerSignUpBirthday;

        public DateTime WorkerSignUpBirthday
        {
            get { return workerSignUpBirthday; }
            set { workerSignUpBirthday = value; }
        }



        #endregion


        #region EmployerSignUpBindingTexts

        private string? employerSignUptxtName;

        public string? EmployerSignUptxtName
        {
            get { return employerSignUptxtName; }
            set { employerSignUptxtName = value; }
        }


        private string? employerSignUptxtSurname;

        public string? EmployerSignUptxtSurname
        {
            get { return employerSignUptxtSurname; }
            set { employerSignUptxtSurname = value; }
        }


        private string? employerSignUptxtPassword;

        public string? EmployerSignUptxtPassword
        {
            get { return employerSignUptxtPassword; }
            set { employerSignUptxtPassword = value; }
        }


        private string? employerSignUptxtPhone;

        public string? EmployerSignUptxtPhone
        {
            get { return employerSignUptxtPhone; }
            set { employerSignUptxtPhone = value; }
        }


        private string? employerSignUptxtAddress;

        public string? EmployerSignUptxtAddress
        {
            get { return employerSignUptxtAddress; }
            set { employerSignUptxtAddress = value; }
        }


        private int employerSignUpAge;

        public int EmployerSignUpAge
        {
            get { return employerSignUpAge; }
            set { employerSignUpAge = value; }
        }

        private DateTime employerSignUpBirthday;

        public DateTime EmployerSignUpBirthday
        {
            get { return employerSignUpBirthday; }
            set { employerSignUpBirthday = value; }
        }

        #endregion



        /////////// Main Worker View ///////////////

        // this is sign in
        public RelayCommand ShowWorkerMainView
        {
            get => new RelayCommand(() =>
            {
                string json = File.ReadAllText("Workers.json");
                ObservableCollection<Worker>? Workers = JsonConvert.DeserializeObject<ObservableCollection<Worker>>(json);
                
                foreach (var worker in Workers)
                {
                    if (WorkerSignIntxtName == worker.Name && WorkerSignIntxtPassword == worker.Password)
                    {
                        CurrentControl = new WorkerMainView();
                    }
                }
            });
        }

        // this is sign up
        public RelayCommand SignUpShowWorkerMainView
        {
            get => new RelayCommand(() =>
            {
                Worker worker = new Worker() { Name = WorkerSignUptxtName, Surname = WorkerSignUptxtSurname, Password = WorkerSignUptxtPassword, Phone = WorkerSignUptxtPhone, Address = WorkerSignUptxtAddress, Age = WorkerSignUpAge, Birthday = WorkerSignUpBirthday };
                
                WorkersJsonAddNewItem(worker);

                CurrentControl = new WorkerMainView();
            });
        }



        public void WorkersJsonAddNewItem(Worker worker)
        {
            Workers.Add(worker);

            string updatedJson = JsonConvert.SerializeObject(Workers,Formatting.Indented);

            File.WriteAllText("Workers.json", updatedJson);
        }




        /////////// Main Employer View ///////////////

        // this is sign in
        public RelayCommand ShowEmployerMainView
        {
            get => new RelayCommand(() =>
            {
                string json = File.ReadAllText("Employers.json");
                ObservableCollection<Employer>? Employers = JsonConvert.DeserializeObject<ObservableCollection<Employer>>(json);

                foreach (var employer in Employers)
                {
                    if (EmployerSignIntxtName == employer.Name && EmployerSignIntxtPassword == employer.Password)
                    {
                        CurrentControl = new EmployerMainView();
                    }
                }
            });
        }

        // this is sign up
        public RelayCommand SignUpShowEmployerMainView
        {
            get => new RelayCommand(() =>
            {
                Employer employer = new Employer() { Name = EmployerSignUptxtName, Surname = EmployerSignUptxtSurname, Password = EmployerSignUptxtPassword, Phone = EmployerSignUptxtPhone, Age = EmployerSignUpAge, Address = EmployerSignUptxtAddress, Birthday = EmployerSignUpBirthday };
                
                EmployersJsonAddNewItem(employer);

                CurrentControl = new EmployerMainView();

            });
        }


        public void EmployersJsonAddNewItem(Employer employer)
        {
            Employers.Add(employer);

            string updatedJson = JsonConvert.SerializeObject(Employers, Formatting.Indented);

            File.WriteAllText("Employers.json", updatedJson);
        }


        public void VacanciesJsonAddNewItem(Vacancy vacancy)
        {
            Vacancies.Add(vacancy);

            string updatedJson = JsonConvert.SerializeObject(Vacancies, Formatting.Indented);

            File.WriteAllText("Vacancies.json", updatedJson);
        }


        ///////////////////////////////////////////

        //public ObservableCollection<Worker> Workers { get; set; } = new ObservableCollection<Worker>()
        //{
        //    new Worker(){Name = "Togrul",Surname = "Azizli",Password = "1234", Phone = "773780123", Address = "Baku", Age = 18 },
        //    new Worker(){Name = "Elon",Surname = "Musk",Password = "1234", Phone = "8899889988", Address = "New-York", Age = 40 }
        //};




        private ObservableCollection<Worker> workers;

        public ObservableCollection<Worker> Workers
        {
            get { return workers; }
            set { workers = value; }
        }


        





        ///////////////////////////////////////////
        //public ObservableCollection<Employer> Employers { get; set; } = new ObservableCollection<Employer>()
        //{
        //    new Employer(){Name = "Togrul",Surname = "Azizli",Password = "4321", Phone = "773780123", Address = "Baku", Age = 18 },
        //    new Employer(){Name = "Elon",Surname = "Musk",Password = "4321", Phone = "8899889988", Address = "New-York", Age = 40 }
        //};



        private ObservableCollection<Employer> employers;

        public ObservableCollection<Employer> Employers
        {
            get { return employers; }
            set { employers = value; }
        }



        ///////////////////////////////////////////
        //public ObservableCollection<Vacancy> Vacancies { get; set; } = new ObservableCollection<Vacancy>()
        //{
        //    new Vacancy(){Name = "Vacancy 1", Title = "Back end Developer",Salary = 1500,MinExperience = 2, MaxAge = 50,WorkType = "Remoute"},
        //    new Vacancy(){Name = "Vacancy 2", Title = "Front end Developer",Salary = 1000,MinExperience = 3, MaxAge = 55,WorkType = "Freelance"}
        //};



        private ObservableCollection<Vacancy> vacancies;

        public ObservableCollection<Vacancy> Vacancies
        {
            get { return vacancies; }
            set { vacancies = value; }
        }




        ///////////////////////////////////////////

        private Page? page;

        public Page? Page
        {
            get { return page; }
            set { Set(ref page, value); }
        }

        // Worker Main View
        public RelayCommand ShowWorkerCreateCvPage
        {
            get => new RelayCommand(() =>
            {
                Page = new WorkerCreateCvView();
            });
        }

        // not working
        public RelayCommand ShowWorkerShowAllVacancies
        {
            get => new RelayCommand(() =>
            {
                Page = new WorkerShowAllVacanciesView();
            });
        }

        public RelayCommand WorkerBackCommand
        {
            get => new RelayCommand(() =>
            {
                Page = null;
            });
        }






        // Employer Main View
        public RelayCommand ShowEmployerCreateVacancyPage
        {
            get => new RelayCommand(() =>
            {
                Page = new EmployerCreateVacancyView();
            });
        }


        public RelayCommand EmployerBackCommand
        {
            get => new RelayCommand(() =>
            {
                Page = null;
            });
        }


        public RelayCommand ShowEmployerMyVacancies
        {
            get => new RelayCommand(() =>
            {
                Page = new EmployerMyVacanciesView();
            });
        }




        //////////////// Write To Json /////////////////

        // workers write json
        void WriteToFileFromListForWorker(ObservableCollection<Worker> workers)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(workers);
            File.WriteAllText("Workers.json", json);
        }


        // employers write json
        void WriteToFileFromListForEmployers(ObservableCollection<Employer> employers)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(employers);
            File.WriteAllText("Employers.json", json);
        }
        

        // vacancies write json
        void WriteToFileFromListForVacancies(ObservableCollection<Vacancy> vacancies)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(vacancies);
            File.WriteAllText("Vacancies.json", json);
        }


        //////////////////////////////////////////////////////////////
        

       

    }
}
