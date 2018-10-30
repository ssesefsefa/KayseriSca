using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Repository;
using log4net.Core;
using log4net.Repository.Hierarchy;
using log4net.Layout;
using System.Windows.Media;
using System.IO;
using Logging.Facade;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Logging
{
    public enum LogTypes
    {
        INFO=1,
        WARN=2,
        ERROR=3,
      
    }


    public enum DeviceID
    {
        tc1=1, // equals in DB (ID) column
        tc2,
        tc3,
        tc4,
        tc5,
        tc6,
        tc7,
        tc8,
        tc9,
        tc10,
        tc11,
        tc12,
        tc13,
        tc14,
        tc15,
        tc16,
        tc17,
        tc18,
        tc19,
        tc20,
        pm1,
        pm2,
        pm3,
        pm4,
        pm5,
        pm6,
        pm7,
        pm8,
        sl1,
        sl2,
        sl3,
        sl4,
        sl5=34,
        sl6=36,
        sl7,
        sl8,
        sl9,
        sl10,
        b1a1=58,
        b1a2,
        b1a3,
        b1a4,
        b1a5,
        b1a6,
        b1a7,
        b1a8,
        b2a1,
        b2a2,
        b2a3,
        b2a4,
        b2a5,
        b2a6,
        b2a7,
        b2a8,


    }
    
    public enum StatusType
    {
        Active=1,
        NonActive=2,
        Error=3,
        Energy=4,
        Opened=5,
        Closed=6,
        Reserved=7,
        Free=8,
        Stop=9,
        Pass=10
    }


    public class Log
    {
        
        public static bool Insert(LogTypes logTypes, DeviceID deviceID, StatusType statusType, string data)
        {
            SqlCommand comand = new SqlCommand("insert into Report (DeviceID,Data,LogTypeID,Time,StatusID) values (@deviceid,@data,@logtypeid,@time,@statusid)", SqlTools.Connection);

            comand.Parameters.AddWithValue("@deviceid", deviceID);
            comand.Parameters.AddWithValue("@data", data);
            comand.Parameters.AddWithValue("@logtypeid", logTypes);
            comand.Parameters.AddWithValue("@time", DateTime.Now);
            comand.Parameters.AddWithValue("@statusid", statusType);

            return SqlTools.ExecuteNonQuery(comand);

        }

        public static void Append (string message, LogTypes logTypes){

            ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date/ %level/ %logger/ %message%newline";
            patternLayout.ActivateOptions();

            FileAppender fileAppender = new FileAppender();
            fileAppender.AppendToFile = true;
            fileAppender.File = "KayseriLog.txt";
            fileAppender.Layout = patternLayout;
            fileAppender.ActivateOptions();
            hierarchy.Root.AddAppender(fileAppender);

            hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;

            switch (logTypes)
            {
                case LogTypes.INFO:
                    log.Info(message);

                    break;
                case LogTypes.WARN:
                    log.Warn(message);

                    break;
                case LogTypes.ERROR:
                    log.Error(message);

                    break;

            }

            fileAppender.Close();



        }


        //public Log(string message,LogTypes logTypes) ////////////// This ctor for file append
        //{
            
        //    ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //    Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

        //    PatternLayout patternLayout = new PatternLayout();
        //    patternLayout.ConversionPattern= "%date/ %level/ %logger/ %message%newline";
        //    patternLayout.ActivateOptions();

        //    FileAppender fileAppender = new FileAppender();
        //    fileAppender.AppendToFile = true;
        //    fileAppender.File = "KayseriLog.txt";
        //    fileAppender.Layout = patternLayout;
        //    fileAppender.ActivateOptions();
        //    hierarchy.Root.AddAppender(fileAppender);

        //    hierarchy.Root.Level = Level.Info;
        //    hierarchy.Configured = true;

        //    switch (logTypes)
        //    {
        //        case LogTypes.INFO: log.Info(message);
                  
        //            break;
        //        case LogTypes.WARN: log.Warn(message);
                   
        //            break;
        //        case LogTypes.ERROR: log.Error(message);

        //            break;
          
        //    }

        //    fileAppender.Close();



        //}

     

        
    }
}
