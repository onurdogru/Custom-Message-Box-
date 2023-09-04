using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCustomMessageBoxButton_Click(object sender, EventArgs e)
        {
            //// Özel bir MessageBox oluşturun
            //Form customMessageBox = new Form();
            //customMessageBox.Size = new Size(300, 150);
            //customMessageBox.BackColor = Color.Red; // Arka plan rengini kırmızı olarak ayarlayın

            //Label messageLabel = new Label();
            //messageLabel.Text = "Bu özel bir MessageBox!";
            //messageLabel.ForeColor = Color.White; // Yazı rengini beyaz olarak ayarlayın
            //messageLabel.Dock = DockStyle.Fill;
            //messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            //customMessageBox.Controls.Add(messageLabel);

            //Button closeButton = new Button();
            //closeButton.Text = "Kapat";
            //closeButton.Click += (s, args) => customMessageBox.Close();
            //customMessageBox.Controls.Add(closeButton);

            //customMessageBox.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Özel bir MessageBox oluşturun
            Form customMessageBox = new Form();
            customMessageBox.Size = new Size(500, 350);
            customMessageBox.BackColor = Color.Red; // Arka plan rengini kırmızı olarak ayarlayın

            Label messageLabel = new Label();
            messageLabel.Text = "Lüten Test Yapacak Ürüne Dikkat Ediniz, Yanlış Test Tipi!";
            messageLabel.Size = new Size(500, 350);
            messageLabel.ForeColor = Color.Black; // Yazı rengini beyaz olarak ayarlayın
            messageLabel.Dock = DockStyle.Fill;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            customMessageBox.Controls.Add(messageLabel);

            Button closeButton = new Button();
            closeButton.Text = "Kapat";
            closeButton.Click += (s, args) => customMessageBox.Close();
            customMessageBox.Controls.Add(closeButton);

            customMessageBox.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form customMessageBox = new Form();
            //customMessageBox.Size = new Size(300, 150); // Boyutu ayarlayın
            //customMessageBox.BackColor = Color.Red;

            //Label label = new Label();
            //label.Text = "Uyar Penceresi.";
            //label.TextAlign = ContentAlignment.MiddleCenter;
            //label.Dock = DockStyle.Fill;

            //Button closeButton = new Button();
            //closeButton.Text = "Kapat";
            //closeButton.Click += (sender, e) => customMessageBox.Close();
            //customMessageBox.Close();

            //customMessageBox.Controls.Add(label);
            //customMessageBox.Controls.Add(closeButton);
            //customMessageBox.ShowDialog();
        }
    }
}
