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
    /// Interaction logic for LineUC.xaml
    /// </summary>
    public partial class LineUC : UserControl
    {
        private bool aktive;

        public bool Aktive
        {
            get { return aktive; }
            set
            { aktive = value;

                if (aktive)
                {
                    ColorizeLine(Brushes.Orange);
                }

                else
                {
                    ColorizeLine(Brushes.Gray);
                }

            }
        }




        public void ColorizeLine(Brush color)
        {
            line.Fill = color;
        }

        public LineUC()
        {
            InitializeComponent();
        }
    }
}
