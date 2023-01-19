using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace GrafikaZadanie4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                BitmapI.Source = Convert(bitmap);
            }

        }

        public BitmapImage Convert(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            src.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        private static int clamp255(int val) => Math.Clamp(val, 0, 255);

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int RNumber = color.R + System.Convert.ToInt32(RR.Text);
                    int GNumber = color.G + System.Convert.ToInt32(GG.Text);
                    int BNumber = color.B + System.Convert.ToInt32(BB.Text);

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int RNumber = color.R - System.Convert.ToInt32(RR.Text);
                    int GNumber = color.G - System.Convert.ToInt32(GG.Text);
                    int BNumber = color.B - System.Convert.ToInt32(BB.Text);

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int RNumber = color.R * System.Convert.ToInt32(RR.Text);
                    int GNumber = color.G * System.Convert.ToInt32(GG.Text);
                    int BNumber = color.B * System.Convert.ToInt32(BB.Text);

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int RNumber = color.R / System.Convert.ToInt32(RR.Text);
                    int GNumber = color.G / System.Convert.ToInt32(GG.Text);
                    int BNumber = color.B / System.Convert.ToInt32(BB.Text);

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);
                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int AddColor = System.Convert.ToInt32(RR.Text);
                    int RNumber = color.R + AddColor;
                    int GNumber = color.G + AddColor;
                    int BNumber = color.B + AddColor;

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int SubstractColor = System.Convert.ToInt32(RR.Text);
                    int RNumber = color.R - SubstractColor;
                    int GNumber = color.G - SubstractColor;
                    int BNumber = color.B - SubstractColor;

                    RNumber = clamp255(RNumber);
                    GNumber = clamp255(GNumber);
                    BNumber = clamp255(BNumber);

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int RNumber1 = color.R;
                    int RNumber2 = color.R;
                    int RNumber3 = color.R;

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber1, RNumber2, RNumber3);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap bitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(i, j);
                    int GNumber1 = color.G;
                    int GNumber2 = color.G;
                    int GNumber3 = color.G;

                    System.Drawing.Color newColor = System.Drawing.Color.FromArgb(GNumber1, GNumber2, GNumber3);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            BitmapI.Source = Convert(bitmap);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap oldBitmap = new Bitmap(bitmapImage.StreamSource);
            Bitmap newBitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < oldBitmap.Width; i++)
            {
                for (int j = 0; j < oldBitmap.Height; j++)
                {
                    if ((i == 0 && i != oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i == 0 && i != oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i == 0 && i != oldBitmap.Width - 1) && (j != 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j != 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i != oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i != oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel7 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel8 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel9 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R + pixel7.R + pixel8.R + pixel9.R) / 9;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G + pixel7.G + pixel8.G + pixel9.G) / 9;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B + pixel7.B + pixel8.B + pixel9.B) / 9;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                }
            }
            BitmapI.Source = Convert(newBitmap);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage = (BitmapImage)BitmapI.Source;
            Bitmap oldBitmap = new Bitmap(bitmapImage.StreamSource);
            Bitmap newBitmap = new Bitmap(bitmapImage.StreamSource);
            for (int i = 0; i < oldBitmap.Width; i++)
            {
                for (int j = 0; j < oldBitmap.Height; j++)
                {
                    if ((i == 0 && i != oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j + 1);
                        List<int> listR = new List<int>();
                        List<int> listG = new List<int>();
                        List<int> listB = new List<int>();
                        for(int k=0; k< 4; k++)
                        {
                        }
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i == 0 && i != oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R) / 4;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G) / 4;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B) / 4;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i == 0 && i != oldBitmap.Width - 1) && (j != 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i == oldBitmap.Width - 1) && (j != 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i != oldBitmap.Width - 1) && (j == 0 && j != oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else if ((i != 0 && i != oldBitmap.Width - 1) && (j != 0 && j == oldBitmap.Height - 1))
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i + 1, j);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R) / 6;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G) / 6;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B) / 6;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        System.Drawing.Color pixel1 = oldBitmap.GetPixel(i - 1, j - 1);
                        System.Drawing.Color pixel2 = oldBitmap.GetPixel(i - 1, j);
                        System.Drawing.Color pixel3 = oldBitmap.GetPixel(i - 1, j + 1);
                        System.Drawing.Color pixel4 = oldBitmap.GetPixel(i, j - 1);
                        System.Drawing.Color pixel5 = oldBitmap.GetPixel(i, j);
                        System.Drawing.Color pixel6 = oldBitmap.GetPixel(i, j + 1);
                        System.Drawing.Color pixel7 = oldBitmap.GetPixel(i + 1, j - 1);
                        System.Drawing.Color pixel8 = oldBitmap.GetPixel(i + 1, j);
                        System.Drawing.Color pixel9 = oldBitmap.GetPixel(i + 1, j + 1);
                        int RNumber = (pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel5.R + pixel6.R + pixel7.R + pixel8.R + pixel9.R) / 9;
                        int GNumber = (pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel5.G + pixel6.G + pixel7.G + pixel8.G + pixel9.G) / 9;
                        int BNumber = (pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel5.B + pixel6.B + pixel7.B + pixel8.B + pixel9.B) / 9;
                        System.Drawing.Color newColor = System.Drawing.Color.FromArgb(RNumber, GNumber, BNumber);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                }
            }
            BitmapI.Source = Convert(newBitmap);
        }
    }
}

