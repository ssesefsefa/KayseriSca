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
    /// Interaction logic for RailLampUC.xaml
    /// </summary>
    public partial class RailLampUC : UserControl
    {
        DoubleAnimation da;
        RotateTransform rt;

        //public void RailLampRight()
        //{
        //    Storyboard sb = new Storyboard();
        //    DoubleAnimation da2 = new DoubleAnimation();
        //    DoubleAnimation da = new DoubleAnimation();
        //    RotateTransform rt = new RotateTransform();
        //    line.RenderTransform = rt;


        //    da.To = -45;

        //    da2.From = 1;
        //    da2.From = 0;
        //    da2.RepeatBehavior = RepeatBehavior.Forever;
        //    da2.AutoReverse = true;
        //    sb.Children.Add(da2);

        //    Storyboard.SetTarget(sb, littleElips);
        //    Storyboard.SetTargetProperty(sb, new PropertyPath(Path.OpacityProperty));

        //    rt.BeginAnimation(RotateTransform.AngleProperty, da);
        //    sb.Begin();

        //}

        //public void StopAnimation()
        //{
        //    if (rt!=null && da != null)
        //    {
                
        //    }
        //}

        public void RailLampError() { 
        

            Storyboard sb = new Storyboard();
            DoubleAnimation da2 = new DoubleAnimation();
            da = new DoubleAnimation();
            rt = new RotateTransform();
            line.RenderTransform = rt;

            da.From = 0;
            da.To = 180;
        
             da.AutoReverse= true;
             da.RepeatBehavior=RepeatBehavior.Forever;

            da2.From = 1;
            da2.From = 0;
            da2.RepeatBehavior = RepeatBehavior.Forever;
            da2.AutoReverse = true;
        

            Storyboard.SetTarget(sb, littleElips);
            Storyboard.SetTargetProperty(sb, new PropertyPath(Path.OpacityProperty));

            rt.BeginAnimation(RotateTransform.AngleProperty, da);
            sb.Begin();

        }

        public void RailLampStraight()
        {
            Storyboard sb = new Storyboard();
            DoubleAnimation da2 = new DoubleAnimation();
            DoubleAnimation da = new DoubleAnimation();
            RotateTransform rt = new RotateTransform();
            line.RenderTransform = rt;


            da2.From = 1;
            da2.From = 0;
            da2.RepeatBehavior = RepeatBehavior.Forever;
            da2.AutoReverse = true;
            sb.Children.Add(da2);


            da.To = 90;


            Storyboard.SetTarget(sb, littleElips);
            Storyboard.SetTargetProperty(sb, new PropertyPath(Path.OpacityProperty));

            rt.BeginAnimation(RotateTransform.AngleProperty, da);

            sb.Begin();

        }

        public void RailLampStop()
        {
            Storyboard sb = new Storyboard();
            DoubleAnimation da2 = new DoubleAnimation();
            DoubleAnimation da = new DoubleAnimation();
            RotateTransform rt = new RotateTransform();
            line.RenderTransform = rt;


            da2.From = 1;
            da2.From = 0;
            da2.RepeatBehavior = RepeatBehavior.Forever;
            da2.AutoReverse = true;
            sb.Children.Add(da2);

            da.From = 90;
            da.To = 0;


            Storyboard.SetTarget(sb, littleElips);
            Storyboard.SetTargetProperty(sb, new PropertyPath(Path.OpacityProperty));

            rt.BeginAnimation(RotateTransform.AngleProperty, da);

            sb.Begin();
        }

        public RailLampUC()
        {
            InitializeComponent();
        }
    }
}
