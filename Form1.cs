using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Kart_Eslestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Timer zamanAkipGider;


        private List<Point> positions = new List<Point>();
        private void Form1_Load(object sender, EventArgs e)
        {
            positions = new List<Point>()
               {
                 new Point(27, 16), new Point(128, 16), new Point(329, 292), new Point(126, 292),
                 new Point(230, 16), new Point(228, 292), new Point(329, 198), new Point(25, 292),
                 new Point(329, 16), new Point(329, 104), new Point(126, 198), new Point(126, 104),
                 new Point(228, 102), new Point(228, 198), new Point(25, 102), new Point(25, 198)
                };

            zamanAkipGider = new Timer(); 
            zamanAkipGider.Interval = 1000;
            zamanAkipGider.Tick += zamanlayici_Tick;
            zamanAkipGider.Start();
        }

        // kart pozisyonları:



        Random kerem = new Random();
        
     
        public async void kartlariKaristir()
        {
            List<PictureBox> kartlar = new List<PictureBox>()
            {
                kopek, kopek_es, at, at_es, kus, kus_es, yilan, yilan_es,
                bayrak, bayrak_es, csgo, csgo_es, dilenci, dilenci_es, minecraft, minecraft_es
            };

            for (int i = 0; i < kartlar.Count; i++)
            {
                int rnd = kerem.Next(0, kartlar.Count); // 0 - 16 arası & dahil rastgele
                int rnd_pos = kerem.Next(0, positions.Count); // 0 - 16 arası & dahil rastgele

                kartlar[i].Location = new Point(positions[rnd_pos].X, positions[rnd_pos].Y);

                positions.Remove(new Point(positions[rnd_pos].X, positions[rnd_pos].Y));
            }

            button1.Visible = false;

            await Task.Delay(5000);

            positions.Clear();

            foreach(PictureBox pictureBox in kartlar)
            {
                if(!pictureBox.Name.StartsWith("pictureBox")) {
                  positions.Add(pictureBox.Location);
                }
            }

            int a = 0;
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)ctrl;
                    if (pictureBox.Name.StartsWith("pictureBox") && a != 16)
                    {
                        pictureBox.Location = new Point(positions[a].X, positions[a].Y);
                        a++;
                    }
                }
            }

        }
        


        private async void kartlariGoster(int time)
        {
            await Task.Delay(time);
        
        }

        public Point secim1;
        public Point secim2;
        private Point boxLocation1;
        private Point boxLocation2;

        public int secimMiktari = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            kartlariKaristir();
            this.Refresh();
        }

        
        private void pictureBoxxx_Click(object sender, EventArgs e)
        {
            if(secimMiktari != 0)
            {
                pictureBoxxx.Visible = false;
                if(boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBoxxx.Location.X, pictureBoxxx.Location.Y);
                } else if(boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBoxxx.Location.X, pictureBoxxx.Location.Y);
                }



                if(secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBoxxx.Location.X, pictureBoxxx.Location.Y);
                } else if(secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBoxxx.Location.X, pictureBoxxx.Location.Y);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox1.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                }


                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox5.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox10.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox2.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
                }


                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox2.Location.X, pictureBox2.Location.Y);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox3.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox4.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox4.Location.X, pictureBox4.Location.Y);
                }
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox6.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                }


                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox9.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox15.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox15.Location.X, pictureBox15.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox15.Location.X, pictureBox15.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox15.Location.X, pictureBox15.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox15.Location.X, pictureBox15.Location.Y);
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox14.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox14.Location.X, pictureBox14.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox14.Location.X, pictureBox14.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox14.Location.X, pictureBox14.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox14.Location.X, pictureBox14.Location.Y);
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox13.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox13.Location.X, pictureBox13.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox13.Location.X, pictureBox13.Location.Y);
                }


                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox13.Location.X, pictureBox13.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox13.Location.X, pictureBox13.Location.Y);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox7.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox12.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox12.Location.X, pictureBox12.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox12.Location.X, pictureBox12.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox12.Location.X, pictureBox12.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox12.Location.X, pictureBox12.Location.Y);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox11.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox11.Location.X, pictureBox11.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox11.Location.X, pictureBox11.Location.Y);
                }

                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox11.Location.X, pictureBox11.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox11.Location.X, pictureBox11.Location.Y);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (secimMiktari != 0)
            {
                pictureBox8.Visible = false;
                if (boxLocation1.IsEmpty)
                {
                    boxLocation1 = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                }
                else if (boxLocation2.IsEmpty)
                {
                    boxLocation2 = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                }


                if (secim1.IsEmpty)
                {
                    secim1 = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                }
                else if (secim2.IsEmpty)
                {
                    secim2 = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                }
            }
        }

        private int puan;

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            if (secim1.IsEmpty || secim2.IsEmpty) return;

            List<PictureBox> kartlar = new List<PictureBox>()
                 {
                     kopek, kopek_es, at, at_es, kus, kus_es, yilan, yilan_es,
                     bayrak, bayrak_es, csgo, csgo_es, dilenci, dilenci_es, minecraft, minecraft_es
                };

            PictureBox kart1 = null, kart2 = null;

            foreach (PictureBox kart in kartlar)
            {
                if (kart.Location == secim1) kart1 = kart;
                if (kart.Location == secim2) kart2 = kart;
            }

            if (kart1 != null && kart2 != null)
            {
                string isim1 = kart1.Name.Substring(0, 2);
                string isim2 = kart2.Name.Substring(0, 2);

                if (isim1 == isim2)
                {
                    puan = puan + 1;
                    puan_keeper_lbl.Text = puan.ToString();
                }
                else
                {
                    Task.Delay(1000).Wait(); // 1 saniye bekle
                    
                    foreach(PictureBox boxlar in panel2.Controls)
                    {
                        if(boxlar.Name.StartsWith("pictureBo"))
                        {
                            if (boxLocation1 == boxlar.Location) { boxlar.Visible = true; }
                            if (boxLocation2 == boxlar.Location) { boxlar.Visible = true; }
                        }
                    }

                    kart1.Visible = true;
                    kart2.Visible = true;
                   
                }
            }

            boxLocation1 = Point.Empty;
            boxLocation2 = Point.Empty;
            secim1 = Point.Empty;
            secim2 = Point.Empty;
        }

      


        // babacağım bu geceni bize ayır


    }
}
