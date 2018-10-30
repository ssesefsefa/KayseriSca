using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KayseriScada.UserControls
{
    /// <summary>
    /// Interaction logic for RFSensorUC.xaml
    /// </summary>
    public partial class RFSensorUC : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        int counter = 1;
        int control = 1;
        
        public void RFSensorColorize()
        {

            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        public void DefaultColor()
        {
            sgnLeft1.Fill = Brushes.Gray;
            sgnLeft2.Fill = Brushes.Gray;
            sgnRight2.Fill = Brushes.Gray;
            sgnRight1.Fill = Brushes.Gray;
            sgnORg.Fill = Brushes.Gray;
        }

        public void FirstSign()
        {
            DefaultColor();
            sgnORg.Fill = Brushes.Yellow;
            counter++;

        }

        public void SeconSign()
        {
            DefaultColor();
            sgnLeft1.Fill = Brushes.Yellow;
            sgnRight1.Fill = Brushes.Yellow; counter++;
        }

        public void ThirdSign()
        {
            DefaultColor();
            sgnLeft2.Fill = Brushes.Yellow;
            sgnRight2.Fill = Brushes.Yellow;
            counter = 1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (control > 26)
            {
                DefaultColor();
                sgnORg.Fill = Brushes.Yellow;
                return;
                
            }


            switch (counter)
            {
                case 1:
                    FirstSign(); break;
                case 2: SeconSign();
                    break;
                case 3:
                    ThirdSign();
                    break;
                default: timer.Stop();break;
            }
            control++;
        }

        public RFSensorUC()
        {
            InitializeComponent();
        }

        private void Mycanvas_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Mycanvas_MouseLeave(object sender, MouseEventArgs e)
        {
           
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            pop.Visibility = Visibility.Visible;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            pop.Visibility = Visibility.Collapsed;
        }
    }
}
