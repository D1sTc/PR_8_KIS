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

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для LicenseAgreement.xaml
    /// </summary>
    public partial class LicenseAgreement : Window
    {
        public LicenseAgreement()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void downloadButton_Click(object sender, RoutedEventArgs e)
        {

            // установка файла по нажатию на кнопку в папку "Загрузки".

        //string fileName = "Лицензионное соглашение.txt";

        //string filePath = Server.MapPath(строка.format("~/Files/{0}", fileName));

        //Response.ContentType = "приложение/pdf";
        //Response.AppendHeader("Content-Disposition", "attachment; имя_файла=" + имяФайла);

        //Response.WriteFile(filePath);
        //Response.Flush();
        //Response.End();
        }
    }
}
