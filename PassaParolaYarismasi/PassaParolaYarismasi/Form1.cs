using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParolaYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlıs = 0;
        public void btnKontrol(Button btn,string kosul)
        {
            if (textBox1.Text.ToLower() == kosul)
            {
                btn.BackColor = Color.Green;
                dogru++;
            }
            else
            {
                btn.BackColor = Color.Red;
                yanlıs++;
            }
            textBox1.Enabled = false;
            linkLabel1.Enabled = true;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                switch (soruNo)
                {
                    case 1:
                        btnKontrol(btnA,"akdeniz");
                        break;
                    case 2:
                        btnKontrol(btnB, "bursa"); 
                        break;
                    case 3:
                        btnKontrol(btnC,"cuma");
                        break;
                    case 4:
                        btnKontrol(btnD,"diyarbakır");
                        break;
                    case 5:
                        btnKontrol(btnE, "eski");
                        break;
                    case 6:
                        btnKontrol(btnF, "ferman");
                        break;
                    case 7:
                        btnKontrol(btnG, "güneş");
                        break;
                    case 8:
                        btnKontrol(btnH, "hava");
                        break;
                    case 9:
                        btnKontrol(btnI, "ısparta");
                        break;
                    case 10:
                        btnKontrol(btnii, "içel");
                        break;
                    case 11:
                        btnKontrol(btnJ, "jandarma");
                        break;
                    case 12:
                        btnKontrol(btnK, "kayısı");
                        break;
                    case 13:
                        btnKontrol(btnL, "lale");
                        break;
                    case 14:
                        btnKontrol(btnM, "mart");
                        break;
                    case 15:
                        btnKontrol(btnN, "ney");
                        break;
                    case 16:
                        btnKontrol(btnO, "ozan");
                        break;
                    case 17:
                        btnKontrol(btnP, "pırasa");
                        break;
                    case 18:
                        btnKontrol(btnR, "ramazan");
                        break;
                    case 19:
                        btnKontrol(btnS, "snake");
                        break;
                    case 20:
                        btnKontrol(btnT, "tarkan");
                        break;
                    case 21:
                        btnKontrol(btnU, "umut");
                        break;
                    case 22:
                        btnKontrol(btnV, "van");
                        break;
                    case 23:
                        btnKontrol(btnY, "yıldırım");
                        break;
                    case 24:
                        btnKontrol(btnZ, "zeytin");
                        break;
                    
                }
                label2.Text = dogru.ToString();
                label3.Text = yanlıs.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            textBox1.Text = "";
            soruNo++;
            this.Text=soruNo.ToString()+".Soru";
            textBox1.Enabled = true;
            linkLabel1.Enabled = false;
            if(soruNo ==1 ) 
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow;
                btnSoru.Text = "A";
            }else if(soruNo ==2 )
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz?";
                btnB.BackColor = Color.Yellow;
                btnSoru.Text = "B";
            }
            else if(soruNo ==3 )
            {
                richTextBox1.Text = "Müslümanlar için her hafta özel bir gün?";
                btnC.BackColor = Color.Yellow;
                btnSoru.Text = "C";
            }
            else if (soruNo ==4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                btnD.BackColor = Color.Yellow;
                btnSoru.Text = "D";
            }
            else if(soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
                btnSoru.Text = "E";
            }
            else if(soruNo == 6)
            {
                richTextBox1.Text = "Padişahların emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
                btnSoru.Text = "F";
            }
            else if (soruNo == 7)
            {
                richTextBox1.Text = "Dünya'nın ısı kaynağı?";
                btnG.BackColor = Color.Yellow;
                btnSoru.Text = "G";
            }
            else if (soruNo == 8)
            {
                richTextBox1.Text = "Ateş - ? - Su - Toprak(Tahta)";
                btnH.BackColor = Color.Yellow;
                btnSoru.Text = "H";
            }
            else if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
                btnSoru.Text = "I";
            }
            else if (soruNo == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                btnii.BackColor = Color.Yellow;
                btnSoru.Text = "İ";
            }
            else if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
                btnSoru.Text = "J";
            }
            else if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
                btnSoru.Text = "K";
            }
            else if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl  bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
                btnSoru.Text = "L";
            }
            else if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                btnM.BackColor = Color.Yellow;
                btnSoru.Text = "M";
            }
            else if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                btnN.BackColor = Color.Yellow;
                btnSoru.Text = "N";
            }
            else if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btnO.BackColor = Color.Yellow;
                btnSoru.Text = "O";
            }
            else if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                btnP.BackColor = Color.Yellow;
                btnSoru.Text = "P";
            }
            else if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
                btnSoru.Text = "R";
            }
            else if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                btnS.BackColor = Color.Yellow;
                btnSoru.Text = "S";
            }
            else if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiye'nin megastarı?";
                btnT.BackColor = Color.Yellow;
                btnSoru.Text = "T";
            }
            else if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                btnU.BackColor = Color.Yellow;
                btnSoru.Text = "U";
            }
            else if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                btnV.BackColor = Color.Yellow;
                btnSoru.Text = "V";
            }
            else if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                btnY.BackColor = Color.Yellow;
                btnSoru.Text = "Y";
            }
            else if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                btnZ.BackColor = Color.Yellow;
                btnSoru.Text = "Z";

            }
            else if(soruNo == 25)
            {
                richTextBox1.Text = "Sorular bitti oynadığınız için teşekkür ederim.";
                linkLabel1.Enabled = false;
                btnSoru.Text =":)";
            }

        }
    }
}
