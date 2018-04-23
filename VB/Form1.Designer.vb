Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(548, 454)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView2})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2, Me.gridBand3})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ShowIndicator = False
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.gridColumn1)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 75
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.gridColumn2)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 75
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "ID"
			Me.gridColumn2.FieldName = "ID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "gridBand3"
			Me.gridBand3.Columns.Add(Me.gridColumn3)
			Me.gridBand3.Columns.Add(Me.gridColumn4)
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 150
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Number"
			Me.gridColumn3.FieldName = "Number"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Date"
			Me.gridColumn4.FieldName = "Date"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 454)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	End Class
End Namespace

