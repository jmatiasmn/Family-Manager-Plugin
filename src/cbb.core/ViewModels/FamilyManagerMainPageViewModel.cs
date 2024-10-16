using Autodesk.Revit.UI;
using cbb.core;
using cbb.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cbb.core
{
    public class FamilyManagerMainPageViewModel
    {

        #region public properties
        ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.Family;
        #endregion
        #region commands

        /// <summary>
        /// Gets or sets the family page as current.
        /// </summary>
        /// <value>
        /// The family button command
        /// </value>
        public ICommand FamilyBtnCommand { get; set; }

        /// <summary>
        /// Gets or sets the preferences page as current.
        /// </summary>
        /// <value>
        /// The Preferences button command
        /// </value>
        public ICommand PreferencesBtnCommand { get; set; }
        #endregion


        #region constructor
        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="FamilyManagerMainPageViewModel"/>
        /// </summary>
        public FamilyManagerMainPageViewModel()
        {
            FamilyBtnCommand = new RouteCommands(FamilyBtnExecute);
            PreferencesBtnCommand = new RouteCommands(PreferencesBtnExecute);
        }

        #region private methods

        private void FamilyBtnExecute()
        {
            TaskDialog.Show("teste", "teste");
        } private void PreferencesBtnExecute()
        {
            TaskDialog.Show("test2e", "teste2");
        }
        
        #endregion

        #endregion

    }
}
