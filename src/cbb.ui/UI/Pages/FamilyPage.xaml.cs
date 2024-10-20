using cbb.core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cbb.ui
{
    /// <summary>
    /// Interaction logic for FamilyPage.xaml
    /// </summary>
    public partial class FamilyPage : Page
    {
        public FamilyPage()
        {
            InitializeComponent();
            //List model binded to data context.
            DataContext = new FamilyListViewModel();
        }
    }
}
