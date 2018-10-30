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
    /// ClockUserControl.xaml etkileşim mantığı
    /// </summary>
    public partial class ClockUserControl : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();

        public ClockUserControl()
        {
            InitializeComponent();
            timer.Tick += Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            DateTime day;
            day = DateTime.Now;
            int now = short.Parse(day.Hour.ToString());

            if (toggle.Toggled1)
            {
                if (day.Hour > 12)
                {
                    now = now - 12;
                }

                txtSaat.Text = now + ":" + day.Minute + ":" + day.Second;

                txtTarih.Text = day.Day + "/" + day.Month + "/" + day.Year;
            }

            else
            {

                txtSaat.Text = day.Hour + ":" + day.Minute + ":" + day.Second;

                txtTarih.Text = day.Day + "/" + day.Month + "/" + day.Year;

            }

        }
    }

}
