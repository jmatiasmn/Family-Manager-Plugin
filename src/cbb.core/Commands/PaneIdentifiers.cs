using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Guid container that holds guid references to dockable panes.
    /// </summary>
    public static class PaneIdentifiers
    {

        #region public methods
        /// <summary>
        /// The family manager dockable pane guid.
        /// </summary>
        /// <returns></returns>
        public static Guid ManagerPaneIdentifier()
        {
            return new Guid("D234062C-7AF6-4345-A7A6-78E548514CBC");
        }

        #endregion

    }
}
