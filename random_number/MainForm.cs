using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_number
{
    public partial class MainForm : Form
    {
        private List<Button> buttons = new List<Button>();
        private bool isShowList = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (isShowList)
            {
                buttons.Clear();
            }

            flpShow.Controls.Clear();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!isShowList)
            {
                foreach (Control control in flpShow.Controls)
                {
                    Button button = new Button();
                    button.Text = control.Text;
                    button.Location = control.Location;
                    button.Size = control.Size;
                    buttons.Add(button);
                }
                btnClear.PerformClick();
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (!isShowList) { 
                btnClear.PerformClick();
                isShowList = true;

                foreach (Button button in buttons)
                {
                    flpShow.Controls.Add(button);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (isShowList)
            {
                isShowList = false;
                btnClear.PerformClick();
            }

            int fromNum, toNum, quantity;
            int.TryParse(tbxFrom.Text, out fromNum);
            int.TryParse(tbxTo.Text, out toNum);
            int.TryParse(tbxQuantity.Text, out quantity);
            Random random = new Random();

            if (fromNum < toNum)
            {
                for (int i = 0; i < quantity; i++)
                {
                    int randomNumber = random.Next(fromNum, toNum + 1);
                    Button button = new Button();
                    button.Text = randomNumber.ToString();
                    button.Size = new System.Drawing.Size(80, 45);
                    button.Font = new System.Drawing.Font("Courier Prime", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    flpShow.Controls.Add(button);
                }
            }
        }
    }
}
