using System;
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

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void lst_Loaded(object sender, RoutedEventArgs e)
        {
            lst.Items.Add(new { ADI = "DİLAN", SOYADI = "YILMAZ", NUMARASI = 45464, KATILIM = "11.05.2022" });
            lst.Items.Add(new { ADI = "HATİCE", SOYADI = "ÖZAKAN", NUMARASI = 56234, KATILIM = "18.09.2021" });
            lst.Items.Add(new { ADI = "AHMET", SOYADI = "DEMİR", NUMARASI = 89561, KATILIM = "24.08.2019" });
            lst.Items.Add(new { ADI = "RAHMİ", SOYADI = "SAYLAN", NUMARASI = 40157, KATILIM = "31.02.2022" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lst.Items.Add(new { ADI = txt1.Text, SOYADI = txt3.Text, NUMARASI = (Convert.ToInt32(txt2.Text)), KATILIM = txt4.Text });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lst.Items.Remove(lst.SelectedItem);
        }
        
    }
}
