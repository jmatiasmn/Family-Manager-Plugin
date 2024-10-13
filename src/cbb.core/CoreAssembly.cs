using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// The core assembly helper methods.
    /// </summary>
    public static class CoreAssembly
    {
        #region public methods
        /// <summary>
        /// Gets the core Assembly.
        /// </summary>
        /// <returns></returns>
        public static string GetAssembly()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        #endregion
    }
}
