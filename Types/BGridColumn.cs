using System;
namespace Basapadi.Datagrid.Types
{
	public class BGridColumn
	{

        public string Label { get; set; } = "Column";
        public GridUnitType Width { get; set; } = GridUnitType.Auto;
        public double Span { get; set; } = 1;
        public int Row { get; set; }
        public LayoutOptions HAlign { get; set; } = LayoutOptions.Center;
        public LayoutOptions VAlign { get; set; } = LayoutOptions.Center;

        public BGridColumn(int? row = 1)
		{
			Initialize(row);
		}

        private void Initialize(int? row)
		{
            this.Row = row ?? 1;

        }
    }
}

