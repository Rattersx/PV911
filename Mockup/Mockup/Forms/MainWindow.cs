using Mockup.Forms.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class Form1 : Form
    {
        bool expanded = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                expandBtn.Image = imageList1.Images[1];
                expanded = false;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                expandBtn.Image = imageList1.Images[0];
                expanded = true;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expandBtn.Image = imageList1.Images[0];
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void burgerMenuBtn_Click(object sender, EventArgs e)
        {
            if (burgerMenuBtn.Location.X != 10)
            {
                guna2TileButton1.ForeColor = guna2GradientPanel2.BackColor;
                guna2TileButton2.ForeColor = guna2GradientPanel2.BackColor;
                guna2TileButton3.ForeColor = guna2GradientPanel2.BackColor;

                guna2GradientPanel2.Visible = false;
                guna2GradientPanel2.Width = 53;
                burgerMenuBtn.Location = new Point(10, burgerMenuBtn.Location.Y);
                Animator.ShowSync(guna2GradientPanel2, false, BunifuAnimatorNS.Animation.VertSlide);
            }
            else
            {
                guna2TileButton1.ForeColor = Color.Black;
                guna2TileButton2.ForeColor = Color.Black;
                guna2TileButton3.ForeColor = Color.Black;

                guna2GradientPanel2.Visible = false;
                guna2GradientPanel2.Width = 260;
                burgerMenuBtn.Location = new Point(213, burgerMenuBtn.Location.Y);
                Animator.ShowSync(guna2GradientPanel2, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        private void AddFormToContainer(object form)
        {
            foreach (Control item in Container.Controls)
            {
                Container.Controls.Remove(item);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            Container.Controls.Add(f);
            Container.Tag = f;
            f.Visible = true;
            f.Show();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesValueForm());
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaloriesRedactorProductAdd form = new CaloriesRedactorProductAdd();
            form.Visible = false;
            form.ShowDialog();
        }
    }
}
