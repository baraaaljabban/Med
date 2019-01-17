using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Test2.Models;
using Test2.ViewModels;

namespace Test2.Views
{
    /// <summary>
    /// Interaction logic for PatianView.xaml
    /// </summary>
    public partial class PatianView : Window
    {
        public PatianView(ViewModel parentViewModel , Patiant model = null)
        {
            DataContext = new PatiantViewModel(this, parentViewModel , model);
            InitializeComponent();
        }
    }
}
