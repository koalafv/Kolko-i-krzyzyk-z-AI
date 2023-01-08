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
using System.Windows.Shapes;

namespace Kółko_i_krzyżyk
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private int click = 0;

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            click++;
            if (click == 1)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (click == 2)
            {
                this.WindowState = WindowState.Normal;
                click = 0;
            }


        }
        private int counter = 0;
        private bool Your_Turn;
        public void WhoStart()
        {

            Random random = new Random();
            int a = random.Next(0, 2);
            if (a == 1)
            {
                Your_Turn = true;
                Kolejka.Content = "Kolej X";
            }
            else
            {
                Your_Turn = false;
                Kolejka.Content = "Kolej O";
            }
        }
        public void IfWin()
        {

            StartedGame = false;
            Startbtn.Visibility = Visibility.Visible;
            lewagora.Content = "";
            prawagora.Content = "";
            lewysrodek.Content = "";
            srodekgora.Content = "";
            srodek.Content = "";
            prawysrodek.Content = "";
            lewydol.Content = "";
            srodekdol.Content = "";
            prawydol.Content = "";
            lewagora.Background = Brushes.Transparent;
            prawagora.Background = Brushes.Transparent;
            lewysrodek.Background = Brushes.Transparent;
            srodekgora.Background = Brushes.Transparent;
            srodek.Background = Brushes.Transparent;
            prawysrodek.Background = Brushes.Transparent;
            lewydol.Background = Brushes.Transparent;
            srodekdol.Background = Brushes.Transparent;
            prawydol.Background = Brushes.Transparent;
            counter = 0;


        }
        public async void CheckIfWin()
        {

            if (Your_Turn == false)
            {
                Kolejka.Content = "Kolej O";
            }
            else if (Your_Turn == true)
            {
                Kolejka.Content = "Kolej X";
            }

            if (lewagora.Content == "X" || lewagora.Content == "O")
            {
                if (lewagora.Content == lewysrodek.Content && lewydol.Content == lewysrodek.Content)
                {
                    lewagora.Background = Brushes.Green;
                    lewysrodek.Background = Brushes.Green;
                    lewydol.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + lewydol.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();

                }
            }


            if (srodekgora.Content == "X" || srodekgora.Content == "O")
            {
                if (srodekgora.Content == srodekdol.Content && srodekdol.Content == srodek.Content)
                {
                    srodekgora.Background = Brushes.Green;
                    srodekdol.Background = Brushes.Green;
                    srodek.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + srodek.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }


            if (prawagora.Content == "X" || prawagora.Content == "O")
            {
                if (prawagora.Content == prawydol.Content && prawydol.Content == prawysrodek.Content)
                {
                    prawagora.Background = Brushes.Green;
                    prawydol.Background = Brushes.Green;
                    prawysrodek.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawysrodek.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }

            if (lewagora.Content == "X" || lewagora.Content == "O")
            {
                if (lewagora.Content == srodekgora.Content && srodekgora.Content == prawagora.Content)
                {
                    lewagora.Background = Brushes.Green;
                    srodekgora.Background = Brushes.Green;
                    prawagora.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawagora.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }



            if (lewysrodek.Content == "X" || lewysrodek.Content == "O")
            {
                if (lewysrodek.Content == srodek.Content && srodek.Content == prawysrodek.Content)
                {
                    lewysrodek.Background = Brushes.Green;
                    srodek.Background = Brushes.Green;
                    prawysrodek.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawysrodek.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }





            if (lewydol.Content == "X" || lewydol.Content == "O")
            {
                if (lewydol.Content == srodekdol.Content && srodekdol.Content == prawydol.Content)
                {
                    lewydol.Background = Brushes.Green;
                    srodekdol.Background = Brushes.Green;
                    prawydol.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawydol.Content);

                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }



            if (lewagora.Content == "X" || lewagora.Content == "O")
            {
                if (lewagora.Content == srodek.Content && srodek.Content == prawydol.Content)
                {
                    lewagora.Background = Brushes.Green;
                    srodek.Background = Brushes.Green;
                    prawydol.Background = Brushes.Green;

                    MessageBox.Show("Wygrał gracz ktory grał: " + prawydol.Content);


                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }





            if (prawagora.Content == "X" || prawagora.Content == "O")
            {
                if (prawagora.Content == srodek.Content && srodek.Content == lewydol.Content)
                {
                    prawagora.Background = Brushes.Green;
                    srodek.Background = Brushes.Green;
                    lewydol.Background = Brushes.Green;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawagora.Content);
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }
            if (counter == 9)
            {
                MessageBox.Show("REMIS");
                await Task.Delay(TimeSpan.FromSeconds(2));
                IfWin();
            }



        }
        private bool StartedGame = false;
        private void Startbtn_Click(object sender, RoutedEventArgs e)
        {
            WhoStart();
            StartedGame = true;
            Startbtn.Visibility = Visibility.Hidden;

        }
        private void lewagora_Click(object sender, RoutedEventArgs e)
        {
            if (lewagora.Content != "X" && lewagora.Content != "O")
            {
                if (StartedGame == true)
                {
                    if (Your_Turn == true)
                    {
                        lewagora.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                        counter++;
                    }
                    else if (Your_Turn == false)
                    {
                        lewagora.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                        counter++;
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }



        }

        private void srodekgora_Click(object sender, RoutedEventArgs e)
        {
            if (srodekgora.Content != "X" && srodekgora.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        srodekgora.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        srodekgora.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }

        }

        private void prawagora_Click(object sender, RoutedEventArgs e)
        {
            if (prawagora.Content != "X" && prawagora.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        prawagora.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        prawagora.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }
        }

        private void lewysrodek_Click(object sender, RoutedEventArgs e)
        {
            if (lewysrodek.Content != "X" && lewysrodek.Content != "O")
            {

                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        lewysrodek.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        lewysrodek.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }
        }

        private void srodek_Click(object sender, RoutedEventArgs e)
        {
            if (srodek.Content != "X" && srodek.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        srodek.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        srodek.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }


        }

        private void prawysrodek_Click(object sender, RoutedEventArgs e)
        {
            if (prawysrodek.Content != "X" && prawysrodek.Content != "O")
            {

                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        prawysrodek.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        prawysrodek.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }
        }

        private void lewydol_Click(object sender, RoutedEventArgs e)
        {
            if (lewydol.Content != "X" && lewydol.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        lewydol.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        lewydol.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }

            }

        }

        private void srodekdol_Click(object sender, RoutedEventArgs e)
        {
            if (srodekdol.Content != "X" && srodekdol.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        srodekdol.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        srodekdol.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }

        }

        private void prawydol_Click(object sender, RoutedEventArgs e)
        {
            if (prawydol.Content != "X" && prawydol.Content != "O")
            {
                if (StartedGame == true)
                {
                    counter++;
                    if (Your_Turn == true)
                    {
                        prawydol.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    }
                    else if (Your_Turn == false)
                    {
                        prawydol.Content = "O";
                        Your_Turn = true;
                        CheckIfWin();
                    }
                }
                else
                {
                    MessageBox.Show("Wystartuj gre");
                }
            }


        }
    }
}
