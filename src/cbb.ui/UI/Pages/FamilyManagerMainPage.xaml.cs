using Autodesk.Revit.UI;
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
    /// Interaction logic for FamilyManagerMainPage.xaml
    /// </summary>
    public partial class FamilyManagerMainPage : Page, IDisposable, IDockablePaneProvider
    {
        public FamilyManagerMainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Performs application-defined tasks associated with freein, releasing or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose();
        }
        /// <summary>
        /// Setups the dockable pane.
        /// </summary>
        /// <param name="data"></param>
        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;
            data.InitialState = new DockablePaneState
            {
                DockPosition = DockPosition.Right
            };

        }
    }
}
