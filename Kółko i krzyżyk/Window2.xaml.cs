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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            int Licznik = 0;
            InitializeComponent();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Licznik++;
                    array[i, j] = Licznik;

                }

            }
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
                counter++;
                AI_System();
                Your_Turn = false;
                
            }
        }
        public async void IfWin()
        {
            this.Close();
           
         
        }
       
        public void Brak_algorytu()
        {

            for (int a = 0; a < 100; a++)
            {

                Random random = new Random();
                int rnd = random.Next(0, 10);
                
                if (rnd == 1)
                {
                    if (lewagora.Content != "X" && lewagora.Content != "O")
                    {
                        lewagora.Content = "O";
                        array[0, 0] = 98;   //98=O;
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 2)
                {
                    if (srodekgora.Content != "X" && srodekgora.Content != "O")
                    {
                        srodekgora.Content = "O";
                        array[0, 1] = 98;   //98=O;
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 3)
                {
                    if (prawagora.Content != "X" && prawagora.Content != "O")
                    {
                        prawagora.Content = "O";
                        array[0, 2] = 98;   //98=O;
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 4)
                {
                    if (lewysrodek.Content != "X" && lewysrodek.Content != "O")
                    {
                        lewysrodek.Content = "O";
                        a = 120;
                        array[1, 0] = 98;   //98=O;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 5)
                {
                    if (srodek.Content != "X" && srodek.Content != "O")
                    {
                        srodek.Content = "O";
                        array[1, 1] = 98;   //98=O;
                        a = 120;
                       
                        Your_Turn = true;
                    }
                }
                else if (rnd == 6)
                {
                    if (prawysrodek.Content != "X" && prawysrodek.Content != "O")
                    {
                        prawysrodek.Content = "O";
                        array[1, 2] = 98;   //98=O;
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 7)
                {
                    if (lewydol.Content != "X" && lewydol.Content != "O")
                    {
                        lewydol.Content = "O";
                        array[2, 0] = 98;   //98=O;
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 8)
                {
                    if (srodekdol.Content != "X" && srodekdol.Content != "O")
                    {
                        array[2, 1] = 98;   //98=O;
                        srodekdol.Content = "O";
                        a = 120;
                        Your_Turn = true;
                    }
                }
                else if (rnd == 9)
                {
                    if (prawydol.Content != "X" && prawydol.Content != "O")
                    {
                        array[2,2] = 98;   //98=O;
                        prawydol.Content = "O";
                        a = 120;
                        Your_Turn = true;
                    }
                }

            }
        }
      
        private int[,] array = new int[3, 3];
        public void AI_System()
        {
            int arek = 2;
         
            //OFENSE
            for (int i = 0; i < 3; i++)
            {
                // MessageBox.Show(array[i, 0].ToString() + " " + array[i, 1].ToString()+" "+array[i, 2].ToString());
                if (array[i, 0] == array[i, 1] && array[i, 0] == 98 && array[i, 2] != 99 && array[i, 2] != 98)
                {
                    array[i, 2] = 98;
                    if (i == 0)
                    {
                        prawagora.Content = "O";
                        arek = 1;
                    }
                    else if (i == 1)
                    {
                        prawysrodek.Content = "O";
                        arek = 1;
                    }
                    else if (i == 2)
                    {
                        prawydol.Content = "O";
                        arek = 1;
                    }

                }

                else if (array[i, 0] == array[i, 2] && array[i, 0] == 98 && array[i, 1] != 99 && array[i, 1] != 98)
                {
                    array[i, 1] = 98;
                    if (i == 0)
                    {
                        srodekgora.Content = "O";
                        arek = 1;
                    }
                    else if (i == 1)
                    {
                        srodek.Content = "O";
                        arek = 1;
                    }
                    else if (i == 2)
                    {
                        srodekdol.Content = "O";
                        arek = 1;
                    }
                }
                else if (array[i, 1] == array[i, 2] && array[i, 1] == 98 && array[i, 0] != 99 && array[i, 0] != 98)
                {
                    array[i, 0] = 98;
                    if (i == 0)
                    {
                        lewagora.Content = "O";
                        arek = 1;
                    }
                    else if (i == 1)
                    {
                        lewysrodek.Content = "O";
                        arek = 1;
                    }
                    else if (i == 2)
                    {
                        lewydol.Content = "O";
                        arek = 1;
                    }
                }
            }

            if (arek == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    // MessageBox.Show(array[i, 0].ToString() + " " + array[i, 1].ToString()+" "+array[i, 2].ToString());
                    if (array[0, i] == array[1, i] && array[0, i] == 98 && array[2, i] != 99 && array[2, i] != 98)
                    {
                        array[2, i] = 98;
                        if (i == 0)
                        {
                            lewydol.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodekdol.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawydol.Content = "O";
                            arek = 1;
                        }

                    }
                    else if (array[0, i] == array[2, i] && array[0, i] == 98 && array[1, i] != 99 && array[1, i] != 98)
                    {
                        array[1, i] = 98;
                        if (i == 0)
                        {
                            lewysrodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawysrodek.Content = "O";
                            arek = 1;
                        }

                    }
                    else if (array[1, i] == array[2, i] && array[1, i] == 98 && array[0, i] != 99 && array[0, i] != 98)
                    {
                        array[0, i] = 98;
                        if (i == 0)
                        {
                            lewagora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodekgora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawagora.Content = "O";
                            arek = 1;
                        }

                    }

                }
            }


            //Diagonals
            if(arek==2)
            {
                if (array[0, 0] == array[1, 1] && array[1, 1] == 98 && array[2, 2] != 99 && array[2, 2] != 98)
                {

                    array[2, 2] = 98;
                    prawydol.Content = "O";
                    arek = 1;
                }
                else if (array[2, 2] == array[1, 1] && array[1, 1] == 98 && array[0, 0] != 99 && array[0, 0] != 98)
                {

                    array[0, 0] = 98;
                    lewagora.Content = "O";
                    arek = 1;
                }
                else if (array[2, 2] == array[0, 0] && array[0, 0] == 98 && array[1, 1] != 99 && array[1, 1] != 98)
                {

                    array[1, 1] = 98;
                    srodek.Content = "O";
                    arek = 1;
                }
            }
            if (arek == 2)
            {
                if (array[0, 2] == array[1, 1] && array[1, 1] == 98 && array[2, 0] != 99 && array[2, 0] != 98)
                {

                    array[2, 0] = 98;
                    lewydol.Content = "O";
                    arek = 1;
                }
                else if (array[2, 0] == array[1, 1] && array[1, 1] == 98 && array[0, 2] != 99 && array[0, 2] != 98)
                {

                    array[0, 2] = 98;
                    prawagora.Content = "O";
                    arek = 1;
                }
                else if (array[2, 0] == array[0, 2] && array[0, 2] == 98 && array[1, 1] != 99 && array[1, 1] != 98)
                {

                    array[1, 1] = 98;
                    srodek.Content = "O";
                    arek = 1;
                }
            }


            //DEFENSE
            if (arek == 2)
            {
                if (array[0, 0] == array[1, 1] && array[1, 1] == 99 && array[2, 2] != 99 && array[2, 2] != 98)
                {

                    array[2, 2] = 98;
                    prawydol.Content = "O";
                    arek = 1;
                }
                else if (array[2, 2] == array[1, 1] && array[1, 1] == 99 && array[0, 0] != 99 && array[0, 0] != 98)
                {

                    array[0, 0] = 98;
                    lewagora.Content = "O";
                    arek = 1;
                }
                else if (array[2, 2] == array[0, 0] && array[0, 0] == 99 && array[1, 1] != 99 && array[1, 1] != 98)
                {

                    array[1, 1] = 98;
                    srodek.Content = "O";
                    arek = 1;
                }
            }
            if (arek == 2)
            {
                if (array[0, 2] == array[1, 1] && array[1, 1] == 99 && array[2, 0] != 99 && array[2, 0] != 98)
                {

                    array[2, 0] = 98;
                    lewydol.Content = "O";
                    arek = 1;
                }
                else if (array[2, 0] == array[1, 1] && array[1, 1] == 99 && array[0, 2] != 99 && array[0, 2] != 98)
                {

                    array[0, 2] = 98;
                    prawagora.Content = "O";
                    arek = 1;
                }
                else if (array[2, 0] == array[0, 2] && array[0, 2] == 99 && array[1, 1] != 99 && array[1, 1] != 98)
                {

                    array[1, 1] = 98;
                    srodek.Content = "O";
                    arek = 1;
                }
            }

            if (arek==2)
            {
                for (int i = 0; i < 3; i++)
                {
                    // MessageBox.Show(array[i, 0].ToString() + " " + array[i, 1].ToString()+" "+array[i, 2].ToString());
                    if (array[0, i] == array[1, i] && array[0,i] == 99 && array[2, i] != 99 && array[2, i] != 98)
                    {
                        array[2,i] = 98;
                        if (i == 0)
                        {
                            lewydol.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodekdol.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawydol.Content = "O";
                            arek = 1;
                        }

                    }
                    else if (array[0, i] == array[2, i] && array[0, i] == 99 && array[1, i] != 99 && array[1, i] != 98)
                    {
                        array[1, i] = 98;
                        if (i == 0)
                        {
                            lewysrodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawysrodek.Content = "O";
                            arek = 1;
                        }

                    }
                    else if (array[1, i] == array[2, i] && array[1, i] == 99 && array[0, i] != 99 && array[0, i] != 98)
                    {
                        array[0, i] = 98;
                        if (i == 0)
                        {
                            lewagora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodekgora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawagora.Content = "O";
                            arek = 1;
                        }

                    }

                }
            }

            if(arek==2)
            {
                for (int i = 0; i < 3; i++)
                {
                    // MessageBox.Show(array[i, 0].ToString() + " " + array[i, 1].ToString()+" "+array[i, 2].ToString());
                    if (array[i, 0] == array[i, 1] && array[i, 0] == 99 && array[i, 2] != 99 && array[i, 2] != 98)
                    {
                        array[i, 2] = 98;
                        if (i == 0)
                        {
                            prawagora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            prawysrodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            prawydol.Content = "O";
                            arek = 1;
                        }

                    }

                    else if (array[i, 0] == array[i, 2] && array[i, 0] == 99 && array[i, 1] != 99 && array[i, 1] != 98)
                    {
                        array[i, 1] = 98;
                        if (i == 0)
                        {
                            srodekgora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            srodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            srodekdol.Content = "O";
                            arek = 1;
                        }
                    }
                    else if (array[i, 1] == array[i, 2] && array[i, 1] == 99 && array[i, 0] != 99 && array[i, 0] != 98)
                    {
                        array[i, 0] = 98;
                        if (i == 0)
                        {
                            lewagora.Content = "O";
                            arek = 1;
                        }
                        else if (i == 1)
                        {
                            lewysrodek.Content = "O";
                            arek = 1;
                        }
                        else if (i == 2)
                        {
                            lewydol.Content = "O";
                            arek = 1;
                        }
                    }
                }
            }


            if (arek == 2)
            {
                
                Brak_algorytu();
                
            }
            counter++;
            /*
                        */



            /*if (array[0,0]==1 && array[0, 0] == array[0, 1] && a==0)
            {
                if (prawagora.Content != "X" && prawagora.Content != "O")
                {
                    prawagora.Content = "O";
                    a = 1;
                Your_Turn = true;
                }
            }
            else if(array[0, 2] == 1 && array[0, 2] == array[0, 1] && b == 0)
            {
               if (lewagora.Content != "X" && lewagora.Content != "O")
               {
                   lewagora.Content = "O";
                    b = 1;
                    Your_Turn = true;
               }
            }
            else if(array[0, 2] == 1 && array[0, 2] == array[0, 0] && c == 0)
            {
               if (srodekgora.Content != "X" && srodekgora.Content != "O")
               {
            srodekgora.Content = "O";
                    c = 1;
                    Your_Turn = true;
               }
            }

            else  if (array[1, 0] == 1 && array[1, 0] == array[1, 1] && d == 0)
            {
               if (prawysrodek.Content != "X" && prawysrodek.Content != "O")
               {
                   prawysrodek.Content = "O";
                   d = 1;
                   Your_Turn = true;
               }
            }
    else
    {
        Brak_algorytu();
    }
    *//*   else if (array[1, 2] == 1 *//*&& array[1, 2] == array[1, 1] && e == 0)
       {
           if (lewagora.Content != "X" && lewagora.Content != "O")
           {
               lewagora.Content = "O";
               e = 1;
               Your_Turn = true;
           }
       }
       else if (array[1, 2] == 1 && array[1, 2] == array[1, 0] && f == 0)
       {
           if (srodekgora.Content != "X" && srodekgora.Content != "O")
           {
               srodekgora.Content = "O";
               f = 1;
               Your_Turn = true;
           }
       }*/

        }
        private bool koniec = false;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
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
                    koniec = true;
                    MessageBox.Show("Wygrał gracz ktory grał: " + prawagora.Content);
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    IfWin();
                }
            }
            if (counter > 9)
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

                        counter++;
                        lewagora.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                        array[0, 0] = 99;//99=x

                    if(koniec==false)
                    {
                        AI_System();

                        CheckIfWin();
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
                   
                        srodekgora.Content = "X";
                        
                        CheckIfWin();
                    array[0, 1] = 99;//99=x
                    if (koniec == false)
                    {
                        AI_System();

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
                    array[0, 2] = 99;//99=x
                    prawagora.Content = "X";
                        Your_Turn = false;
                        CheckIfWin();
                    if (koniec == false)
                    {
                        AI_System();

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
                    array[1, 0] = 99;//99=x
                    lewysrodek.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();
                    if (koniec == false)
                    {
                        AI_System();

                        CheckIfWin();
                    };
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
                    array[1, 1] = 99;//99=x
                    counter++;

                    srodek.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();
                    if (koniec == false)
                    {
                        AI_System();

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
                    array[1, 2] = 99;//99=x
                    prawysrodek.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();
                    if (koniec == false)
                    {
                        AI_System();

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
                    array[2, 0] = 99;//99=x
                    lewydol.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();

                    if (koniec == false)
                    {
                        AI_System();

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
                    array[2, 1] = 99;//99=x
                    srodekdol.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();
                    if (koniec == false)
                    {
                        AI_System();

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
                    array[2, 2] = 99;//99=x
                    prawydol.Content = "X";
                    Your_Turn = false;
                    CheckIfWin();

                    if (koniec == false)
                    {
                        AI_System();

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
