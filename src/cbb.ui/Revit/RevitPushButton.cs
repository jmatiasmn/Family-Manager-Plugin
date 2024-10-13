using Autodesk.Revit.UI;
using cbb.core;
using cbb.res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.ui.Revit
{
    /// <summary>
    /// The Revit push button methods.
    /// </summary>
    public static class RevitPushButton
    {
        #region public methods

        /// <summary>
        /// Creates the push button based on data provided in <see cref="RevitPushButtonDataModel"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static PushButton Create(RevitPushButtonDataModel data)
        {
            var btnDataName = Guid.NewGuid().ToString(); //The Button name based on unique identifier.

            PushButtonData btnData = new PushButtonData(btnDataName, data.Label,
                CoreAssembly.GetAssembly(), data.CommandNamespacePath)
            {
                LargeImage = ResourceImage.GetIcon(data.IconImageName),
                ToolTipImage = ResourceImage.GetIcon(data.TooltipImageName)
            };

            return data.Panel.AddItem(btnData) as PushButton;
        }

        #endregion
    }
}
