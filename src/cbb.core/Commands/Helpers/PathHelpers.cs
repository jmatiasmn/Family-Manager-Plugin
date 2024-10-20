using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// A helper class that contains functions for dealing with physical files.
    /// </summary>
    public static class PathHelpers
    {
        #region public methods

        /// <summary>
        /// Gets the name of the file from provided full path.
        /// </summary>
        /// <param name="fullFilePath"></param>
        /// <returns></returns>
        public static string GetFileName (string fullFilePath)
        {
            if (string.IsNullOrWhiteSpace(fullFilePath))
                return string.Empty;
            
            //Get the file name
            int lastindex = fullFilePath.LastIndexOf("\\");

            if (lastindex <= 0) return fullFilePath;

            return Path.GetFileName(fullFilePath.Substring(lastindex +1));
        
        
        }


        #endregion

    }
}
