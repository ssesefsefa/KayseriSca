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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace KayseriScada.UserControls
{
    /// <summary>
    /// Interaction logic for PopupUC.xaml
    /// </summary>
    public partial class PopupUC : UserControl
    {
        public PopupUC()
        {
            InitializeComponent();
           
        }

        public void FlashPopup()
        {

            
            popup.Visibility = Visibility.Visible;
            DoubleAnimation da = new DoubleAnimation();
            Storyboard sb = new Storyboard();

            da.From = 1;
            da.To = 0;
            da.Duration = new TimeSpan(0, 0, 15);


            sb.Children.Add(da);
            Storyboard.SetTarget(sb, popup);
            Storyboard.SetTargetProperty(sb, new PropertyPath(Canvas.OpacityProperty));

           
            sb.Begin();

           
        }

        private void txtExit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            popup.Visibility = Visibility.Collapsed;
        }
    }
}
