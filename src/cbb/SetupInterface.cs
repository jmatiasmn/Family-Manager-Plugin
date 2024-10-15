using Autodesk.Revit.UI;
using cbb.core;
using cbb.res;
using cbb.ui.Revit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb
{
    /// <summary>
    /// Setup whole plugins with tabs, panels, buttons,...
    /// </summary>
    public class SetupInterface
    {
        #region constructor
        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="SetupInterface"/>
        /// </summary>
        public SetupInterface()
        {

        }
        #endregion

        #region public methods
        /// <summary>
        /// Initializes all interface elemtns on custom created Revit tab.
        /// </summary>
        /// <param name="app"></param>
        public void Initialize(UIControlledApplication app)
        {
            string tabName = "Circle's BIM Blog";
            app.CreateRibbonTab(tabName);
            #region Panels

            //Create the panels
            RibbonPanel annotateCommandsPanel = app.CreateRibbonPanel(tabName, "Annotation Commands");
            RibbonPanel managerComamandsPanel = app.CreateRibbonPanel(tabName, "Family Manager Commands");

            #endregion


            #region Annotate Panel

            //Populate button data model.
            var TagWallButtonData = new RevitPushButtonDataModel()
            {
                Label = "Tag Wall\nLayers",
                Panel = annotateCommandsPanel,
                Tooltip = "This is some tooltip text, replace it with real one latter",
                IconImageName = "icon_img_32x32.png",
                TooltipImageName = "tooltip_img_320x320.png",
                CommandNamespacePath = TagWallLayersCommand.GetPath()
            };

            PushButton tagWallButton = RevitPushButton.Create(TagWallButtonData);
            #endregion


            #region Manager


            //Populate button data model.
            var familyManagerShowButtonData = new RevitPushButtonDataModel()
            {
                Label = "Show Family\nManager",
                Panel = managerComamandsPanel,
                Tooltip = "This is some tooltip text, replace it with real one latter",
                IconImageName = "show-32.png",
                TooltipImageName = "tooltip_img_320x320.png",
                CommandNamespacePath = ShowFamilyManagerCommand.GetPath()
            };

            PushButton familyManagerShowButton = RevitPushButton.Create(familyManagerShowButtonData);

            var familyManagerHideButtonData = new RevitPushButtonDataModel()
            {
                Label = "Hide Family\nManager",
                Panel = managerComamandsPanel,
                Tooltip = "This is some tooltip text, replace it with real one latter",
                IconImageName = "hide-32.png",
                TooltipImageName = "tooltip_img_320x320.png",
                CommandNamespacePath = HideFamilyManagerCommand.GetPath()
            };

            PushButton familyManagerHideButton = RevitPushButton.Create(familyManagerHideButtonData);







            #endregion
        }
        #endregion
    }
}
