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
using System.IO;
using System.Collections;
using Logging;
using Logging.Facade;
using System.Data;

namespace KayseriScada.UserControls
{
    /// <summary>
    /// Interaction logic for DrawingUI.xaml
    /// </summary>
    public partial class DrawingUI : UserControl
    {
        

        public DrawingUI()
        {
            InitializeComponent();
            dataGridView.ItemsSource = LogORM.Select().DefaultView;

            //switchBottomLeft.MouseDown += delegate { switchBottomLeft.isOpen = !switchBottomLeft.isOpen; };
            //switchTopLeft.MouseDown += delegate { switchTopLeft.isOpen = !switchTopLeft.isOpen; };
            tc1.Nick = "TC 1";
            tc2.Nick = "TC 2";
            tc3.Nick = "TC 3";
            tc4.Nick = "TC 4";
            tc5.Nick = "TC 5";
            tc6.Nick = "TC 6";
            tc7.Nick = "TC 7";
            tc8.Nick = "TC 8";
            tc9.Nick = "TC 9";
            tc10.Nick = "TC 10";
            tc11.Nick = "TC 11";
            tc12.Nick = "TC 12";
            tc13.Nick = "TC 13";
            tc14.Nick = "TC 14";
            tc15.Nick = "TC 15";
            tc16.Nick = "TC 16";
            tc17.Nick = "TC 17";
            tc18.Nick = "TC 18";
            tc19.Nick = "TC 19";
            tc20.Nick = "TC 20";
            
        }


        private int _routeID;

        public int RouteID
        {
            get { return _routeID; }
            set
            { _routeID = value;

                switch (_routeID)
                {
                    case 1: a1Line.Aktive = true; // rota 1
                        tc1Line3.Aktive = true;
                        pm1.Rota = true;
                        tc2Line3.Aktive = true;
                        pm2.Rota = true;
                        tc3Line5.Aktive = true;
                        pm3.Rota = true;
                        tc5Line7.Aktive = true;
                        pm4.Rota = true;
                        tc7Line8.Aktive = true;
                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true;break;

                    case 2: //rota2
                        a2Line.Aktive = true;
                        pm1.Rota = true;
                        tc2Line3.Aktive = true;
                        pm2.Rota = true;
                        tc3Line5.Aktive = true;
                        pm3.Rota = true;
                        tc5Line7.Aktive = true;
                        pm4.Rota = true;
                        tc7Line8.Aktive = true;
                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 3:
                        a3Line.Aktive = true;
                        pm2.Rota = true;
                        tc3Line5.Aktive = true;
                        pm3.Rota = true;
                        tc5Line7.Aktive = true;
                        pm4.Rota = true;
                        tc7Line8.Aktive = true;
                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 4:
                        
                        a4Line.Aktive = true;
                        pm3.Rota = true;
                        tc5Line7.Aktive = true;
                        pm4.Rota = true;
                        tc7Line8.Aktive = true;
                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 5:

                        a5Line.Aktive = true;
                      
                        pm4.Rota = true;
                        tc7Line8.Aktive = true;
                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 6:

                        a6Line.Aktive = true;

                        pm5.Rota = true;
                        tc8Line11.Aktive = true;
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 7:
                        a7Line1.Aktive = true;
                        a7Line2.Aktive = true;
                      
                        pm6.Rota = true;
                        tc11Line13.Aktive = true;
                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;

                    case 8:
                        a8Line1.Aktive = true;
                        a8Line2.Aktive = true;

                        pm7.Rota = true;
                        tc16line15.Aktive = true;
                        pm8.Rota = true;
                        LineFirstTop.Aktive = true; break;
                }


            }
        }

        /*

              I WILL ADD SIGNAL LAMPS AND THE OTHER ISSUES. 


              */

        public void AnalyzeSignal(string byte1, string byte2, string byte3, string byte4, string byte5) {


            // 
            //
            //------------------------------------------------------------------------------------------
            //IF i have more time, i can write more functionality. Sorry it is my bad. I know it is terrible.

            bool[] bit6 = new bool[8];
            bool[] bit7 = new bool[8];
            bool[] bit8 = new bool[8];
            bool[] bit9 = new bool[8];
            bool[] bit10 = new bool[8];


            //int a = 0;
            bit6 = hexToBinary(byte1);
            bit7 = hexToBinary(byte2);
            bit8 = hexToBinary(byte3);
            bit9 = hexToBinary(byte4);
            bit10 = hexToBinary(byte5);


            #region // 1st lamp

            if (bit6[0] ==true && bit6[1]==false && bit6[2]== false && bit6[3] == false)
            {
                sl7.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl7, StatusType.Stop, byte1);
            }

            if (bit6[0] == false && bit6[1] == true && bit6[2] == false && bit6[3] == false)
            {
                sl7.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl7, StatusType.Pass, byte1);
            }

            if (bit6[0] == false && bit6[1] == false && bit6[2] == false && bit6[3] == true)
            {
                sl7.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl7, StatusType.Error, byte1);
            }


            if (bit6[4] == true && bit6[5] == false && bit6[6] == false && bit6[7] == false)
            {
                sl8.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl8, StatusType.Stop, byte1);
            }

            if (bit6[4] == false && bit6[5] == true && bit6[6] == false && bit6[7] == false)
            {
                sl8.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl8, StatusType.Pass, byte1);
            }


            if (bit6[4] == false && bit6[5] == false && bit6[6] == false && bit6[7] == true)
            {
                sl8.RailLampStraight();
                Log.Insert(LogTypes.ERROR, DeviceID.sl8, StatusType.Error, byte1);
            }

            #endregion


            #region //2nd lamp

            if (bit7[0] == true && bit7[1] == false && bit7[2] == false && bit7[3] == false)
            {
                sl5.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl5, StatusType.Stop, byte2);
            }

            if (bit7[0] == false && bit7[1] == true && bit7[2] == false && bit7[3] == false)
            {
                sl5.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl5, StatusType.Pass, byte2);
            }

            if (bit7[0] == false && bit7[1] == false && bit7[2] == false && bit7[3] == true)
            {
                sl5.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl5, StatusType.Error, byte2);
            }



            if (bit7[4] == true && bit7[5] == false && bit7[6] == false && bit7[7] == false)
            {
                sl6.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl6, StatusType.Stop, byte2);
            }

            if (bit7[4] == false && bit7[5] == true && bit7[6] == false && bit7[7] == false)
            {
                sl6.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl6, StatusType.Pass, byte2);
            }


            if (bit7[4] == false && bit7[5] == false && bit7[6] == false && bit7[7] == true)
            {
                sl6.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl6, StatusType.Error, byte2);
            }

            #endregion


            #region // 3rd lamp
            if (bit8[0] == true && bit8[1] == false && bit8[2] == false && bit8[3] == false)
            {
                sl3.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl3, StatusType.Stop, byte3);
            }

            if (bit8[0] == false && bit8[1] == true && bit8[2] == false && bit8[3] == false)
            {
                sl3.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl3, StatusType.Pass, byte3);
            }

            if (bit8[0] == false && bit8[1] == false && bit8[2] == false && bit8[3] == true)
            {
                sl3.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl3, StatusType.Error, byte3);
            }



            if (bit8[4] == true && bit8[5] == false && bit8[6] == false && bit8[7] == false)
            {
                sl4.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl4, StatusType.Stop, byte3);
            }

            if (bit8[4] == false && bit8[5] == true && bit8[6] == false && bit8[7] == false)
            {
                sl4.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl4, StatusType.Pass, byte3);
            }


            if (bit8[4] == false && bit8[5] == false && bit8[6] == false && bit8[7] == true)
            {
                sl4.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl4, StatusType.Error, byte3);
            }

            #endregion

            #region// 4th Lamp

            if (bit9[0] == true && bit9[1] == false && bit9[2] == false && bit9[3] == false)
            {
                sl1.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl1, StatusType.Stop, byte4);
            }

            if (bit9[0] == false && bit9[1] == true && bit9[2] == false && bit9[3] == false)
            {
                sl1.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl1, StatusType.Pass, byte4);
            }

            if (bit9[0] == false && bit9[1] == false && bit9[2] == false && bit9[3] == true)
            {
                sl1.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl1, StatusType.Error, byte4);
            }



            if (bit9[4] == true && bit9[5] == false && bit9[6] == false && bit9[7] == false)
            {
                sl2.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl2, StatusType.Stop, byte4);
            }

            if (bit9[4] == false && bit9[5] == true && bit9[6] == false && bit9[7] == false)
            {
                sl2.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl2, StatusType.Pass, byte4);
            }


            if (bit9[4] == false && bit9[5] == false && bit9[6] == false && bit9[7] == true)
            {
                sl2.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl2, StatusType.Error, byte4);
            }

            #endregion

            #region// 5th Lamp


            if (bit10[0] == true && bit10[1] == false && bit10[2] == false && bit10[3] == false)
            {
                sl9.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl9, StatusType.Stop, byte5);
            }

            if (bit10[0] == false && bit10[1] == true && bit10[2] == false && bit10[3] == false)
            {
                sl9.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl9, StatusType.Pass, byte5);
            }

            if (bit10[0] == false && bit10[1] == false && bit10[2] == false && bit10[3] == true)
            {
                sl9.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl9, StatusType.Error, byte5);
            }



            if (bit10[4] == true && bit10[5] == false && bit10[6] == false && bit10[7] == false)
            {
                sl10.RailLampStop();
                Log.Insert(LogTypes.INFO, DeviceID.sl10, StatusType.Stop, byte5);
            }

            if (bit10[4] == false && bit10[5] == true && bit10[6] == false && bit10[7] == false)
            {
                sl10.RailLampStraight();
                Log.Insert(LogTypes.INFO, DeviceID.sl10, StatusType.Pass, byte5);
            }


            if (bit10[4] == false && bit10[5] == false && bit10[6] == false && bit10[7] == true)
            {
                sl10.RailLampError();
                Log.Insert(LogTypes.ERROR, DeviceID.sl10, StatusType.Error, byte5);
            }


            #endregion

        }  // lamp checking.

        public bool[] hexToBinary(string hexValue)
        {
            #region //Onceki deneme
            //ulong number = UInt64.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            //byte[] bytes = BitConverter.GetBytes(number);

            //string binaryString = string.Empty;
            //foreach (byte singleByte in bytes)
            //{
            //    binaryString += Convert.ToString(singleByte, 2);
            //}

            #endregion


            var padding = hexValue.Length == 1 ? 8 : 4;
           string  binaryString= Convert.ToString(Convert.ToInt32(hexValue, 16), 2).PadLeft(hexValue.Length * padding, '0');

            char[] shift = binaryString.ToCharArray();
            Array.Reverse(shift);
            string useString = new string(shift);

            bool[] binaryArray = new bool[binaryString.Length];
            
            for (int i = 0; i < binaryArray.Length; i++)
            {
                binaryArray[i] =Convert.ToBoolean(Convert.ToInt32(useString.Substring(i, 1)));
            }

            return binaryArray;
        }  // conversion method

        public void ClearLines()
        {
            DataTable table = new DataTable();
            table = LogORM.SelectRoute(74);
            string item;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                item = table.Rows[i]["LineName"].ToString().Trim();
                var element = (LineUC)this.FindName(item);

                if (element!=null && element.GetType() == typeof(LineUC))
                {
                    element.ColorizeLine(Brushes.Black);
                }

            }
        }

        public void AnalyzeRouteFirst(string request)
        {
            bool[] req = new bool[8];
            
            req = hexToBinary(request);
            
            DataTable dt = new DataTable();
            string item;
            int a = 69;
            int b = 61;
            

            for (int i = 0; i < 7; i=i+2)
            {
               if (req[i])
                {
                    dt = LogORM.SelectRoute(a);
                    Log.Insert(LogTypes.INFO, (DeviceID)a, StatusType.Reserved, request);


                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        item = dt.Rows[j]["LineName"].ToString().Trim();
                        var element = (LineUC)this.FindName(item);
                        if (element!=null && element.GetType() == typeof(LineUC))
                        {
                            element.ColorizeLine(Brushes.Blue);
                        }
                    }

                    
                }

                a--;
            }

            for (int i = 1; i < 8; i = i + 2)
            {
                if (req[i])
                {
                    dt = LogORM.SelectRoute(b);
                    Log.Insert(LogTypes.INFO, (DeviceID)b, StatusType.Reserved, request);


                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        item = dt.Rows[j]["LineName"].ToString().Trim();
                        var element = (LineUC)this.FindName(item);
                        if (element != null && element.GetType() == typeof(LineUC))
                        {
                            element.ColorizeLine(Brushes.Blue);
                        }
                    }


                }

               b--;
            }

        } // First Routes


        public void AnalyzeRouteSecond(string request)
        {
            bool[] req = new bool[8];

            req = hexToBinary(request);

            DataTable dt = new DataTable();
            string item;
            int a = 73;
            int b = 65;
            

            for (int i = 0; i < 7; i = i + 2)
            {
                if (req[i])
                {
                    dt = LogORM.SelectRoute(a);
                    Log.Insert(LogTypes.INFO, (DeviceID)a, StatusType.Reserved, request);


                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        item = dt.Rows[j]["LineName"].ToString().Trim();
                        var element = (LineUC)this.FindName(item);
                        if (element != null && element.GetType() == typeof(LineUC))
                        {
                            element.ColorizeLine(Brushes.Blue);
                        }
                    }


                }

                a--;
            }


            for (int i = 1; i < 8; i = i + 2)
            {
                if (req[i])
                {
                    dt = LogORM.SelectRoute(b);
                    Log.Insert(LogTypes.INFO, (DeviceID)b, StatusType.Reserved, request);


                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        item = dt.Rows[j]["LineName"].ToString().Trim();
                        var element = (LineUC)this.FindName(item);
                        if (element != null && element.GetType() == typeof(LineUC))
                        {
                            element.ColorizeLine(Brushes.Blue);
                        }
                    }


                }

                b--;
            }

        }


        public void AnalyzeTC(string value,string value2,string value3,string value4)
        {
            int a = 0;
            bool[] bit11 = new bool[8];
            bool[] bit12 = new bool[8];
            bool[] bit13 = new bool[8];
            bool[] bit26 = new bool[8];

            //int a = 0;
            bit11 = hexToBinary(value);
            bit12 = hexToBinary(value2);
            bit13 = hexToBinary(value3);
            bit26 = hexToBinary(value4);

            for (int i = 0; i < 21; i++)
            {
                var sw1 = (TrackCircuitUC)this.FindName(string.Format("tc" + (i + 9)));
                if (sw1 != null && sw1.GetType() == typeof(TrackCircuitUC))
                {
                    (sw1 as TrackCircuitUC).Active = false;
                }
            }

            for (int i = 0; i <= 7; i++)
            {

                var sw1 = (TrackCircuitUC)this.FindName(string.Format("tc" + (i + 9)));
                if (sw1 != null && sw1.GetType() == typeof(TrackCircuitUC))
                {
                    if (bit11[i])
                    {

                        if (bit26[a]==false && bit26[a+1]==false && bit26[a+2]==true && bit26[a + 3] == false)
                        {
                            (sw1 as TrackCircuitUC).ColorizeTC(Brushes.Orange);
                            Log.Insert(LogTypes.ERROR, (DeviceID)i+9, StatusType.Error, value);
                        }

                        else
                        {
                            (sw1 as TrackCircuitUC).Active = true;
                            Log.Insert(LogTypes.INFO, (DeviceID)i + 9, StatusType.Reserved, value);

                        }

                       
                    }
                    else
                    {
                        (sw1 as TrackCircuitUC).Active = false;
                        Log.Insert(LogTypes.INFO, (DeviceID)i + 9, StatusType.Free, value);
                    }
                }


                var compo = (TrackCircuitUC)this.FindName(string.Format("tc" + (i + 1)));

                if (compo != null && compo.GetType() == typeof(TrackCircuitUC))
                    {
                    if (bit12[i])
                    {

                        if (bit26[a] == false && bit26[a + 1] == false && bit26[a + 2] == true && bit26[a + 3] == false)
                        {
                            (compo as TrackCircuitUC).ColorizeTC(Brushes.Orange);
                            Log.Insert(LogTypes.ERROR, (DeviceID)i + 1, StatusType.Error, value2);
                        }


                        else
                        {

                            (compo as TrackCircuitUC).Active = true;
                            Log.Insert(LogTypes.INFO, (DeviceID)i + 1, StatusType.Reserved, value2);
                        }
                    }
                    else
                    {
                        (compo as TrackCircuitUC).Active = false;
                        Log.Insert(LogTypes.INFO, (DeviceID)i + 1, StatusType.Free, value2);
                    }
                }

                //if (a == 3)
                //{
                //    return;
                //}

                var compo2 = (TrackCircuitUC)this.FindName(string.Format("tc" + (i + 17)));
                if (compo2 != null && compo2.GetType() == typeof(TrackCircuitUC))
                {
                    if (bit13[i])
                    {

                        if (bit26[a] == false && bit26[a + 1] == false && bit26[a + 2] == true && bit26[a + 3] == false)
                        {
                            (compo2 as TrackCircuitUC).ColorizeTC(Brushes.Orange);
                            Log.Insert(LogTypes.ERROR, (DeviceID)i + 17, StatusType.Error, value3);
                        }
                        
                        else
                        {

                            (compo2 as TrackCircuitUC).Active = true;
                            Log.Insert(LogTypes.INFO, (DeviceID)i + 17, StatusType.Reserved, value3);
                        }

                    }
                    else
                    {
                        (compo2 as TrackCircuitUC).Active = false;
                        Log.Insert(LogTypes.INFO, (DeviceID)i + 17, StatusType.Free, value3);
                    }
                }
            }

        } // tc checking

        public void AnalyzePm4(string value)
        {
            bool[] bit8 = new bool[8];
            
            
            bit8 = hexToBinary(value);



            

                #region // 4'e kadar olan pm

                if (bit8[0] == true) //pm1
                {
                    if (bit8[1] == true)
                    {
                        pm1.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm1, StatusType.Error, value);
                    }

                    else
                    {
                        pm1.isOpen = true;

                        pm1.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm1, StatusType.Opened, value);

                }

                }

                else
                {

                    if (bit8[1] == false)
                    {
                        pm1.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm1, StatusType.Error, value);

                }
                    else
                    {
                        pm1.isOpen = false;

                        pm1.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm1, StatusType.Closed, value);
                }

                }
                //---------------------------------------------------

                if (bit8[2] == true)
                {
                    if (bit8[3] == true)
                    {
                        pm2.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm2, StatusType.Error, value);

                }

                    else
                    {
                        pm2.isOpen = true;

                        pm2.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm2, StatusType.Opened, value);
                }

                }

                else
                {

                    if (bit8[3] == false)
                    {
                        pm2.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm2, StatusType.Error, value);

                }
                    else
                    {
                        pm2.isOpen = false;

                        pm2.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm2, StatusType.Closed, value);
                }

                }

                //---------------------------------------------------

                if (bit8[4] == true)
                {
                    if (bit8[5] == true)
                    {
                        pm3.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm3, StatusType.Error, value);

                }

                    else
                    {
                        pm3.isOpen = true;

                        pm3.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm3, StatusType.Opened, value);
                }

                }

                else
                {

                    if (bit8[5] == false)
                    {
                        pm3.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm3, StatusType.Error, value);

                }
                    else
                    {
                        pm3.isOpen = false;

                        pm3.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm3, StatusType.Closed, value);
                }

                }

                //---------------------------------------------------

                if (bit8[6] == true)
                {
                    if (bit8[7] == true)
                    {
                        pm4.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm4, StatusType.Error, value);

                }

                    else
                    {
                        pm4.isOpen = true;

                        pm4.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm4, StatusType.Opened, value);
                }

                }

                else
                {

                    if (bit8[7] == false)
                    {
                        pm4.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm4, StatusType.Error, value);

                }
                    else
                    {
                        pm4.isOpen = false;

                        pm4.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm4, StatusType.Closed, value);
                }

                }

                #endregion // 
                

        
            
        } // pm 0-4 check
        
        public void AnalyzePm8(string value)
        {
            #region// 4-8 pm

            bool[] bit16 = new bool[8];
            bit16 = hexToBinary(value);

            if (bit16[0] == true)
            {
                if (bit16[1] == true)
                {
                    pm5.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm5, StatusType.Error, value);
                }

                else
                {
                    pm5.isOpen = true;
                    pm5.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm5, StatusType.Opened, value);
                }

            }

            else
            {

                if (bit16[1] == false)
                {
                    pm5.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm5, StatusType.Error, value);
                }
                else
                {
                    pm5.isOpen = false;
                    pm5.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm5, StatusType.Closed, value);
                }

            }

            //////////////////////////////////////

            if (bit16[2] == true)
            {
                if (bit16[3] == true)
                {
                    pm6.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm6, StatusType.Error, value);
                }

                else
                {
                    pm6.isOpen = true;
                    pm6.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm6, StatusType.Opened, value);
                }

            }

            else
            {

                if (bit16[3] == false)
                {
                    pm6.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm6, StatusType.Error, value);
                }
                else
                {
                    pm6.isOpen = false;
                    pm6.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm6, StatusType.Closed, value);
                }

            }

            //////////////////////////////////////

            if (bit16[4] == true)
            {
                if (bit16[5] == true)
                {
                    pm7.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm7, StatusType.Error, value);
                }

                else
                {
                    pm7.isOpen = true;
                    pm7.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm7, StatusType.Opened, value);
                }

            }

            else
            {

                if (bit16[5] == false)
                {
                    pm7.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm7, StatusType.Error, value);
                }
                else
                {
                    pm7.isOpen = false;
                    pm7.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm7, StatusType.Closed, value);
                }

            }

            //////////////////////////////////////

            if (bit16[6] == true)
            {
                if (bit16[7] == true)
                {
                    pm8.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm8, StatusType.Error, value);
                }

                else
                {
                    pm8.isOpen = true;
                    pm8.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm8, StatusType.Opened, value);
                }

            }

            else
            {

                if (bit16[7] == false)
                {
                    pm8.Storyboard2 = true;
                    Log.Insert(LogTypes.ERROR, DeviceID.pm8, StatusType.Error, value);
                }
                else
                {
                    pm8.isOpen = false;
                    pm8.Storyboard2 = false;
                    Log.Insert(LogTypes.INFO, DeviceID.pm8, StatusType.Closed, value);
                }

            }

            #endregion
        } // pm 4-8 check

        public void AnalyzeEnergy4(string value1,string value2)
        {
            bool[] en1 = new bool[8];
            bool[] en2 = new bool[8];

            pm5.HideEnergy();
            pm6.HideEnergy();
            pm7.HideEnergy();
            pm8.HideEnergy();

            en1 = hexToBinary(value1);
            en2 = hexToBinary(value2);

            if (en1[0]==true && en1[1]==false && en1[2]==false && en1[3] == false)
            {
                if (en2[0]==true || en2[1] == true)
                {
                    pm5.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm5, StatusType.Energy, value1 + value2);
                }

                 if (en2[2] == true || en2[3] == true)
                {
                    pm6.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm6, StatusType.Energy, value1 + value2);
                }

                if (en2[4] == true || en2[5] == true)
                {
                    pm7.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm7, StatusType.Energy, value1 + value2);
                }

                 if (en2[6] == true || en2[7] == true)
                {
                    pm8.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm8, StatusType.Energy, value1 + value2);
                }

          
                
                
            }
            else
            {
                pm1.HideEnergy();
                pm2.HideEnergy();
                pm3.HideEnergy();
                pm4.HideEnergy();
                return;
            }

        } // energy check 0-4

        public void analyzeEnergy8(string value1,string value2)
        {
            bool[] en1 = new bool[8];
            bool[] en2 = new bool[8];

            pm1.HideEnergy();
            pm2.HideEnergy();
            pm3.HideEnergy();
            pm4.HideEnergy();

            en1 = hexToBinary(value1);
            en2 = hexToBinary(value2);

            if (en1[0] == true && en1[1] == false && en1[2] == false && en1[3] == false)
            {
                if (en2[0] == true || en2[1] == true)
                {
                    pm1.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm1, StatusType.Energy, value1 + value2);
                }

                if (en2[2] == true || en2[3] == true)
                {
                    pm2.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm2, StatusType.Energy, value1 + value2);
                }

                 if (en2[4] == true || en2[5] == true)
                {
                    pm3.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm3, StatusType.Energy, value1 + value2);
                }

                 if (en2[6] == true || en2[7] == true)
                {
                    pm4.ShowEnergy();
                    Log.Insert(LogTypes.INFO, DeviceID.pm4, StatusType.Energy, value1 + value2);
                }

                
            }

            else
            {

                pm1.HideEnergy();
                pm2.HideEnergy();
                pm3.HideEnergy();
                pm4.HideEnergy();
                return;
            }
        } // energy check 4-8

      
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            AnalyzePm4(txt1.Text);
     dataGridView.ItemsSource = LogORM.Select().DefaultView;
            
        }

        private void btnpm2_Click(object sender, RoutedEventArgs e)
        {
            AnalyzePm8(txt2.Text);
           dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

       
        private void btnenergy1_Click(object sender, RoutedEventArgs e)
        {
            AnalyzeEnergy4(txtByte0.Text, txtByte1.Text);
        dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

        private void btnenergy2_Click_1(object sender, RoutedEventArgs e)
        {
            analyzeEnergy8(txtByte2.Text, txtByte3.Text);
    dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

        private void btnbyte11_Click(object sender, RoutedEventArgs e)
        {
            AnalyzeTC(txtbyte11.Text,txtbyte12.Text,txtbyte13.Text,txtbyte26.Text);
           dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

        private void btnRoute_Click(object sender, RoutedEventArgs e)
        {
            //AnalyzeRoute(txtRoute.Text);
        }

        private void btnLamp_Click(object sender, RoutedEventArgs e)
        {
            AnalyzeSignal(txtbyte6.Text, txtbyte7.Text, txtbyte8.Text, txtbyte9.Text, txtbyte10.Text);
          dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

        private void btnRouteRequest_Click(object sender, RoutedEventArgs e)
        {
            
            ClearLines();
            AnalyzeRouteFirst(txtRoute.Text);
            dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }

        private void btnRoute2_Click(object sender, RoutedEventArgs e)
        {
            
            ClearLines();
            AnalyzeRouteSecond(txtRoute2.Text);
            dataGridView.ItemsSource = LogORM.Select().DefaultView;
        }
    }
}
