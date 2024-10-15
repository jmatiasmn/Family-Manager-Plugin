using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using cbb.ui;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace cbb
{
    /// <summary>
    /// Plugin's main entry point.
    /// </summary>
    public class Main : IExternalApplication
    {
        #region External Application public methods
        /// <summary>
        /// Called when Revit starts up.
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnStartup(UIControlledApplication application)
        {
            SetupInterface setupInterface = new SetupInterface();
            setupInterface.Initialize(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }


        /// <summary>
        /// Called when Revit shutdown.
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        #endregion
        #region private methods

        private void DockablePaneRegisters(object sender, ApplicationInitializedEventArgs e)
        {
            RegisterFamilyManagerCommand familyManagerRegisterCommand = new RegisterFamilyManagerCommand();
            familyManagerRegisterCommand.Execute(new UIApplication(sender as Application));
        }
        #endregion
    }
}
