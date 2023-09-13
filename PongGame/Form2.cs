using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void pikachuCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).pongBall.Image = Image.FromFile(@"C:\Users\komp\Pictures\game\pikachu_icon-icons.com_67535.png");
            (this.Owner as pong).pongTimer.Start();
            this.Hide();

        }

        private void jigglyPuffCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).pongBall.Image = Image.FromFile(@"C:\Users\komp\Pictures\game\jigglypuff_icon-icons.com_67550.png");
            (this.Owner as pong).pongTimer.Start();
            this.Hide();
        }

        private void bulbasaurCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).pongBall.Image = Image.FromFile(@"C:\Users\komp\Pictures\game\bulbasaur_icon-icons.com_67580.png");
            (this.Owner as pong).pongTimer.Start();
            this.Hide();
        }

        private void eeveeCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as pong).pongBall.Image = Image.FromFile(@"C:\Users\komp\Pictures\game\eevee_icon-icons.com_67563.png");
            (this.Owner as pong).pongTimer.Start();
            this.Hide();
        }
    }
}
