using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Electrical;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Text;

namespace cbb.core
{
    /// <summary>
    /// Command code to be executed when button is clicked.
    /// </summary>
    [Autodesk.Revit.Attributes.Transaction(TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(RegenerationOption.Manual)]
    public class TagWallLayersCommand : IExternalCommand
    {
        /// <summary>
        /// Tag Wall layers by creating text note element on user specified point and populate it with layer information.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            TagWallLayersCommandData userInfo;
            XYZ point;

            using (var w = new TagWallLayersView(uidoc))
            {
                w.ShowDialog();

                userInfo = w.GetInformation();

            };

            // check if we are in the Revit project, not in family one.
            if (doc.IsFamilyDocument)
            {
                Message.Display("Can't use command in familly document", WindowType.Warning);
                return Result.Cancelled;
            }

            View activeView = uidoc.ActiveView; // Get acess to current view

            // Check if Text Note can be created in currently active project view.
            bool canCreateTextNoteInView = false;

            switch (activeView.ViewType)
            {
                case ViewType.FloorPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.CeilingPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Detail:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Section:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Elevation:
                    canCreateTextNoteInView = true;
                    break;
                default:
                    break;
            }

            if (!canCreateTextNoteInView)
            {
                Message.Display("Text Note element can't be created in the current view", WindowType.Error);
                return Result.Cancelled;
            }


            // Ask user to select one basic wall
            Reference selectionReference = uidoc.Selection
                .PickObject(ObjectType.Element, "Select one basic wall.");
            Wall wallSelected = doc.GetElement(selectionReference) as Wall;

            // Check if wall is type of basic wall.
            if (wallSelected.IsStackedWall)
            {
                Message.Display("Wall you selected is category of the Stacked Wall.\nIt's not supported by this command", WindowType.Warning);
                return Result.Cancelled;
            }

            //Acess list of wall layers;
            IList<CompoundStructureLayer> layers = wallSelected.WallType.
                GetCompoundStructure().GetLayers();

            //Get layer information in structured string format for Text note.
            StringBuilder msg = new StringBuilder();

            foreach (CompoundStructureLayer layer in layers)
            {
                Material material = doc.GetElement(layer.MaterialId) as Material;

                if (userInfo.Function)
                {
                    msg.Append(layer.Function.ToString());
                }
                if (userInfo.Name)
                {
                    msg.Append(" " + material.Name);
                }
                if (userInfo.Function)
                {
                    msg.Append(" " + LengthUnitConverter.ConvertToMetric(layer.Width,userInfo.UnitType,userInfo.Decimals).ToString());
                }
                msg.AppendLine();
            }

            //Create Text Note Options.
            TextNoteOptions opt = new TextNoteOptions()
            {
                VerticalAlignment = VerticalTextAlignment.Top,
                HorizontalAlignment = HorizontalTextAlignment.Left,
                TypeId = userInfo.TextTypeId
            };

            //Open Revit document transaction to creatte new Text Note element.

            using (Transaction t = new Transaction(doc))
            {
                t.Start("Tag Wall Layers Command");

                if (activeView.ViewType == ViewType.Elevation || activeView.ViewType == ViewType.Section)
                {
                    Plane plane = Plane.CreateByNormalAndOrigin(activeView.ViewDirection, activeView.Origin);
                    SketchPlane sketchPlane = SketchPlane.Create(doc, plane);
                    activeView.SketchPlane = sketchPlane;
                    point = uidoc.Selection.PickPoint("Pick text note location point.");
                }
                else
                {
                    point = uidoc.Selection.PickPoint("Pick text note location point.");
                }

                var textNote = TextNote.Create(doc, activeView.Id, point, msg.ToString(), opt);
                t.Commit();
            }
            return Result.Succeeded;
        }

        /// <summary>
        /// Gets the full namespace path to this command.
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            return typeof(TagWallLayersCommand).Namespace + "." + nameof(TagWallLayersCommand);
        }
    }
}
