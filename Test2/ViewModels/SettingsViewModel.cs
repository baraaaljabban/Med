using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.DBContext;
using Test2.Models;
using Test2.Services;

namespace Test2.ViewModels
{
   public  class SettingsViewModel : ViewModel, INotifyPropertyChanged
    {
        private static Setting _setting;
        public Setting Setting
        {
            get
            {
                return _setting;
            }
            set
            {
                _setting = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Setting"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public SettingsViewModel()
        {
            _setting = SettingService.LoadSettings();
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
