﻿using Mockup.Forms.SecondLevelForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class CaloriesValueForm : Form
    {
        public CaloriesValueForm()
        {
            InitializeComponent();
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
        private void CaloriesValueForm_Load(object sender, EventArgs e)
        {
            AddFormToContainer(new CaloriesValueProductForm());
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if(guna2Button4.Dock == DockStyle.Left)
            {
                guna2Button4.Dock = DockStyle.None;
                guna2Button4.Location = new Point(0, 0);
                while (guna2Button4.Location.X != 709)
                    guna2Button4.Location = new Point(guna2Button4.Location.X + 1, guna2Button4.Location.Y);
                guna2Button4.Dock = DockStyle.Right;
                AddFormToContainer(new CaloriesValueDishForm());
            }
            else
            {
                guna2Button4.Dock = DockStyle.None;
                guna2Button4.Location = new Point(709, 0);
                while (guna2Button4.Location.X != 0)
                    guna2Button4.Location = new Point(guna2Button4.Location.X - 1, guna2Button4.Location.Y);
                guna2Button4.Dock = DockStyle.Left;
                AddFormToContainer(new CaloriesValueProductForm());
            }
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
