﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLNT.GUI;
namespace QLNT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
                Application.Run(new Form1());
           
            
            
        }
    }
}
