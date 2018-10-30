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
    /// Interaction logic for TrackCircuitUC.xaml
    /// </summary>
    public partial class TrackCircuitUC : UserControl
    {



        //private bool name;

        //public  bool ChangeName
        //{
        //    get { return name; }
        //    set
        //    {

        //        switch (name)
        //        {
        //            case true: bottomText.Visibility = Visibility.Collapsed;break;
        //            case false: topText.Visibility = Visibility.Collapsed;break;
        //        }

        //    }
        //}

        private string nick;

        public string Nick
        {
            get { return nick; }
            set
            { nick = value;

                topText.Text = nick;

            }
        }



        private bool active;

        public bool Active
        {
            get { return active; }
            set
            { active = value;

                if (active)
                {
                    ColorizeTC(Brushes.Brown);
                }

                else
                {
                    ColorizeTC(Brushes.Gray);
                }

            }
        }


        public void ColorizeTC(Brush color)
        {
            tc.Fill = color;
        }

        public TrackCircuitUC()
        {
            InitializeComponent();
        }
    }
}
