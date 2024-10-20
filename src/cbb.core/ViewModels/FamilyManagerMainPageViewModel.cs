using Autodesk.Revit.UI;
using cbb.core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cbb.core
{
    public class FamilyManagerMainPageViewModel :BaseViewModel
    {

        #region public properties

        public ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.Family;
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
            FamilyBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Family);
            PreferencesBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Preferences);
        }

        #endregion

    }
}
