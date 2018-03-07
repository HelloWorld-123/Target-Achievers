using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void GridViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage1));
        }
        //phy
        private void grdPlace1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App15.BlankPage3));
        }
        //chem
        private void grdPlace2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App15.BlankPage5));
        }

        private void grdHistory_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage4));
        }
        //coaching
        private void grdHotel1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage5));
        }
        //exam notification
        private void grdName2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage6));
        }
        //maths
        private void maths_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App15.BlankPage6));
        }
        //collg
        private void collg_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage2));
        }
        //xpert
        private void xprt_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BasicPage3));
        }

        private void comb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App15.BlankPage1));
        }

        
        

       
    }
}
