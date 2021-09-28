using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CreditTransferApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {   
        
        double U1Credit = 20;        
        double U2Credit = 20;

        public MainPage()
        {
            this.InitializeComponent();

            updateCredit();      
        }

        private void btnTransferU1_Click(object sender, RoutedEventArgs e)
        {
            transferCredit(1);
        }

        private void btnAddU1_Click(object sender, RoutedEventArgs e)
        {
            addCredit(1);
        }

        private void btnRemoveU1_Click(object sender, RoutedEventArgs e)
        {
            removeCredit(1);
        }

        private void btnTransferU2_Click(object sender, RoutedEventArgs e)
        {
            transferCredit(2);
        }

        private void btnAddU2_Click(object sender, RoutedEventArgs e)
        {
            addCredit(2);
        }

        private void btnRemoveU2_Click(object sender, RoutedEventArgs e)
        {
            removeCredit(2);
        }

        public void transferCredit(int user)
        {
            if(user == 1)
            {
                double amount = double.Parse(txtBoxAmountU1.Text);
                U1Credit -= amount;
                U2Credit += amount;
            }
            else
            {
                double amount = double.Parse(txtBoxAmountU2.Text);
                U2Credit -= amount;
                U1Credit += amount;
            }
            updateCredit();
        }

        public void addCredit(int user)
        {
            if (user == 1)
            {
                double amount = double.Parse(txtBoxAmountU1.Text);
                U1Credit += amount;
            }
            else
            {
                double amount = double.Parse(txtBoxAmountU2.Text);
                U2Credit += amount;
            }
            updateCredit();
        }

        public void removeCredit(int user)
        {
            if (user == 1)
            {
                double amount = double.Parse(txtBoxAmountU1.Text);
                U1Credit -= amount;
            }
            else
            {
                double amount = double.Parse(txtBoxAmountU2.Text);
                U2Credit -= amount;
            }
            updateCredit();
        }

        public void updateCredit()
        {
            txtBlockCreditU1.Text = U1Credit.ToString();
            txtBlockCreditU2.Text = U2Credit.ToString();
        }
    }
}
