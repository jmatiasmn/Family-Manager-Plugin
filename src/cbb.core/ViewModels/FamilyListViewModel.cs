using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    public class FamilyListViewModel : BaseViewModel
    {

        #region private members
        /// <summary>
        /// The path list to directories with items.
        /// Todo implement in preferences system for chosing directory 
        /// Todo Get familys from cloud server (azure,aws,etc.)
        /// </summary>
        private List<string> _paths = new List<string>
        {
            @"D:\Engenharia\FamiliasBIM"
        };

        #endregion

        #region public properties

        /// <summary>
        /// Gets or sets the items for the list view
        /// </summary>
        public ObservableCollection<FamilyItem> Items{ get; set; }

        #endregion

        #region constructor
        /// <summary>
        /// Default constructor.
        /// </summary>
        public FamilyListViewModel()
        {
            Items = Populate(_paths);

        }


        #endregion

        #region private methods

        /// <summary>
        /// Populates the list with items from provided folder paths.
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        private ObservableCollection<FamilyItem> Populate(List<string> paths)
        {
            var items = new ObservableCollection<FamilyItem>();

            foreach (string path in paths)
            {
                //Get family items from repository
                var children = FamilyList.GetItems(path);

                //Add them to collection.
                foreach (var child in children)
                {
                    items.Add(child);
                }
            }

            return items;
        }

        #endregion

    }
}
