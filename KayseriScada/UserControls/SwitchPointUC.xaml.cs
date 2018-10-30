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
    /// Interaction logic for SwitchPointUC.xaml
    /// </summary>
    public partial class SwitchPointUC : UserControl
    {
        //public enum PointMachineSide
        //{
        //    Left,
        //    Right,
        //}


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
            { _rota = value;

                if (_rota)
                {
                    ColorizeBottom(Brushes.Red);
                }



            }
        }


        //public PointMachineSide _pmSide
        //{
        //    get { return (PointMachineSide)GetValue(_pmSideProperty); }
        //    set
        //    {
        //        {
        //            _pmSide = value;
        //            switch (_pmSide)
        //            {
        //                case PointMachineSide.Left:



        //                    rotatePathTop.Data = Geometry.Parse("F1 M 166.302,264.376 C 157.196,260.576 149.000,255.033 142.130,248.163 L 0.000,106.033 L 0.033,0.000 L 195.163,195.130 L 166.302,264.376");
        //                    rotatePath.Data = Geometry.Parse("F1 M 195.163,270.130 L 399.903,270.130 L 399.903,195.130 L 195.163,195.130 L 166.302,264.376 C 175.186,268.083 184.935,270.130 195.163,270.130");
        //                    break;
        //                case PointMachineSide.Right:
        //                    rotatePathTop.Data = Geometry.Parse("F1 M 233.698,264.376 C 242.804,260.576 251.000,255.033 257.870,248.163 L 400.000,106.033 L 399.967,0.000 L 204.837,195.130 L 233.698,264.376");
        //                    rotatePath.Data = Geometry.Parse("F1 M 204.837,270.130 L 0.097,270.130 L 0.097,195.130 L 204.837,195.130 L 233.698,264.376 C 224.814,268.083 215.065,270.130 204.837,270.130");

        //                    break;
        //                default:
        //                    break;
        //            }
        //        };
        //    }
        //}

        // Using a DependencyProperty as the backing store for _pmSide.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty _pmSideProperty =
        //    DependencyProperty.Register("_pmSide", typeof(PointMachineSide), typeof(SwitchPointUC), new PropertyMetadata(0));

        public void ColorizeBottom(Brush color)
        {
            rotatePathBottomLeft.Fill = color;
            rotatePathBottomRight.Fill = color;
        }

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


        public void CloseWarn()
        {
            if (sb != null && sb2 != null)
            {
                sb.Stop();
                sb2.Stop();
                xLine.Visibility = Visibility.Collapsed;
                errorLine.Visibility = Visibility.Collapsed;
            }

        }

        public void WarningSignFlash()
        {
            errorLine.Visibility = Visibility.Visible;
            xLine.Visibility = Visibility.Visible;

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
                da.From = 45;
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
                da.To = 45;
                rt.BeginAnimation(RotateTransform.AngleProperty, da);
                rotatePath.Fill = Brushes.Red;
                rotatePathBottomRight.Fill = Brushes.Red;
                rotatePathBottomLeft.Fill = Brushes.Black;
                rotatePathTop.Fill = Brushes.Red;

            }
        }

        public SwitchPointUC()
        {


            InitializeComponent();
            /*ın functıon ınıtı()
             * 
             *
             */
            //    this.RenderTransform.Changed += RenderTransform_Changed;
        }

        // private void RenderTransform_Changed(object sender, EventArgs e)
        // {
        //     energyScale.ScaleY = -1;
        //}
    }
}
