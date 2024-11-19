using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Represents a type of suported file in family manager list view.
    /// </summary>
    public enum ItemType
    {
        /// <summary>
        /// The Revit project.
        /// </summary>
        Project,
        /// <summary>
        /// The Revit Family.
        /// </summary>
        Family,
        /// <summary>
        /// The cad file, such as .dwg, .dxf
        /// </summary>
        Cad,
        /// <summary>
        /// The document file such as .doc, .docx
        /// </summary>
        Document,
        /// <summary>
        /// The no supported file type.
        /// </summary>
        None
    }
}
