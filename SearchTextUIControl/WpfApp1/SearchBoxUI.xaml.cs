﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SearchTextUIControl
{
    /// <summary>
    /// Interaction logic for SearchBoxUI.xaml
    /// </summary>
    public partial class SearchBoxUI : UserControl
    {
        public string Images { get; set; }

        public bool showSearch { get; set; }

        public bool showDelete { get; set; }
        public SearchBoxUI()
        {
            InitializeComponent();
        }

    }
}
