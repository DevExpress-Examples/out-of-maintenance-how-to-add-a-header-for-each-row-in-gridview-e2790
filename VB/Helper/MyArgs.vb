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
	Public Class MyArgs
		Inherits GridColumnInfoArgs
		Public Sub New(ByVal column As GridColumn)
			MyBase.New(column)

		End Sub
		Public Sub New(ByVal cache As GraphicsCache, ByVal column As GridColumn)
			MyBase.New(cache, column)

		End Sub


		Public Shared Sub DrawHeader(ByVal cache As GraphicsCache, ByVal column As GridColumn, ByVal caption As String, ByVal bounds As Rectangle)
			Dim args As New MyArgs(cache, column)
			bounds.Inflate(2, 2)
			args.Bounds = bounds
			args.Caption = caption
			bounds.Offset(-bounds.X, -bounds.Y)
			bounds.Height -= 4
			bounds.X += 1
			args.CaptionRect = bounds
			args.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			args.ElementsPainter.Column.DrawObject(args)
		End Sub
	End Class
End Namespace
