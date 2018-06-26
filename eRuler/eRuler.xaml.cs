using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eRuler
{
    /// <summary>
    /// Interaction logic for eRuler.xaml
    /// </summary>
    public partial class eRuler : UserControl
    {
        public bool IsBorder { get; set; } = true;

        public Color PenColor { get; set; } = Colors.Black;

        public new double BorderThickness { get; set; } = 1.0;

        public eRuler()
        {
            InitializeComponent();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect rectBorder = new Rect(0, 0, this.Width, this.Height);
            Pen pen = new Pen(new SolidColorBrush(PenColor), BorderThickness);
            drawingContext.DrawRectangle(null, pen, rectBorder);
        }
    }
}
