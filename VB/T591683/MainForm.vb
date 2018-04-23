Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Filtering
Imports DevExpress.Utils.Filtering.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Filtering
Imports System
Imports System.Data
Imports System.Linq

Namespace T591683
	Partial Public Class MainForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private viewModel As ICollectionValueViewModel(Of String)
		Private items() As CheckedListBoxItem
		Private savedItems() As CheckedListBoxItem
		Private columnName As String = String.Empty

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim dataGenerator As New SampleDataGenerator()
			gridControl1.DataSource = dataGenerator.CreateTable()
			AddHandler gridView1.FilterPopupExcelPrepareTemplate, AddressOf GridView1_FilterPopupExcelPrepareTemplate
			AddHandler gridView1.FilterPopupExcelCustomizeTemplate, AddressOf GridView1_FilterPopupExcelCustomizeTemplate
		End Sub
		Private Sub GridView1_FilterPopupExcelPrepareTemplate(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupExcelPrepareTemplateEventArgs)
			e.Template = New CustomTemplate()
		End Sub

		Private Sub GridView1_FilterPopupExcelCustomizeTemplate(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupExcelCustomizeTemplateEventArgs)
			viewModel = (TryCast((TryCast(e.Template.Parent, FilterUIEditorContainerEdit)).EditValue, ICollectionValueViewModel(Of String)))
			Dim checkedListBoxControl As CheckedListBoxControl = e.GetValuesListBox()
			Dim searchControl As SearchControl = e.GetSearchControl()
			searchControl.Client = checkedListBoxControl
			Dim spinEditControl As SpinEdit = e.GetTemplatedChild(Of SpinEdit)("Part_StringLength")
			savedItems = checkedListBoxControl.Items.ToArray()

            AddHandler spinEditControl.EditValueChanged, Function(s, te) AnonymousMethod1(s, te, e, checkedListBoxControl, spinEditControl)
        End Sub

        Private Function AnonymousMethod1(ByVal s As Object, ByVal te As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FilterPopupExcelCustomizeTemplateEventArgs, ByVal checkedListBoxControl As CheckedListBoxControl, ByVal spinEditControl As SpinEdit) As Boolean
            If e.Column.FieldName <> columnName Then
                items = checkedListBoxControl.Items.ToArray()
                columnName = e.Column.FieldName
            End If
            checkedListBoxControl.BeginUpdate()
            checkedListBoxControl.Items.Clear()
            For i As Integer = 0 To items.Length - 1
                If i = 0 OrElse items(i).Description.Length >= spinEditControl.Value Then
                    checkedListBoxControl.Items.Add(items(i))
                End If
            Next i
            checkedListBoxControl.EndUpdate()
            Return True
        End Function
    End Class
End Namespace
