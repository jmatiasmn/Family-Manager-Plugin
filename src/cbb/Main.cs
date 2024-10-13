using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
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
    }
}
