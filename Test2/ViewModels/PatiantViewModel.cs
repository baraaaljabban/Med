using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Test2.Models;
using Test2.Services;

namespace Test2.ViewModels
{
    class PatiantViewModel : ViewModel, INotifyPropertyChanged
    {
        private Window window;
        private ViewModel parentViewModel;
        private List<Title> TitleList;
        private Patiant model;
        private Title selectedTitle;
        bool add = false;

        public Title SelectedTitle
        {
            get
            {
                return selectedTitle;
            }
            set
            {
                selectedTitle = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedTitle"));
            }
        }


        public Patiant Model
        {
            get { return model; }
            private set { model = value; PropertyChanged(this, new PropertyChangedEventArgs("Model")); }
        }

        public bool Add
        {
            get { return add; }
        }

        public List<Title> TitleList1 { get => TitleList;
            set => TitleList = value; }

        public PatiantViewModel(Window window, ViewModel parentViewModel, Patiant model = null)
        {
            TitleList = TitleService.GetTitles();
            this.window = window;
            this.parentViewModel = parentViewModel;
            if (model == null)
            {
                this.model = new Patiant();
                add = true;
            }
            else
                this.model = model;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public override bool canSaveEditOrDelete()
        {
            return true;
        }

        public override void closeWindow()
        {
            window.Close();
        }

        public override void delete()
        {
            throw new NotImplementedException();
        }

        public override void openAddWindow()
        {
            throw new NotImplementedException();
        }

        public override void openDeleteWindow()
        {
            throw new NotImplementedException();
        }

        public override void openEditWindow()
        {
            throw new NotImplementedException();
        }

        public override void refreshData()
        {
            model.Reload();
        }

        public override void reloadModel()
        {
            throw new NotImplementedException();
        }

        public override void save()
        {
            if (add)
            {
                model.Add();
            }

            else
                model.Edit();

            closeWindow();
            parentViewModel.refreshData();
        }
    }
}
