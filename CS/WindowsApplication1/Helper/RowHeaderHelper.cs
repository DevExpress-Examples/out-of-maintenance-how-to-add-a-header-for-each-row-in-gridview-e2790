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
    public class RowHeaderHelper
    {

        private AdvBandedGridView _View;
        BandedGridColumn _Column = new BandedGridColumn();

        private void InitializeColumn(string bandCaption, string caption, FixedStyle fixedStyle)
        {
            GridBand band = _View.Bands.AddBand(bandCaption);
            band.Fixed = fixedStyle;
            _Column.FieldName = "Unbound" + _View.Columns.Count;
            _Column.Caption = caption;
            _Column.UnboundType = DevExpress.Data.UnboundColumnType.String;
            _Column.Visible = true;
            _Column.OptionsColumn.AllowFocus = false;
            _Column.OptionsFilter.AllowFilter = false;
            _Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            _Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            band.Columns.Add(_Column);
        }

        public RowHeaderHelper(AdvBandedGridView view, string bandCaption, string caption, FixedStyle fixedStyle)
        {
            _View = view;
            InitializeColumn(bandCaption, caption, fixedStyle);
            _View.CustomDrawCell += _View_CustomDrawCell;
        }

        void _View_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column != _Column)
                return;
            MyArgs.DrawHeader(e.Cache, e.Column, GetColumnCaption(e.RowHandle), e.Bounds);

        }

        private string GetColumnCaption(int rowHandle)
        {
            return String.Format("Row {0}", rowHandle + 2);
        }
    }
}
