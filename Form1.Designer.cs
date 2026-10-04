namespace Money;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.Label lblBasliq;
    private System.Windows.Forms.TextBox txtMebleg;
    private System.Windows.Forms.Button btnXirdala;
    private System.Windows.Forms.ErrorProvider errorProvider1;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.PictureBox pictureBox7;
    private System.Windows.Forms.PictureBox pictureBox8;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panelLeft = new System.Windows.Forms.Panel();
        panelRight = new System.Windows.Forms.Panel();
        lblBasliq = new System.Windows.Forms.Label();
        txtMebleg = new System.Windows.Forms.TextBox();
        btnXirdala = new System.Windows.Forms.Button();
        errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        pictureBox4 = new System.Windows.Forms.PictureBox();
        pictureBox5 = new System.Windows.Forms.PictureBox();
        pictureBox6 = new System.Windows.Forms.PictureBox();
        pictureBox7 = new System.Windows.Forms.PictureBox();
        pictureBox8 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        panelLeft.SuspendLayout();
        panelRight.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
        SuspendLayout();

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 620);
        Controls.Add(panelRight);
        Controls.Add(panelLeft);
        Name = "Form1";
        Text = "Money";
        StartPosition = FormStartPosition.CenterScreen;

        panelLeft.BackColor = Color.DarkOrange;
        panelLeft.Dock = DockStyle.Left;
        panelLeft.Width = 240;
        panelLeft.Controls.Add(lblBasliq);
        panelLeft.Controls.Add(txtMebleg);
        panelLeft.Controls.Add(btnXirdala);

        lblBasliq.AutoSize = true;
        lblBasliq.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblBasliq.Location = new Point(15, 180);
        lblBasliq.Text = "Xırdalanacaq məbləğ";

        txtMebleg.Location = new Point(15, 210);
        txtMebleg.Size = new Size(210, 27);
        txtMebleg.TextChanged += new EventHandler(txtMebleg_TextChanged);

        btnXirdala.Location = new Point(15, 260);
        btnXirdala.Size = new Size(210, 45);
        btnXirdala.Text = "Xırdala";
        btnXirdala.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnXirdala.Click += new EventHandler(btnXirdala_Click);

        errorProvider1.ContainerControl = this;

        panelRight.BackColor = Color.Teal;
        panelRight.Dock = DockStyle.Fill;
        panelRight.Controls.Add(pictureBox1);
        panelRight.Controls.Add(label1);
        panelRight.Controls.Add(pictureBox2);
        panelRight.Controls.Add(label2);
        panelRight.Controls.Add(pictureBox3);
        panelRight.Controls.Add(label3);
        panelRight.Controls.Add(pictureBox4);
        panelRight.Controls.Add(label4);
        panelRight.Controls.Add(pictureBox5);
        panelRight.Controls.Add(label5);
        panelRight.Controls.Add(pictureBox6);
        panelRight.Controls.Add(label6);
        panelRight.Controls.Add(pictureBox7);
        panelRight.Controls.Add(label7);
        panelRight.Controls.Add(pictureBox8);
        panelRight.Controls.Add(label8);

        pictureBox1.Location = new Point(30, 20);
        pictureBox1.Size = new Size(240, 120);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.BackColor = Color.White;
        pictureBox1.Visible = true;

        label1.Location = new Point(280, 65);
        label1.Size = new Size(100, 30);
        label1.ForeColor = Color.White;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Text = "label1";
        label1.Visible = true;

        pictureBox5.Location = new Point(390, 20);
        pictureBox5.Size = new Size(240, 120);
        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        pictureBox5.BackColor = Color.White;
        pictureBox5.Visible = true;

        label5.Location = new Point(640, 65);
        label5.Size = new Size(100, 30);
        label5.ForeColor = Color.White;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label5.Text = "label5";
        label5.Visible = true;

        pictureBox2.Location = new Point(30, 170);
        pictureBox2.Size = new Size(240, 120);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        pictureBox2.BackColor = Color.White;
        pictureBox2.Visible = true;

        label2.Location = new Point(280, 215);
        label2.Size = new Size(100, 30);
        label2.ForeColor = Color.White;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Text = "label2";
        label2.Visible = true;

        pictureBox6.Location = new Point(390, 170);
        pictureBox6.Size = new Size(240, 120);
        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        pictureBox6.BackColor = Color.White;
        pictureBox6.Visible = true;

        label6.Location = new Point(640, 215);
        label6.Size = new Size(100, 30);
        label6.ForeColor = Color.White;
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label6.Text = "label6";
        label6.Visible = true;

        pictureBox3.Location = new Point(30, 320);
        pictureBox3.Size = new Size(240, 120);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        pictureBox3.BackColor = Color.White;
        pictureBox3.Visible = true;

        label3.Location = new Point(280, 365);
        label3.Size = new Size(100, 30);
        label3.ForeColor = Color.White;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label3.Text = "label3";
        label3.Visible = true;

        pictureBox7.Location = new Point(390, 320);
        pictureBox7.Size = new Size(240, 120);
        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox7.BorderStyle = BorderStyle.FixedSingle;
        pictureBox7.BackColor = Color.White;
        pictureBox7.Visible = true;

        label7.Location = new Point(640, 365);
        label7.Size = new Size(100, 30);
        label7.ForeColor = Color.White;
        label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label7.Text = "label7";
        label7.Visible = true;

        pictureBox4.Location = new Point(30, 470);
        pictureBox4.Size = new Size(240, 120);
        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        pictureBox4.BackColor = Color.White;
        pictureBox4.Visible = true;

        label4.Location = new Point(280, 515);
        label4.Size = new Size(100, 30);
        label4.ForeColor = Color.White;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Text = "label4";
        label4.Visible = true;

        pictureBox8.Location = new Point(390, 470);
        pictureBox8.Size = new Size(240, 120);
        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox8.BorderStyle = BorderStyle.FixedSingle;
        pictureBox8.BackColor = Color.White;
        pictureBox8.Visible = true;

        label8.Location = new Point(640, 515);
        label8.Size = new Size(100, 30);
        label8.ForeColor = Color.White;
        label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label8.Text = "label8";
        label8.Visible = true;

        panelLeft.ResumeLayout(false);
        panelLeft.PerformLayout();
        panelRight.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
        ResumeLayout(false);
    }
}
