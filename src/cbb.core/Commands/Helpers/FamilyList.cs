using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// Get the items from the repository
    /// </summary>
    public static class FamilyList
    {
        #region public methods

        public static List<FamilyItem> GetItems(string path)
        {
            var items = new List<FamilyItem>();

            try
            {
                var fs = Directory.GetFiles(path);

                if (fs.Length > 0)
                {
                    items.AddRange(
                        fs.Select(
                            f => new FamilyItem { FullPath = f }
                            )
                        );
                }


            }
            catch { }
            return items;
        }

        #endregion
    }
}
