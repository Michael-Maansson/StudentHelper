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

namespace StudentHelper {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Controller.Controller _controller;
        public MainWindow() {
            InitializeComponent();
            _controller = new Controller.Controller();

            WeekDropdown.SelectedIndex = 0;
            foreach (string _week in _controller.GetWeeks())
            {
                WeekDropdown.Items.Add(_week);
            }
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            new EventWindow(WeekDropdown.SelectedItem.ToString()).Show();
        }
    }
}
