using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; //pozwala nam stworzyć debug log w output window (możemy zobaczyć jakie przeciwnik wybrał pola)

namespace StatkiWinForms
{
    public partial class Form1 : Form
    {


        List<Button> przyciskiPozycjiGracza; //tworzy listę dla wszystkich przycisków pozycji gracza
        List<Button> przyciskiPozycjiPrzeciwnika; //tworzy listę dla wszystkich przycisków pozycji przeciwnika

        Random rand = new Random(); //generator liczb losowych

        int wszystkieStatki = 3;
        int runda = 10;
        int wynikGracza;
        int wynikPrzeciwnika;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void LicznikCzasuGryPrzeciwnikaEvent(object sender, EventArgs e)
        {
            if (przyciskiPozycjiGracza.Count > 0 && runda > 0)
            {
                runda -= 1;
                txtRundy.Text = "Runda: " + runda;

                int index = rand.Next(przyciskiPozycjiGracza.Count);

                if ((string)przyciskiPozycjiGracza[index].Tag == "statekGracza")
                {
                    przyciskiPozycjiGracza[index].BackgroundImage = Properties.Resources.IkonaOgnia;
                    RuchPrzeciwnika.Text = przyciskiPozycjiGracza[index].Text;
                    przyciskiPozycjiGracza[index].Enabled = false;
                    przyciskiPozycjiGracza[index].BackColor = Color.DarkBlue;
                    przyciskiPozycjiGracza.RemoveAt(index);
                    wynikPrzeciwnika += 1;
                    txtPrzeciwnik.Text = wynikPrzeciwnika.ToString();
                    LicznikCzasuGryPrzeciwnika.Stop();
                }
                else
                {
                    przyciskiPozycjiGracza[index].BackgroundImage = Properties.Resources.IkonaX;
                    RuchPrzeciwnika.Text = przyciskiPozycjiGracza[index].Text;
                    przyciskiPozycjiGracza[index].Enabled = false;
                    przyciskiPozycjiGracza[index].BackColor = Color.DarkBlue;
                    przyciskiPozycjiGracza.RemoveAt(index);
                    LicznikCzasuGryPrzeciwnika.Stop();
                }
            }

            if (runda < 1 || wynikPrzeciwnika > 2 || wynikGracza > 2)
            {
                if(wynikGracza > wynikPrzeciwnika)
                {
                    MessageBox.Show("Wygrałeś!", "Zwycięstwo");
                    RestartGame();
                }
                else if (wynikPrzeciwnika > wynikGracza)
                {
                    MessageBox.Show("Przegrałeś :(", "Porażka");
                    RestartGame();
                }
                else if (wynikPrzeciwnika == wynikGracza)
                {
                    MessageBox.Show("Nikomu nie udało się wygrać", "Remis");
                    RestartGame();
                }

            }
            
                

            
        }

        private void PrzyciskAtakujEvent(object sender, EventArgs e)
        {
            if (PolaLokalizacjiWroga.Text != "")
            {
                var pozycjaAtaku = PolaLokalizacjiWroga.Text.ToLower();
                int index = przyciskiPozycjiPrzeciwnika.FindIndex(a => a.Name == pozycjaAtaku);
                if (przyciskiPozycjiPrzeciwnika[index].Enabled && runda > 0)
                {
                    runda -= 1;
                    txtRundy.Text = "Runda: " + runda;

                    if ((string)przyciskiPozycjiPrzeciwnika[index].Tag == "statekPrzeciwnika")
                    {
                        przyciskiPozycjiPrzeciwnika[index].Enabled = false;
                        przyciskiPozycjiPrzeciwnika[index].BackgroundImage = Properties.Resources.IkonaOgnia;
                        przyciskiPozycjiPrzeciwnika[index].BackColor = Color.DarkBlue;
                        wynikGracza += 1;
                        txtGracz.Text = wynikGracza.ToString();
                        LicznikCzasuGryPrzeciwnika.Start();
                    }
                    else
                    {
                        przyciskiPozycjiPrzeciwnika[index].Enabled = false;
                        przyciskiPozycjiPrzeciwnika[index].BackgroundImage = Properties.Resources.IkonaX;
                        przyciskiPozycjiPrzeciwnika[index].BackColor = Color.DarkBlue;
                        LicznikCzasuGryPrzeciwnika.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Najpierw wybierz pole z listy", "Informacja");
            }
        }

        private void PrzyciskiPolGraczaEvent(object sender, EventArgs e)
        {
            if (wszystkieStatki > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "statekGracza";
                button.BackColor = Color.OrangeRed;
                wszystkieStatki -= 1;
            }

            if (wszystkieStatki ==0)
            {
                btnAtak.Enabled = true;
                btnAtak.BackColor = Color.Red;
                btnAtak.ForeColor = Color.White;

                txtPomoc.Text = "2) Wybierz z listy, pole które chcesz zaatakować";
            }
        }

        private void RestartGame()
        {
            przyciskiPozycjiGracza = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            przyciskiPozycjiPrzeciwnika = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            PolaLokalizacjiWroga.Items.Clear();
            PolaLokalizacjiWroga.Text = null;

            txtPomoc.Text = "1) Wybierz 3 pola na statki z twojej planszy aby rozpocząć grę!";

            for (int i = 0; i < przyciskiPozycjiPrzeciwnika.Count; i++)
            {
                przyciskiPozycjiPrzeciwnika[i].Enabled = true;
                przyciskiPozycjiPrzeciwnika[i].Tag = null;
                przyciskiPozycjiPrzeciwnika[i].BackColor = Color.White;
                przyciskiPozycjiPrzeciwnika[i].BackgroundImage = null;
                PolaLokalizacjiWroga.Items.Add(przyciskiPozycjiPrzeciwnika[i].Text);
            }

            for (int i = 0; i < przyciskiPozycjiGracza.Count; i++)
            {
                przyciskiPozycjiGracza[i].Enabled = true;
                przyciskiPozycjiGracza[i].Tag = null;
                przyciskiPozycjiGracza[i].BackColor = Color.White;
                przyciskiPozycjiGracza[i].BackgroundImage = null;
            }

            wynikGracza = 0;
            wynikPrzeciwnika = 0;
            runda = 10;
            wszystkieStatki = 3;

            txtGracz.Text = wynikGracza.ToString();
            txtPrzeciwnik.Text = wynikPrzeciwnika.ToString();

            RuchPrzeciwnika.Text = "A1";

            btnAtak.Enabled = false;

            WyborLokalizacjiWroga();
        }

        private void WyborLokalizacjiWroga()
        {
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(przyciskiPozycjiPrzeciwnika.Count);

                if (przyciskiPozycjiPrzeciwnika[index].Enabled == true && (string)przyciskiPozycjiPrzeciwnika[index].Tag == null) 
                {
                    przyciskiPozycjiPrzeciwnika[index].Tag = "statekPrzeciwnika";

                    Debug.WriteLine("Pozycja Wroga: " + przyciskiPozycjiPrzeciwnika[index].Text);
                }
                else
                {
                    index = rand.Next(przyciskiPozycjiPrzeciwnika.Count);
                }
            }
        }

        private void PolaLokalizacjiWroga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
