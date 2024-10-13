using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace cbb.core
{
    /// <summary>
    /// Interaction logic for TagWallLayersView.xaml
    /// </summary>
    public partial class TagWallLayersView : Window, IDisposable
    {
        #region properties
        /// <summary>
        /// The private reference to the <see cref="UIDocument"/>
        /// </summary>
        private readonly UIDocument uidoc = null;
        /// <summary>
        /// The binding reference to Text Type Note combobox.
        /// </summary>
        public List<TextElementType> TextTypeNote { get; set; }        
        /// <summary>
        /// The binding reference to selected item on TextTypeNote combobox.
        /// </summary>
        public ElementId SelectedTextTypeNoteId { get; set; }
        /// <summary>
        /// The binding reference to unit types combobox.
        /// </summary>
        public List<LengthUnitType> UnitTypes { get; set; }
        /// <summary>
        /// The binding reference to selected item on UnitTypes combobox.
        /// </summary>
        public LengthUnitType SelectedUnitTypes { get; set; }/// <summary>
        /// The binding reference to decimal places combobox.
        /// </summary>
        public List<int> DecimalPlaces { get; set; }
        /// <summary>
        /// The binding reference to selected item on DecimalPlaces combobox.
        /// </summary>
        public int SelectedDecimalPlaces { get; set; }



        #endregion

        #region constructor
        public TagWallLayersView(UIDocument UIDocument)
        {
            InitializeComponent();
            DataContext = this;
            uidoc = UIDocument;
            PopulateTextNoteTypeList();
            PopulateUnitTypesList();
            PopulateDecimalPlaces();
        }

        #endregion

        #region events

        /// <summary>
        /// Handles the Click event of the btnOk control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            //Debug.Print(SelectedDecimalPlaces.ToString() + " " + SelectedUnitTypes);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        #region public methods

        public TagWallLayersCommandData GetInformation()
        {

            TagWallLayersCommandData information = new TagWallLayersCommandData()
            {
                Function = chbFunction.IsChecked.Value,
                Name = chbName.IsChecked.Value,
                Thickness = chbThickness.IsChecked.Value,
                TextTypeId = SelectedTextTypeNoteId,
                Decimals = SelectedDecimalPlaces,
                UnitType = SelectedUnitTypes
            };

            return information;
        }

        public void Dispose()
        {
            this.Close();
        }

        #endregion

        #region private methods

        private void PopulateTextNoteTypeList()
        {
            TextTypeNote = new FilteredElementCollector(uidoc.Document).OfClass(typeof(TextElementType))
                .Cast<TextElementType>().ToList();
        }

        private void PopulateUnitTypesList()
        {
            UnitTypes = Enum.GetValues(typeof(LengthUnitType)).Cast<LengthUnitType>().ToList();
        }

        private void PopulateDecimalPlaces()
        {
            DecimalPlaces = new List<int>
            {
                0,1,2,3
            };
        }


        #endregion
    }
}
