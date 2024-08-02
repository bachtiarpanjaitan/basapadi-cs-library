using System;
namespace Basapadi.Datagrid.Types
{
	public class BGridRow
	{
        public string Label { get; set; } = "Data";
        public GridUnitType Width { get; set; } = GridUnitType.Auto;
        public double Span { get; set; } = 1;
        public int Column { get; set; }
        public LayoutOptions HAlign { get; set; } = LayoutOptions.Center;
        public LayoutOptions VAlign { get; set; } = LayoutOptions.Center;

        public BGridRow()
		{
		}
	}
}

