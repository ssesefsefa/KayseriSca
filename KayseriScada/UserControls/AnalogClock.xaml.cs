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
using System.Windows.Threading;

namespace KayseriScada.UserControls
{
    /// <summary>
    /// AnalogClock.xaml etkileşim mantığı
    /// </summary>
    public partial class AnalogClock : UserControl
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public AnalogClock()
        {
            InitializeComponent();
            dispatcherTimer.Tick += Movement;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void Movement(object sender, EventArgs e)
        {
            secondHand.Angle = DateTime.Now.Second * 6;
            minuteHand.Angle = DateTime.Now.Minute * 6;
            hourHand.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
        }
    }
}
