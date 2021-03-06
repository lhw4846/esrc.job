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

using mshtml;
using System.Text.RegularExpressions;


namespace ESRC.JOB
{
    /// <summary>
    /// pageWeb.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class pageWeb : Page
    {
        public pageWeb()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            myBrowser.Navigate(new Uri("http://www.social-eq.co.kr/movie/intro.do"));

        }

        private void myBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            //MessageBox.Show("현재 URL : " + e.Uri.ToString());
                        
            if (e.Uri.ToString() == "http://www.social-eq.co.kr/movie/testft_start.do")
            {
                NavigationService.Navigate(new Uri("pageLocal.xaml", UriKind.Relative));
            }
        }

        private void myBrowser_Navigated(object sender, NavigationEventArgs e)
        {
            //mshtml.IHTMLDocument3 document = (mshtml.IHTMLDocument3)myBrowser.Document;
            //var user_email = document.getElementsByName("login_email")
            //                .OfType<IHTMLElement>()
            //                .Select(element => element.getAttribute("value"))
            //                .FirstOrDefault();

            //MessageBox.Show("현재 사용자 : " + user_email);


            //var document = myBrowser.Document as mshtml.HTMLDocument;
            //var inputs = document.getElementsByTagName("input");
            //MessageBox.Show(document.title);
            
            
                        
         
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(@"img\ppg.jpg", UriKind.Relative);
            b.EndInit();

            // ... Get Image reference from sender.
            var image = sender as Image;
            // ... Assign Source.
            image.Source = b;
        }

        private void Image_Loaded_1(object sender, RoutedEventArgs e)
        {
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(@"img\cam.jpg", UriKind.Relative);
            b.EndInit();

            // ... Get Image reference from sender.
            var image = sender as Image;
            // ... Assign Source.
            image.Source = b;
        }

        
    }
}
