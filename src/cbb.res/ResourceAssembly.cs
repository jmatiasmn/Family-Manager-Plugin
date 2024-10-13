using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cbb.res
{
    /// <summary>
    /// Resource assembly helper methods
    /// </summary>
    public class ResourceAssembly
    {
        #region public methods

        /// <summary>
        /// Gets the current resource assembly.
        /// </summary>
        /// <returns></returns>
        public static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }

        /// <summary>
        /// Gets the namespace of the current running resource assembly.
        /// </summary>
        /// <returns></returns>
        public static string GetNamespace()
        {
            return typeof(ResourceAssembly).Namespace + ".";
        }

        #endregion
    }
}
