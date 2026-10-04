namespace Money;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        SekilleriYukle();
    }

    private void SekilleriYukle()
    {
        string qovluq = Path.Combine(Application.StartupPath, "Sekiller");

        if (File.Exists(Path.Combine(qovluq, "1.jpg")))
        {
            pictureBox1.Image = Image.FromFile(Path.Combine(qovluq, "1.jpg"));
        }
        else
        {
            pictureBox1.Image = BanknotSekli("1 MANAT", Color.FromArgb(220, 220, 210));
        }

        if (File.Exists(Path.Combine(qovluq, "5.jpg")))
        {
            pictureBox2.Image = Image.FromFile(Path.Combine(qovluq, "5.jpg"));
        }
        else
        {
            pictureBox2.Image = BanknotSekli("5 MANAT", Color.FromArgb(235, 190, 120));
        }

        if (File.Exists(Path.Combine(qovluq, "10.jpg")))
        {
            pictureBox3.Image = Image.FromFile(Path.Combine(qovluq, "10.jpg"));
        }
        else
        {
            pictureBox3.Image = BanknotSekli("10 MANAT", Color.FromArgb(170, 210, 205));
        }

        if (File.Exists(Path.Combine(qovluq, "20.jpg")))
        {
            pictureBox4.Image = Image.FromFile(Path.Combine(qovluq, "20.jpg"));
        }
        else
        {
            pictureBox4.Image = BanknotSekli("20 MANAT", Color.FromArgb(185, 215, 165));
        }

        if (File.Exists(Path.Combine(qovluq, "50.jpg")))
        {
            pictureBox5.Image = Image.FromFile(Path.Combine(qovluq, "50.jpg"));
        }
        else
        {
            pictureBox5.Image = BanknotSekli("50 MANAT", Color.FromArgb(215, 200, 150));
        }

        if (File.Exists(Path.Combine(qovluq, "100.jpg")))
        {
            pictureBox6.Image = Image.FromFile(Path.Combine(qovluq, "100.jpg"));
        }
        else
        {
            pictureBox6.Image = BanknotSekli("100 MANAT", Color.FromArgb(225, 185, 195));
        }

        if (File.Exists(Path.Combine(qovluq, "200.jpg")))
        {
            pictureBox7.Image = Image.FromFile(Path.Combine(qovluq, "200.jpg"));
        }
        else
        {
            pictureBox7.Image = BanknotSekli("200 MANAT", Color.FromArgb(175, 200, 230));
        }

        if (File.Exists(Path.Combine(qovluq, "500.png")))
        {
            pictureBox8.Image = Image.FromFile(Path.Combine(qovluq, "500.png"));
        }
        else
        {
            if (File.Exists(Path.Combine(qovluq, "500.jpg")))
            {
                pictureBox8.Image = Image.FromFile(Path.Combine(qovluq, "500.jpg"));
            }
            else
            {
                pictureBox8.Image = BanknotSekli("500 MANAT", Color.FromArgb(215, 165, 175));
            }
        }
    }

    private Bitmap BanknotSekli(string yazi, Color fon)
    {
        Bitmap bmp = new Bitmap(240, 120);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(fon);
        Pen cerceve = new Pen(Color.FromArgb(80, 80, 80), 3);
        g.DrawRectangle(cerceve, 2, 2, 235, 115);
        Font boyukFont = new Font("Segoe UI", 20, FontStyle.Bold);
        Font kicikFont = new Font("Segoe UI", 9, FontStyle.Bold);
        SolidBrush yaziFircasi = new SolidBrush(Color.FromArgb(40, 40, 40));
        g.DrawString("AZÆRBAYCAN MÆRKÆZÄ° BANKI", kicikFont, yaziFircasi, 15, 15);
        g.DrawString(yazi, boyukFont, yaziFircasi, 15, 45);
        return bmp;
    }

    private void txtMebleg_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMebleg.Text))
        {
            errorProvider1.SetError(txtMebleg, "MÉ™blÉ™ÄŸ daxil edin");
        }
        else
        {
            errorProvider1.SetError(txtMebleg, "");
        }
    }

    private void btnXirdala_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMebleg.Text))
        {
            errorProvider1.SetError(txtMebleg, "MÉ™blÉ™ÄŸ daxil edin");
        }
        else
        {
            errorProvider1.SetError(txtMebleg, "");

            int mebleg = 0;

            if (int.TryParse(txtMebleg.Text.Trim(), out mebleg))
            {
                if (mebleg <= 0)
                {
                    MessageBox.Show("MÉ™nfi vÉ™ ya sÄ±fÄ±r mÉ™blÉ™ÄŸ xÄ±rdalanmaz", "DiqqÉ™t", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int qalan = mebleg;

                    int say500 = qalan / 500;
                    qalan = qalan % 500;

                    int say200 = qalan / 200;
                    qalan = qalan % 200;

                    int say100 = qalan / 100;
                    qalan = qalan % 100;

                    int say50 = qalan / 50;
                    qalan = qalan % 50;

                    int say20 = qalan / 20;
                    qalan = qalan % 20;

                    int say10 = qalan / 10;
                    qalan = qalan % 10;

                    int say5 = qalan / 5;
                    qalan = qalan % 5;

                    int say1 = qalan;
                    qalan = 0;

                    if (say1 > 0)
                    {
                        pictureBox1.Visible = true;
                        label1.Visible = true;
                        label1.Text = say1 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                    }

                    if (say5 > 0)
                    {
                        pictureBox2.Visible = true;
                        label2.Visible = true;
                        label2.Text = say5 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox2.Visible = false;
                        label2.Visible = false;
                    }

                    if (say10 > 0)
                    {
                        pictureBox3.Visible = true;
                        label3.Visible = true;
                        label3.Text = say10 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox3.Visible = false;
                        label3.Visible = false;
                    }

                    if (say20 > 0)
                    {
                        pictureBox4.Visible = true;
                        label4.Visible = true;
                        label4.Text = say20 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox4.Visible = false;
                        label4.Visible = false;
                    }

                    if (say50 > 0)
                    {
                        pictureBox5.Visible = true;
                        label5.Visible = true;
                        label5.Text = say50 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox5.Visible = false;
                        label5.Visible = false;
                    }

                    if (say100 > 0)
                    {
                        pictureBox6.Visible = true;
                        label6.Visible = true;
                        label6.Text = say100 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox6.Visible = false;
                        label6.Visible = false;
                    }

                    if (say200 > 0)
                    {
                        pictureBox7.Visible = true;
                        label7.Visible = true;
                        label7.Text = say200 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox7.Visible = false;
                        label7.Visible = false;
                    }

                    if (say500 > 0)
                    {
                        pictureBox8.Visible = true;
                        label8.Visible = true;
                        label8.Text = say500 + " É™dÉ™d";
                    }
                    else
                    {
                        pictureBox8.Visible = false;
                        label8.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("MÉ™nfi vÉ™ ya sÄ±fÄ±r mÉ™blÉ™ÄŸ xÄ±rdalanmaz", "DiqqÉ™t", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
