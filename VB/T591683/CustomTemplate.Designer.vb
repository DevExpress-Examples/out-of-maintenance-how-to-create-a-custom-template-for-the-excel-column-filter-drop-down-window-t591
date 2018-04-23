Imports Microsoft.VisualBasic
Imports System
Namespace T591683
	Partial Public Class CustomTemplate
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.PART_Values = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.Part_SearchControl = New DevExpress.XtraEditors.SearchControl()
			Me.Part_StringLength = New DevExpress.XtraEditors.SpinEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.PART_Values, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.Part_SearchControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Part_StringLength.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' PART_Values
			' 
			Me.PART_Values.Cursor = System.Windows.Forms.Cursors.Default
			Me.PART_Values.Location = New System.Drawing.Point(12, 36)
			Me.PART_Values.Name = "PART_Values"
			Me.PART_Values.Size = New System.Drawing.Size(260, 120)
			Me.PART_Values.StyleController = Me.layoutControl1
			Me.PART_Values.TabIndex = 0
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.Part_SearchControl)
			Me.layoutControl1.Controls.Add(Me.PART_Values)
			Me.layoutControl1.Controls.Add(Me.Part_StringLength)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(284, 192)
			Me.layoutControl1.TabIndex = 4
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' Part_SearchControl
			' 
			Me.Part_SearchControl.Location = New System.Drawing.Point(12, 12)
			Me.Part_SearchControl.Name = "Part_SearchControl"
			Me.Part_SearchControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
			Me.Part_SearchControl.Size = New System.Drawing.Size(260, 20)
			Me.Part_SearchControl.StyleController = Me.layoutControl1
			Me.Part_SearchControl.TabIndex = 3
			' 
			' textEdit1
			' 
			Me.Part_StringLength.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.Part_StringLength.Location = New System.Drawing.Point(48, 160)
			Me.Part_StringLength.Name = "Part_StringLength"
			Me.Part_StringLength.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.Part_StringLength.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.Part_StringLength.Properties.IsFloatValue = False
			Me.Part_StringLength.Properties.Mask.EditMask = "n0"
			Me.Part_StringLength.Size = New System.Drawing.Size(224, 20)
			Me.Part_StringLength.StyleController = Me.layoutControl1
			Me.Part_StringLength.TabIndex = 1
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(284, 192)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.Part_SearchControl
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(264, 24)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.PART_Values
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(264, 124)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.Part_StringLength
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 148)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(264, 24)
			Me.layoutControlItem3.Text = "Length"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(33, 13)
			' 
			' TestTemplate
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "TestTemplate"
			Me.Size = New System.Drawing.Size(284, 192)
			CType(Me.PART_Values, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.Part_SearchControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Part_StringLength.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private PART_Values As DevExpress.XtraEditors.CheckedListBoxControl
		Private Part_SearchControl As DevExpress.XtraEditors.SearchControl
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private Part_StringLength As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace
