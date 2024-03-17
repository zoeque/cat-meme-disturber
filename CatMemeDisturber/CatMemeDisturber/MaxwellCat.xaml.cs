﻿using System;
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
using System.Windows.Shapes;

namespace CatMemeDisturber
{
    /// <summary>
    /// MaxwellCat.xaml の相互作用ロジック
    /// </summary>
    public partial class MaxwellCat : Window
    {
        public MaxwellCat()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaxwellCat cat = new MaxwellCat(); 
            cat.Show();
        }
    }
}
