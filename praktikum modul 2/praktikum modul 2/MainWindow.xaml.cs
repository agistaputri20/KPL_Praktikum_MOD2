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


namespace praktikum_modul_2
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

        float hitung, rumus; 
        int ulang;

        private void simbol__Click(object sender, RoutedEventArgs e) // tombol untuk menambah - Agista Hidayatillah - 1302201140
        {
            hitung = float.Parse(keluaran.Text);
            keluaran.Text = "";
            ulang = 2;
        }

        private void simbol_1_Click(object sender, RoutedEventArgs e) // tombol untuk menjumlah - Agista Hidayatillah - 1302201140
        {
            pertambahan(ulang);
        }

        public void pertambahan(int count) // fungsi untuk menghitung - Agista Hidayatillah - 1302201140
        {
            rumus = hitung + float.Parse(keluaran.Text);
            keluaran.Text = rumus.ToString();

        }

        private void ke0_Click(object sender, RoutedEventArgs e) // tombol angka 0 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "0";
        }

        private void ke1_Click(object sender, RoutedEventArgs e) // tombol angka 1 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "1";
        }

        private void ke2_Click(object sender, RoutedEventArgs e) // tombol angka 2 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "2";
        }

        private void ke3_Click(object sender, RoutedEventArgs e) // tombol angka 3 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "3";
        }

        private void ke4_Click(object sender, RoutedEventArgs e) // tombol angka 4 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "4";
        }

        private void ke5_Click(object sender, RoutedEventArgs e) // tombol angka 5 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "5";
        }

        private void ke6_Click(object sender, RoutedEventArgs e) // tombol angka 6 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "6";
        }

        private void ke7_Click(object sender, RoutedEventArgs e) // tombol angka 7 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "7";
        }

        private void ke8_Click(object sender, RoutedEventArgs e) // tombol angka 8 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "8";
        }

        private void ke9_Click(object sender, RoutedEventArgs e) // tombol angka 9 - Agista Hidayatillah - 1302201140
        {
            keluaran.Text = keluaran.Text + "9";
        }

        private void keluaran_TextChanged(object sender, TextChangedEventArgs e) // untuk menampilkan hasil - Agista Hidayatillah - 1302201140
        {

        }
    }
}
