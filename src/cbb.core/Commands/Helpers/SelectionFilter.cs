using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class SelectionFilter : ISelectionFilter
    {
        #region private members

        private string mCategory = "";

        #endregion

        #region constructor
        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="SelectionFilter"/>
        /// </summary>
        /// <param name="category"></param>
        public SelectionFilter(string category)
        {
            mCategory = category;
        }

        #endregion

        #region public methods
        /// <summary>
        /// Allows the element selection if provided category is equal to selected one.
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool AllowElement(Element elem)
        {
            if (elem.Category.Name == mCategory)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Allows the reference.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        ///  <exception cref="System.NotImplementedException"></exception>
        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }

        #endregion
    }
}
