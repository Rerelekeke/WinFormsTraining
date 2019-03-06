using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    //public partial class Form1 : Form
    //{
    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        Button senderButton = (Button)sender;
    //        senderButton.Text = "Bouton cliqué";
    //        label1.Text = senderButton.Name + " vient d'être cliqué.";
    //    }

    //    private void button2_MouseClick(object sender, MouseEventArgs e)
    //    {
    //        label1.Text = "Bouton n°1 cliqué à la position : " + e.Location + ".";
    //    }

    //    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    //    {

    //    }
    //}

    public partial class Form1 : Form
    {


        private void button1_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.Text = "Bouton cliqué";
            label1.Text = senderButton.Name + " vient d'être cliqué.";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Bouton n°1 cliqué à la position : " + e.Location + ".";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        // Déclaration des champs
        static Timer s_myTimer = new Timer();
        static int s_myCounter = 0;

        // Constructeur
        public Form1()
        {
            InitializeComponent();
            // À ne mettre ici que si ce n'est pas déjà dans Form1.Designer.cs
            s_myTimer.Tick += new EventHandler(s_myTimer_Tick);

            // 1 seconde = 1000 millisecondes
            s_myTimer.Interval = 1000;
            s_myTimer.Start();

            MessageBox.Show("Timer lancé.");
        }

        // Méthode appelée pour l'évènement
        static void s_myTimer_Tick(object sender, EventArgs e)
        {
            s_myCounter++;


            if (s_myCounter >= 5)
            {
                try
                {
                    // Si le Timer est en marche...
                    if (s_myTimer.Enabled)
                    {
                        s_myTimer.Stop();
                        MessageBox.Show("Timer stoppé.");
                    }
                    else
                    {
                        MessageBox.Show("Timer déjà stoppé.");
                    }
                }
                catch (MyException ex)
                {
                    ex.DisplayError();
                }
                
            }

            MessageBox.Show("s_myCounter vaut " + s_myCounter + ".");
        }
    }
}
