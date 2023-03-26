using Boss_az_Task.Models;
using Boss_az_Task.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Boss_az_Task.ViewModels
{
    internal class WorkerCreateCvViewModel : MainViewModel
    {

        #region WorkerCreateCvBindingText

        private string? workerCreateCvtxtSpeciality;

        public string? WorkerCreateCvtxtSpeciality
        {
            get { return workerCreateCvtxtSpeciality; }
            set { workerCreateCvtxtSpeciality = value; }
        }


        private string? workerCreateCvtxtUniversity;

        public string? WorkerCreateCvtxtUniversity
        {
            get { return workerCreateCvtxtUniversity; }
            set { workerCreateCvtxtUniversity = value; }
        }



        private string[]? workerCreateCvtxtSkills;

        public string[]? WorkerCreateCvtxtSkills
        {
            get { return workerCreateCvtxtSkills; }
            set { workerCreateCvtxtSkills = value; }
        }



        private string[]? workerCreateCvtxtCompanies;

        public string[]? WorkerCreateCvtxtCompanies
        {
            get { return workerCreateCvtxtCompanies; }
            set { workerCreateCvtxtCompanies = value; }
        }


        private string[]? workerCreateCvtxtLanguages;

        public string[]? WorkerCreateCvtxtLanguages
        {
            get { return workerCreateCvtxtLanguages; }
            set { workerCreateCvtxtLanguages = value; }
        }



        private string? workerCreateCvtxtGitLink;

        public string? WorkerCreateCvtxtGitLink
        {
            get { return workerCreateCvtxtGitLink; }
            set { workerCreateCvtxtGitLink = value; }
        }



        private string? workerCreateCvtxtLinkedin;

        public string? WorkerCreateCvtxtLinkedin
        {
            get { return workerCreateCvtxtLinkedin; }
            set { workerCreateCvtxtLinkedin = value; }
        }



        #endregion


        public RelayCommand WorkerCreateCvOkCommand
        {
            get => new RelayCommand(() =>
            {
                CV cv = new CV() { Specialty = WorkerCreateCvtxtSpeciality, University = WorkerCreateCvtxtUniversity, Skills = WorkerCreateCvtxtSkills, Companies = WorkerCreateCvtxtCompanies, Languages = WorkerCreateCvtxtLanguages, GitLink = WorkerCreateCvtxtGitLink, Linkedin = workerCreateCvtxtLinkedin };

                MessageBox.Show(cv.University);
            });
        }

    }
}
