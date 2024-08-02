using System;
namespace Basapadi.Datagrid.Types
{
	public class BGridHeader
	{
        public string Label { get; set; } = "Header";
        public GridUnitType Width { get; set; } = GridUnitType.Star;
        public double Span { get; set; } = 1;
        public int Row { get; set; } = 1;
        public LayoutOptions HAlign { get; set; } = LayoutOptions.Center;
        public LayoutOptions VAlign { get; set; } = LayoutOptions.Center;
        public Color BackgroundColor { get; set; } = Colors.Gray;

        public BGridHeader()
        {
            
        }
    }
}

