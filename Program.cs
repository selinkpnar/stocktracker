﻿using System;
using System.Windows.Forms;

namespace StockTrackerV4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // LoginForm başlangıç formu
        }
    }
}
