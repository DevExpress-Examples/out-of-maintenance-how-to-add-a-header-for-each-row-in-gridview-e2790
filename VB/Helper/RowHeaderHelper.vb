Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Drawing

Namespace WindowsApplication1
	Public Class RowHeaderHelper

		Private _View As AdvBandedGridView
		Private _Column As New BandedGridColumn()

		Private Sub InitializeColumn(ByVal bandCaption As String, ByVal caption As String, ByVal fixedStyle As FixedStyle)
			Dim band As GridBand = _View.Bands.AddBand(bandCaption)
			band.Fixed = fixedStyle
			_Column.FieldName = "Unbound" & _View.Columns.Count
			_Column.Caption = caption
			_Column.UnboundType = DevExpress.Data.UnboundColumnType.String
			_Column.Visible = True
			_Column.OptionsColumn.AllowFocus = False
			_Column.OptionsFilter.AllowFilter = False
			_Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			_Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			band.Columns.Add(_Column)
		End Sub

		Public Sub New(ByVal view As AdvBandedGridView, ByVal bandCaption As String, ByVal caption As String, ByVal fixedStyle As FixedStyle)
			_View = view
			InitializeColumn(bandCaption, caption, fixedStyle)
			AddHandler _View.CustomDrawCell, AddressOf _View_CustomDrawCell
		End Sub

		Private Sub _View_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If e.Column IsNot _Column Then
				Return
			End If
			MyArgs.DrawHeader(e.Cache, e.Column, GetColumnCaption(e.RowHandle), e.Bounds)

		End Sub

		Private Function GetColumnCaption(ByVal rowHandle As Integer) As String
			Return String.Format("Row {0}", rowHandle + 2)
		End Function
	End Class
End Namespace
