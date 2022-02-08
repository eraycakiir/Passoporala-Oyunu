using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passoporala_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "galatasaray")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "izmir")
                        {
                            buttonİ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "patates")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

             if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                buttonA.BackColor = Color.Yellow;
            }
             if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                buttonB.BackColor = Color.Yellow;
            }
             if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                buttonC.BackColor = Color.Yellow;
            }
             if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz";
                buttonD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı";
                buttonE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerin yazılı hali?";
                buttonF.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın en büyük takımı?";
                buttonG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne ?";
                buttonH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle Ünlü Şehrimiz?";
                buttonI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Çeşme hangi şehrimizdedir?";
                buttonİ.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri topluluk?";
                buttonJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                buttonK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivaki?";
                buttonL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                buttonM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti?";
                buttonN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                buttonO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Karbonhidrat kaynağı?";
                buttonP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                buttonR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizce de yılan?";
                buttonS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı?";
                buttonT.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                buttonU.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                richTextBox1.Text = "Kedisi ile ünlü ilimiz?";
                buttonV.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                buttonY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağıda bulunan kahvaltı besini?";
                buttonZ.BackColor = Color.Yellow;
            }
        }
    }
}
