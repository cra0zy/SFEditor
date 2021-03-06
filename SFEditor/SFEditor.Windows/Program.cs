﻿using System;
using Xwt;

namespace SFEditor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Settings.Init(Platform.Windows, ToolkitType.Wpf, new[] { ToolkitType.Gtk, ToolkitType.Wpf });
            Application.Initialize(Settings.GetToolkit());

            var window = new MainWindowBase(args);
            window.Show();

            Application.Run();
        }
    }
}
