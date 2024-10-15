using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using cbb.core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    // <summary>
    /// Hide Family Manager dockable pane.
    /// </summary>
    [Autodesk.Revit.Attributes.Transaction(TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(RegenerationOption.Manual)]
    public class HideFamilyManagerCommand : IExternalCommand
    {
        #region public methods
        /// <summary>
        /// Executes the specified comand data.
        /// </summary>
        /// <param name="commandData">The command data.</param>
        /// <param name="message">The message.</param>
        /// <param name="elements">The elements.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            DockablePaneId dpId = new DockablePaneId(PaneIdentifiers.ManagerPaneIdentifier());
            var dp = commandData.Application.GetDockablePane(dpId);
            dp.Show();
            return Result.Succeeded;
        }

        /// <summary>
        /// Gets the full namespace path to this command.
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            return typeof(HideFamilyManagerCommand).Namespace + "." + nameof(HideFamilyManagerCommand);
        }

        #endregion
    }
}
