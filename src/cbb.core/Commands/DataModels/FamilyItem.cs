using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Represents a data model for one single family item in list of the items.
    /// </summary>
    public class FamilyItem
    {
        #region public properties
        /// <summary>
        /// Gets or sets the full path to the item.
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// Sets the name of the family item based on FullPath propertie.
        /// </summary>
        public string Name => PathHelpers.GetFileName(FullPath);
        /// <summary>
        /// Gets the type of item based on full path.
        /// </summary>
        public ItemType Type => ItemTypeHelper.GetType(FullPath);

        #endregion

        #region constructor

        /// <summary>
        /// Default consctructor.
        /// </summary>
        public FamilyItem()
        {

        }

        #endregion
    }
}
