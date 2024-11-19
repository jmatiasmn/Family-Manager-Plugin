using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Coteiner class that contains functions for getting file for Family Manager.
    /// </summary>
    public static class ItemTypeHelper
    {
        #region public Methods
        /// <summary>
        /// Gets the type of the item based on the full path to the file.
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static ItemType GetType(string fullPath)
        {
            //Check if provided full path is valid.
            if (string.IsNullOrEmpty(fullPath))
                return ItemType.None;
            if (fullPath.Contains(".rvt") || fullPath.Contains(".rte"))
                return ItemType.Project;
            else if (fullPath.Contains(".rfa"))
                return ItemType.Family;
            else if (fullPath.Contains(".dwg") || fullPath.Contains(".dxf") || fullPath.Contains(".sat"))
                return ItemType.Cad;
            else if (fullPath.Contains(".doc") || fullPath.Contains(".docx") || fullPath.Contains(".pdf")
                || fullPath.Contains(".txt") || fullPath.Contains(".csv"))
                return ItemType.Document;
            else
                return ItemType.None;

        }
        #endregion
    }
}
