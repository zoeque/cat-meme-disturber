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
using System.Windows.Shapes;

namespace CatMemeDisturber
{
    /// <summary>
    /// Goat.xaml の相互作用ロジック
    /// </summary>
    public partial class Goat : Window
    {
        public Goat()
        {
            InitializeComponent();
        }

        private bool isDragging = false;
        private Point anchorPoint;

        private void OperationArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.isDragging = true;
            this.anchorPoint = e.GetPosition(this);
            this.MouseMove += OperationArea_MouseMove;
            this.MouseLeftButtonUp += OperationArea_MouseLeftButtonUp;
        }

        private void OperationArea_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.isDragging = false;
            this.MouseMove -= OperationArea_MouseMove;
            this.MouseLeftButtonUp -= OperationArea_MouseLeftButtonUp;
        }

        private void OperationArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isDragging)
            {
                Point currentPoint = e.GetPosition(this);
                this.Left += currentPoint.X - this.anchorPoint.X;
                this.Top += currentPoint.Y - this.anchorPoint.Y;
            }
        }
    }
}
