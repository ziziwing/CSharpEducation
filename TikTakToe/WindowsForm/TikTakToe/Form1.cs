using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        private enum Motion
        {
            X,
            O
        }
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                ((Button)sender).Text = Width++ % 2 == 0 ? Motion.X.ToString() : Motion.O.ToString();
                CheckMate();
            }
        }

        private void CheckMate()
        {
            if (button1.Text == Motion.X.ToString() && button2.Text == Motion.X.ToString() && button3.Text == Motion.X.ToString()
                 || button4.Text == Motion.X.ToString() && button5.Text == Motion.X.ToString() && button6.Text == Motion.X.ToString()
                 || button7.Text == Motion.X.ToString() && button8.Text == Motion.X.ToString() && button9.Text == Motion.X.ToString()
                 || button1.Text == Motion.X.ToString() && button4.Text == Motion.X.ToString() && button7.Text == Motion.X.ToString()
                 || button2.Text == Motion.X.ToString() && button5.Text == Motion.X.ToString() && button8.Text == Motion.X.ToString()
                 || button3.Text == Motion.X.ToString() && button6.Text == Motion.X.ToString() && button9.Text == Motion.X.ToString()
                 || button1.Text == Motion.X.ToString() && button5.Text == Motion.X.ToString() && button9.Text == Motion.X.ToString()
                 || button3.Text == Motion.X.ToString() && button5.Text == Motion.X.ToString() && button7.Text == Motion.X.ToString()
                 )
            {
                MessageBox.Show("Plaeyr X WIN", "Winner");
                RestartGame();
            }
            else if (button1.Text == Motion.O.ToString() && button2.Text == Motion.O.ToString() && button3.Text == Motion.O.ToString()
                 || button4.Text == Motion.O.ToString() && button5.Text == Motion.O.ToString() && button6.Text == Motion.O.ToString()
                 || button7.Text == Motion.O.ToString() && button8.Text == Motion.O.ToString() && button9.Text == Motion.O.ToString()
                 || button1.Text == Motion.O.ToString() && button4.Text == Motion.O.ToString() && button7.Text == Motion.O.ToString()
                 || button2.Text == Motion.O.ToString() && button5.Text == Motion.O.ToString() && button8.Text == Motion.O.ToString()
                 || button3.Text == Motion.O.ToString() && button6.Text == Motion.O.ToString() && button9.Text == Motion.O.ToString()
                 || button1.Text == Motion.O.ToString() && button5.Text == Motion.O.ToString() && button9.Text == Motion.O.ToString()
                 || button3.Text == Motion.O.ToString() && button5.Text == Motion.O.ToString() && button7.Text == Motion.O.ToString()
                 )
            {
                MessageBox.Show("Plaeyr O WIN", "Winner");
                RestartGame();
            }
            else if (button1.Text != ""
                 & button2.Text != ""
                 & button3.Text != ""
                 & button4.Text != ""
                 & button5.Text != ""
                 & button6.Text != ""
                 & button7.Text != ""
                 & button8.Text != ""
                 & button9.Text != ""
                 )
            {
                MessageBox.Show("DRAWS", "Winner");
                RestartGame();
            }
        }

        private void RestartGame()
        {
            List<Button> buttons = new List<Button> {
                button1,
                button2,
                button3,
                button6,
                button5,
                button4,
                button9,
                button8,
                button7
            };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = DefaultBackColor;
            }
        }

        private void RestartGameButton(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}