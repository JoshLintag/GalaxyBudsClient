﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GalaxyBudsClient.Interop.TrayIcon;

#pragma warning disable CS0067

namespace ThePBone.Interop.Linux.TrayIcon
{
    /* TODO: Dummy */
    public class TrayIcon : ITrayIcon
    {
        public event EventHandler<TrayMenuItem>? TrayMenuItemSelected;
        public event EventHandler? LeftClicked;
        public event EventHandler? RightClicked;
        public List<TrayMenuItem> MenuItems { get; set; } = new List<TrayMenuItem>();
        public bool PreferDarkMode { get; set; }
    }
}

