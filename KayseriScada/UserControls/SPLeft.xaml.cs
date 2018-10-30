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

namespace KayseriScada.UserControls
{
    /// <summary>
    /// Interaction logic for SPLeft.xaml
    /// </summary>
    public partial class SPLeft : UserControl
    {
        private bool _isOpenl;
        public bool isOpen
        {
            get => _isOpenl;
            set
            {
                _isOpenl = value;
                if (_isOpenl)
                {
                    

                    OpenSwitchPoint();
                }
                else
                {
                    CloseSwitchPoint();
                }
            }
        }

        Storyboard sb;
        Storyboard sb2;

        private bool control;

        

        public bool Storyboard2
        {
            get { return control; }
            set
            {
                control = value;

              if (control)
                {
                    WarningSignFlash();
                }
              else
                {
                    CloseWarn();
                }

                
            }
        }


        private bool _rota;

        public bool Rota
        {
            get { return _rota; }
            set
            {
                _rota = value;

                if (_rota)
                {
                    ColorizeBottom(Brushes.Orange);
                }



            }
        }

        public void ColorizeBottom(Brush color)
        {
            rotatePathBottomLeft.Fill = color;
            rotatePathBottomRight.Fill = color;
        }



        public void WarningSignFlash()
        {
            xLine.Visibility = Visibility.Visible;
            errorLine.Visibility = Visibility.Visible;
            sb = new Storyboard();
            DoubleAnimation da = new DoubleAnimation();
            da.From = 1;
            da.To = 0;
            da.AutoReverse = true;
            da.RepeatBehavior = RepeatBehavior.Forever;
            sb.Children.Add(da);
            Storyboard.SetTarget(sb, errorLine);
            Storyboard.SetTargetProperty(sb, new PropertyPath(Path.OpacityProperty));


            sb2 = new Storyboard();
            DoubleAnimation da2 = new DoubleAnimation();
            da2.From = 1;
            da2.To = 0;
            da2.AutoReverse = true;
            da2.RepeatBehavior = RepeatBehavior.Forever;
            sb2.Children.Add(da2);
            Storyboard.SetTarget(sb2, xLine);
            Storyboard.SetTargetProperty(sb2, new PropertyPath(Path.OpacityProperty));

            sb.Begin();
            sb2.Begin();
        }

        public void CloseWarn()
        {
            if (sb!=null && sb2 != null)
            {
                sb.Stop();
                sb2.Stop();
                xLine.Visibility = Visibility.Collapsed;
                errorLine.Visibility = Visibility.Collapsed;
            }

          
        }

        public void ShowEnergy()
        {
            energySign.Visibility = Visibility.Visible;


        }

        public void HideEnergy()
        {
            energySign.Visibility = Visibility.Collapsed;

        }

        public void OpenSwitchPoint()
        {

            //if (isOpen)
            //{
            //    return;
            //}

            //else
            {

                DoubleAnimation da = new DoubleAnimation();
                RotateTransform rt = new RotateTransform();
                rotatePath.RenderTransform = rt;
                da.From = -45;
                da.To = 0;
                rt.BeginAnimation(RotateTransform.AngleProperty, da);
                rotatePath.Fill = Brushes.Black;
                rotatePathBottomRight.Fill = Brushes.Green;
                rotatePathBottomLeft.Fill = Brushes.Green;
                rotatePathTop.Fill = Brushes.Black;

            }
        }

        public void CloseSwitchPoint()
        {

            //if (!isOpen)
            //{
            //    return;
            //}

            //else
            {

                DoubleAnimation da = new DoubleAnimation();
                RotateTransform rt = new RotateTransform();
                rotatePath.RenderTransform = rt;
                da.From = 0;
                da.To = -45;
                rt.BeginAnimation(RotateTransform.AngleProperty, da);
                rotatePath.Fill = Brushes.Red;
                rotatePathBottomLeft.Fill = Brushes.Red;
                rotatePathBottomRight.Fill = Brushes.Black;
                rotatePathTop.Fill = Brushes.Red;

            }
        }

      

        public SPLeft()
        {
            InitializeComponent();
        }
    }
}
