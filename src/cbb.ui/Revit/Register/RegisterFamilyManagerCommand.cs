using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using cbb.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cbb.ui
{
    /// <summary>
    /// Register Family Manager in zero state document.
    /// </summary>
    /// [Autodesk.Revit.Attributes.Transaction(TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(RegenerationOption.Manual)]
    public class RegisterFamilyManagerCommand : IExternalCommand
    {
        #region public methods

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Execute(commandData.Application);
            return Result.Succeeded;
        }

        /// <summary>
        /// Register dockable pane
        /// </summary>
        /// <param name="uiApplication">The UIApplication</param>
        /// <returns></returns>
        public Result Execute(UIApplication uiApplication)
        {
            DockablePaneProviderData data = new DockablePaneProviderData();
            FamilyManagerMainPage managerPage = new FamilyManagerMainPage();

            data.FrameworkElement = managerPage as FrameworkElement;

            //Setup initial state.
            DockablePaneState state = new DockablePaneState
            {
                DockPosition = DockPosition.Right
            };

            //User unique guid identifier for this dockable pane.
            DockablePaneId dpId = new DockablePaneId(PaneIdentifiers.ManagerPaneIdentifier());
            uiApplication.RegisterDockablePane(dpId, "FamilyManager", managerPage as IDockablePaneProvider);

            return Result.Succeeded;
        }

        #endregion
    }
}
