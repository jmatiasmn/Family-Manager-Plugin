using cbb.core;

namespace cbb.ui
{
    /// <summary>
    /// Interaction logic for FamilyPage.xaml
    /// </summary>
    public partial class FamilyPage : BasePage
    {
        public FamilyPage()
        {
            InitializeComponent();
            //List model binded to data context.
            DataContext = new FamilyListViewModel();
        }
    }
}
