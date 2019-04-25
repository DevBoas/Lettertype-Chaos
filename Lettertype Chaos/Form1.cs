using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Lettertype_Chaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string output = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
        string[] fonts = { "Times New Roman", "Arial", "Segoe UI", "MV Boli", "Comic Sans MS", "Impact", "Gabriola", "Courier New" };

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            int offset = 0;
            int y = 0;
            Random rnd = new Random();
            for (int i = 0; i < output.Length; i++)
            {
                Label lab = new Label();
                lab.Location = new Point(38 + (15 * (i-offset)), 65+y);
                if (lab.Location.X > (this.Width - 100))
                {
                    offset = (i + 1);
                    y += 30;

                }
                lab.Text = output[i].ToString();
                int randomFont = rnd.Next(0, fonts.Length);
                lab.Font = new Font(fonts[randomFont], lab.Font.Size);
                lab.Size = new System.Drawing.Size(14, 13);
                lab.Name = "label" + i.ToString();
                Controls.Add(lab);
            }

            /*int i = 0;
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    Label lab = new Label();
                    lab.Location = new Point(38 + (15 * i), 65);
                    lab.Text = "C";
                    lab.Font = new Font(fa.Name, lab.Font.Size);
                    lab.Size = new System.Drawing.Size(14, 13);
                    lab.Name = "label" + i.ToString();
                    Controls.Add(lab);
                    i++;
                }
            }*/

        }
    }
}
