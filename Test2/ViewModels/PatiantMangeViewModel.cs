using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.Models;
using Test2.Services;
using Test2.Views;

namespace Test2.ViewModels
{
    public class PatiantMangeViewModel : ViewModel, INotifyPropertyChanged
    {
        private IList<Patiant> objects;
        private Patiant selectedObject;
        private PatianView view;

        public Patiant SelectedObject
        {
            get
            {
                return selectedObject;
            }
            set
            {
                selectedObject = value; PropertyChanged(this, new PropertyChangedEventArgs("SelectedObject"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IList<Patiant> Objects
        {
            get { return objects; }
            private set { objects = value; PropertyChanged(this, new PropertyChangedEventArgs("Objects")); }
        }


        public PatiantMangeViewModel()
        {
            // get data
            objects = PatiantService.GetPatiants();
        }

        public override void refreshData()
        {
            objects.Clear();
            objects = PatiantService.GetPatiants();
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
            view = new PatianView(this);
            view.ShowDialog();
                
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
