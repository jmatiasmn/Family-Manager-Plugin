using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.ui.Revit
{
    /// <summary>
    /// Represents Revit push button data model
    /// </summary>
    public class RevitPushButtonDataModel
    {
        #region properties
        /// <summary>
        /// Gets or sets the label of the button
        /// </summary>
        /// <value>
        /// The Label
        /// </value>
        public string Label { get; set; }
        /// <summary>
        /// Gets or sets the panel on wich button is hosted.
        /// </summary>
        /// <value>
        /// The panel.
        /// </value>
        public RibbonPanel Panel { get; set; }
        /// <summary>
        /// Gets or sets the command namespace path.
        /// </summary>
        /// <value>
        /// The command namespace path.
        /// </value>
        public string CommandNamespacePath { get; set; }
        /// <summary>
        /// Gets or sets the the tooltip.
        /// </summary>
        /// <value>
        /// The Tooltip
        /// </value>
        public string Tooltip { get; set; }
        /// <summary>
        /// Gets or sets the name of the icon image.
        /// </summary>
        /// <value>
        /// The name of the icon image.
        /// </value>
        public string IconImageName { get; set; }
        /// <summary>
        /// Gets or sets the name of the tooltip image.
        /// </summary>
        /// <value>
        /// The Tooltip image.
        /// </value>
        public string TooltipImageName { get; set; }

        #endregion

        #region constructor
        public RevitPushButtonDataModel()
        {

        }

        #endregion


        #region public methods

        #endregion



    }
}
