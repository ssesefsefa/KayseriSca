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

namespace KayseriScada.UserControls
{
    /// <summary>
    /// ToggleButton.xaml etkileşim mantığı
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        Thickness leftSide = new Thickness(-39, 0, 0, 0);
        Thickness rightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush offColor = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        SolidColorBrush onColor = new SolidColorBrush(Color.FromRgb(130, 190, 125));

        private bool Toggled = false;

        public ToggleButton()
        {
            InitializeComponent();
            backRect.Fill = offColor;
            Toggled = false;
            Kontrol.Margin = leftSide;

        }

        public bool Toggled1 { get => Toggled; set => Toggled = value; }

        private void Kontrol_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                backRect.Fill = onColor;
                Toggled = true;
                Kontrol.Margin = rightSide;

            }

            else
            {
                backRect.Fill = offColor;
                Toggled = false;
                Kontrol.Margin = leftSide;

            }
        }
    }
}
