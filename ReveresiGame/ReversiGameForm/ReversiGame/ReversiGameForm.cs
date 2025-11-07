using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class ReversiGameForm : Form
    {
        public ReversiGameForm()
        {
            InitializeComponent();
        }
        int steps = 64;
        public int currentStepPlayer = 1;
        int player1 = 1;
        int player2 = 2;

        public void switch_step()
        {
            AddNameForm frmGet = new AddNameForm();
            String GetName1 = frmGet.getName1();
            String GetName2 = frmGet.getName2();
            steps--;
            if (steps % 2 == 0)
            {
                currentStepPlayer = player1;
                NamePlayerLabel.Text = GetName1;
                NamePlayerLabel.Refresh();
            }
            else
            {
                currentStepPlayer = player2;
                NamePlayerLabel.Text = GetName2;
                NamePlayerLabel.Refresh();
            }
        }

        public void All_Button_Ckick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.BackgroundImage != null) { }
            else if (currentStepPlayer == 1 && steps > 0)
            {
                clickedButton.BackgroundImage = Properties.Resources.white;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                string buttonName = clickedButton.Name;
                string number = new string(buttonName.Where(char.IsDigit).ToArray());
                int j = int.Parse(number);
                int countX = 0;
                int countY = 0;
                int countN = 0;
                int countM = 0;
                int jX = j;
                int jY = j;
                int jN = j;
                int jM = j;
                int id = j;
                while (jX <= 64)
                {
                    jX += 8;
                    if (jX > 64)
                    {
                        countX = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jX.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        countX++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countX = 0;
                        break;
                    }
                }
                while (jY >= 9)
                {
                    jY -= 8;
                    if (jY < 0)
                    {
                        countY = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jY.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        countY++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countY = 0;
                        break;
                    }
                }
                while (jN % 8 != 0)
                {
                    jN += 1;
                    if (jN % 8 == 0)
                    {
                        countN = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jN.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        countN++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countN = 0;
                        break;
                    }
                }
                while (jM % 8 != 0)
                {
                    jM -= 1;
                    if (jM % 8 == 0)
                    {
                        countM = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jM.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        countM++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countM = 0;
                        break;
                    }
                }
                int buttonNumX = j;
                int buttonNumY = j;
                int buttonNumN = j;
                int buttonNumM = j;
                for (int iX = 0; iX < countX; iX++)
                {
                    buttonNumX = buttonNumX + 8;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumX.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.white;
                }
                for (int iY = 0; iY < countY; iY++)
                {
                    buttonNumY = buttonNumY - 8;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumY.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.white;
                }
                for (int iN = 0; iN < countN; iN++)
                {
                    buttonNumN = buttonNumN + 1;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumN.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.white;
                }
                for (int iM = 0; iM < countM; iM++)
                {
                    buttonNumM = buttonNumM - 1;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumM.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.white;
                }
                switch_step();
            }
            else if (currentStepPlayer == 2 && steps > 0)
            {
                clickedButton.BackgroundImage = Properties.Resources.black;
                clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                string buttonName = clickedButton.Name;
                string number = new string(buttonName.Where(char.IsDigit).ToArray());
                int j = int.Parse(number);
                int countX = 0;
                int countY = 0;
                int countN = 0;
                int countM = 0;
                int jX = j;
                int jY = j;
                int jN = j;
                int jM = j;
                int id = j;
                while (jX <= 64)
                {
                    jX += 8;
                    if (jX > 64)
                    {
                        countX = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jX.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        countX++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countX = 0;
                        break;
                    }
                }
                while (jY >= 9)
                {
                    jY -= 8;
                    if (jY < 0)
                    {
                        countY = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jY.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        countY++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countY = 0;
                        break;
                    }
                }
                while (jN % 8 != 0)
                {
                    jN += 1;
                    if (jN % 8 == 0)
                    {
                        countN = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jN.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        countN++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countN = 0;
                        break;
                    }
                }
                while (jM % 8 != 0)//поменять логику просчета клеток и выполнения условий
                {
                    jM -= 1;
                    if (jM % 8 == 0)
                    {
                        countM = 0;
                        break;
                    }
                    Button btn = flowLayoutPanel1.Controls["button" + jM.ToString()] as Button;
                    if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.white.Width)
                    {
                        countM++;
                    }
                    else if (btn.BackgroundImage != null && btn.BackgroundImage.Width == Properties.Resources.black.Width)
                    {
                        break;
                    }
                    else if (btn.BackgroundImage == null)
                    {
                        countM = 0;
                        break;
                    }
                }
                int buttonNumX = j;
                int buttonNumY = j;
                int buttonNumN = j;
                int buttonNumM = j;
                for (int iX = 0; iX < countX; iX++)
                {
                    buttonNumX = buttonNumX + 8;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumX.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.black;
                }
                for (int iY = 0; iY < countY; iY++)
                {
                    buttonNumY = buttonNumY - 8;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumY.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.black;
                }
                for (int iN = 0; iN < countN; iN++)
                {
                    buttonNumN = buttonNumN + 1;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumN.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.black;
                }
                for (int iM = 0; iM < countM; iM++)
                {
                    buttonNumM = buttonNumM - 1;
                    Button btn = flowLayoutPanel1.Controls["button" + buttonNumM.ToString()] as Button;
                    btn.BackgroundImage = Properties.Resources.black;
                }
                switch_step();
            }
        }

        private void ReversiGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
