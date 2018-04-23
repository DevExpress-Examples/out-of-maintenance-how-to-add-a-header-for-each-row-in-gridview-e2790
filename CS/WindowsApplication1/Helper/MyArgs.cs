using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Drawing;

namespace WindowsApplication1
{
    public class MyArgs : GridColumnInfoArgs
    {
        public MyArgs(GridColumn column)
            : base(column)
        {

        }
        public MyArgs(GraphicsCache cache, GridColumn column)
            : base(cache, column)
        {

        }


        public static void DrawHeader(GraphicsCache cache, GridColumn column, string caption, Rectangle bounds)
        {
            MyArgs args = new MyArgs(cache, column);
            bounds.Inflate(2, 2);
            args.Bounds = bounds;
            args.Caption = caption;
            bounds.Offset(-bounds.X, -bounds.Y);
            bounds.Height -= 4;
            bounds.X += 1;
            args.CaptionRect = bounds;
            args.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            args.ElementsPainter.Column.DrawObject(args);
        }
    }
}
