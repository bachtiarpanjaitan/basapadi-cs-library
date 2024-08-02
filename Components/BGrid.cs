using Basapadi.Datagrid.Types;

namespace Basapadi.Datagrid.Components
{
	public class BGrid : Grid
	{
        private Grid _grid = new();
        private List<BGridColumn> _columns = new();
        private List<BGridRow> _rows = new();
        private List<BGridHeader> _headers = new();

        public BGrid()
		{

		}

		public static void Initialize()
		{

        }

        public void SetColumns(List<BGridColumn> columns)
        {
            if (_headers.Count > 0)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    var cdef = new ColumnDefinition { Width = new GridLength(columns[i].Span, columns[i].Width) };
                    _grid.ColumnDefinitions.Add(cdef);

                    var item = CreateCell(columns[i]);
                    _grid.Add(item, i, columns[i].Row);

                }
            }
        }

        public void SetColumn(BGridColumn column)
        {
            _grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(column.Span, column.Width),
            });
        }

        public void SetHeader(List<BGridHeader> columns)
        {
            if (columns.Count > 0)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    var cdef = new ColumnDefinition {
                        Width = new GridLength(columns[i].Span,columns[i].Width),
                    };
                    _grid.ColumnDefinitions.Add(cdef);

                    var item = CreateCell(columns[i]);
                    _grid.Add(item, i, columns[i].Row);

                }
            }
        }

        private static Frame CreateCell(BGridColumn row)
        {
            return new Frame
            {
                Content = new Label { Text = row.Label, VerticalOptions = row.VAlign, HorizontalOptions = row.HAlign },
                BorderColor = Colors.Black,
                BackgroundColor = Colors.Transparent,
                HasShadow = false,
                CornerRadius = 0,
                Padding = 5
            };
        }

        private Frame CreateCell(BGridHeader row)
        {
            return new Frame
            {
                Content = new Label { Text = row.Label, VerticalOptions = row.VAlign, HorizontalOptions = row.HAlign },
                BorderColor = Colors.Black,
                BackgroundColor = row.BackgroundColor,
                HasShadow = false,
                CornerRadius = 0,
                Padding = 5
            };
        }

        //private void GenerateData()
        //{
        //    if (_rows.Count > 0)
        //    {
        //        for (int i = 0; i < _columns.Count; i++)
        //        {
        //            var item = CreateCell(_columns[i]);
        //            _grid.Add(item, i, _columns[i].Row);
        //        }
        //    }
        //}

        public Grid Build()
        {

            //GenerateHeader();
            return _grid;
        }
	}
}

