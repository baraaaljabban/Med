using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test2.Commands;

namespace Test2.ViewModels
{
   public class MainWindowViewModel :ViewModel, INotifyPropertyChanged
    {
        private ViewModel selectedViewModel;

     /*   private bool loaded = false;

        public bool Loaded
        {
            get
            {
                return loaded;
            }
            set
            {
                loaded = value; PropertyChanged(this, new PropertyChangedEventArgs("Loaded"));
            }
        }
        public bool IsLaoding
        {
            get
            {
                return !loaded;
            }
        }
        */

        public ICommand NavigateCommand
        {
            get;
            private set;
        }

        public MainWindowViewModel()
        {
            NavigateCommand = new NavigateCommand(this);
        }

        public ViewModel SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value; PropertyChanged(this, new PropertyChangedEventArgs("SelectedViewModel"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NavigateAsync(FLAGS.MODELS Page)
        {
            //loaded = false;

            Task.Factory.StartNew(() => Navigate(Page)).ContinueWith(
                (task) =>
                {
                    task.Wait();
                    //loaded = true;

                });
        }
        public void Navigate(FLAGS.MODELS Page)
        {
            switch (Page)
            {
                case FLAGS.MODELS.SETTINGS:
                    {
                        SelectedViewModel = new SettingsViewModel();
                        break;
                    }
                case FLAGS.MODELS.PATIANTMANGE:
                    {
                        SelectedViewModel = new PatiantMangeViewModel();
                        break;
                    }
            }
          }

        public override void refreshData()
        {
            throw new NotImplementedException();
        }

        public override void reloadModel()
        {
            throw new NotImplementedException();
        }

        public override bool canSaveEditOrDelete()
        {
            throw new NotImplementedException();
        }

        public override void openAddWindow()
        {
            throw new NotImplementedException();
        }

        public override void openEditWindow()
        {
            throw new NotImplementedException();
        }

        public override void openDeleteWindow()
        {
            throw new NotImplementedException();
        }

        public override void save()
        {
            throw new NotImplementedException();
        }

        public override void delete()
        {
            throw new NotImplementedException();
        }

        public override void closeWindow()
        {
            throw new NotImplementedException();
        }
    }
}
