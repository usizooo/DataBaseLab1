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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBaseLab1
{
    /// <summary>
    /// Логика взаимодействия для CatssittersEFPage.xaml
    /// </summary>
    public partial class CatssittersEFPage : Page
    {
        private CatCafeEntities context = new CatCafeEntities();
        public CatssittersEFPage()
        {
            InitializeComponent();
            catsSittersDataGrid.ItemsSource = context.catsitter.ToList();
        }
    }
}

