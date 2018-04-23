using DevExpress.Utils.Filtering;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Filtering;
using System;
using System.Data;
using System.Linq;

namespace T591683
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ICollectionValueViewModel<string> viewModel;
        CheckedListBoxItem[] items;
        CheckedListBoxItem[] savedItems;
        string columnName = String.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SampleDataGenerator dataGenerator = new SampleDataGenerator();
            gridControl1.DataSource = dataGenerator.CreateTable();
            gridView1.FilterPopupExcelPrepareTemplate += GridView1_FilterPopupExcelPrepareTemplate;
            gridView1.FilterPopupExcelCustomizeTemplate += GridView1_FilterPopupExcelCustomizeTemplate;
        }
        private void GridView1_FilterPopupExcelPrepareTemplate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupExcelPrepareTemplateEventArgs e)
        {
            e.Template = new CustomTemplate();
        }

        private void GridView1_FilterPopupExcelCustomizeTemplate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupExcelCustomizeTemplateEventArgs e)
        {
            viewModel = ((e.Template.Parent as FilterUIEditorContainerEdit).EditValue as ICollectionValueViewModel<string>);
            var checkedListBoxControl = e.GetValuesListBox();
            var searchControl = e.GetSearchControl();
            searchControl.Client = checkedListBoxControl;
            var textBox = e.GetTemplatedChild<SpinEdit>("Part_StringLength");
            savedItems = checkedListBoxControl.Items.ToArray();

            textBox.EditValueChanged += (s, te) =>
            {
                if (e.Column.FieldName != columnName)
                {
                    items = checkedListBoxControl.Items.ToArray();
                    columnName = e.Column.FieldName;
                }

                checkedListBoxControl.BeginUpdate();
                checkedListBoxControl.Items.Clear();
                for (int i = 0; i < items.Length; i++) 
                    if (i == 0 || items[i].Description.Length >= textBox.Value)
                        checkedListBoxControl.Items.Add(items[i]);
                checkedListBoxControl.EndUpdate();
            };
        }
    }
}
