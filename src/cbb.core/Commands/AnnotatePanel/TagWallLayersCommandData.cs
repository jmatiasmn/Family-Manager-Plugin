using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Information and data model for command <see cref="TagWallLayersCommand"/> to execute.
    /// </summary>
    public class TagWallLayersCommandData
    {
        #region properties
        /// <summary>
        /// Gets or sets value indicating wheter this <see cref="TagWallLayersCommandData"/> should display layer function information.
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Function { get; set; }
        /// <summary>
        /// Gets or sets value indicating wheter this <see cref="TagWallLayersCommandData"/> should display layer name information.
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Name { get; set; }
        /// <summary>
        /// Gets or sets value indicating wheter this <see cref="TagWallLayersCommandData"/> should display layer function information.
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public bool Thickness { get; set; }
        /// <summary>
        /// Gets or sets the text type identifier <see cref="ElementId"/>
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public ElementId TextTypeId { get; set; }
        /// <summary>
        /// Gets or sets the text type identifier <see cref="ElementId"/>
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public LengthUnitType UnitType { get; set; }
        /// <summary>
        /// Gets or sets the text type identifier <see cref="ElementId"/>
        /// </summary>
        /// <value>
        ///     <c>true</c> if function; otherwise, <c>false</c>.
        /// </value>
        public int Decimals { get; set; }

        #endregion

        #region constructor

        public TagWallLayersCommandData()
        {

        }

        #endregion


    }
}
