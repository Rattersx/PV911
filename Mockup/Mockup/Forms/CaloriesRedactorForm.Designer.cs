
namespace WindowsFormsApp12
{
    partial class CaloriesRedactorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaloriesRedactorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.s = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.itemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.caloriesLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fatLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.proteinsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.carbonLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButon = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.s);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 60);
            this.panel1.TabIndex = 0;
            // 
            // s
            // 
            this.s.BorderRadius = 10;
            this.s.CheckedState.Parent = this.s;
            this.s.CustomImages.Parent = this.s;
            this.s.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.s.ForeColor = System.Drawing.Color.White;
            this.s.HoverState.Parent = this.s;
            this.s.Location = new System.Drawing.Point(20, 12);
            this.s.Name = "s";
            this.s.ShadowDecoration.Parent = this.s;
            this.s.Size = new System.Drawing.Size(136, 35);
            this.s.TabIndex = 1;
            this.s.Text = "Продукт/Блюда";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 308);
            this.listBox1.TabIndex = 2;
            // 
            // itemTextBox
            // 
            this.itemTextBox.BorderColor = System.Drawing.Color.Black;
            this.itemTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemTextBox.DefaultText = "Продукт";
            this.itemTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemTextBox.DisabledState.Parent = this.itemTextBox;
            this.itemTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemTextBox.FocusedState.Parent = this.itemTextBox;
            this.itemTextBox.ForeColor = System.Drawing.Color.Black;
            this.itemTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemTextBox.HoverState.Parent = this.itemTextBox;
            this.itemTextBox.Location = new System.Drawing.Point(20, 136);
            this.itemTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.PasswordChar = '\0';
            this.itemTextBox.PlaceholderText = "";
            this.itemTextBox.ReadOnly = true;
            this.itemTextBox.SelectedText = "";
            this.itemTextBox.SelectionStart = 7;
            this.itemTextBox.ShadowDecoration.Parent = this.itemTextBox;
            this.itemTextBox.Size = new System.Drawing.Size(212, 40);
            this.itemTextBox.TabIndex = 3;
            this.itemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColor = System.Drawing.Color.Black;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconLeft")));
            this.searchTextBox.Location = new System.Drawing.Point(20, 84);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Поиск Продукта";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(212, 32);
            this.searchTextBox.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(271, 175);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 27);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "ККал:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(271, 297);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 27);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Белков:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(271, 234);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(71, 27);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Жиров:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(271, 353);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(106, 27);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Углеводов:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BackColor = System.Drawing.Color.Transparent;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caloriesLabel.Location = new System.Drawing.Point(437, 169);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(86, 33);
            this.caloriesLabel.TabIndex = 9;
            this.caloriesLabel.Text = "1999.5";
            // 
            // fatLabel
            // 
            this.fatLabel.BackColor = System.Drawing.Color.Transparent;
            this.fatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatLabel.Location = new System.Drawing.Point(437, 228);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(48, 33);
            this.fatLabel.TabIndex = 10;
            this.fatLabel.Text = "524";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.proteinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proteinsLabel.Location = new System.Drawing.Point(437, 291);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(63, 33);
            this.proteinsLabel.TabIndex = 11;
            this.proteinsLabel.Text = "5123";
            // 
            // carbonLabel
            // 
            this.carbonLabel.BackColor = System.Drawing.Color.Transparent;
            this.carbonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carbonLabel.Location = new System.Drawing.Point(437, 347);
            this.carbonLabel.Name = "carbonLabel";
            this.carbonLabel.Size = new System.Drawing.Size(63, 33);
            this.carbonLabel.TabIndex = 12;
            this.carbonLabel.Text = "6124";
            // 
            // addButton
            // 
            this.addButton.BorderRadius = 5;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(621, 157);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(150, 50);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Добавить";
            // 
            // editButton
            // 
            this.editButton.BorderRadius = 5;
            this.editButton.CheckedState.Parent = this.editButton;
            this.editButton.CustomImages.Parent = this.editButton;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.HoverState.Parent = this.editButton;
            this.editButton.Location = new System.Drawing.Point(621, 234);
            this.editButton.Name = "editButton";
            this.editButton.ShadowDecoration.Parent = this.editButton;
            this.editButton.Size = new System.Drawing.Size(150, 50);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Изменить";
            // 
            // deleteButon
            // 
            this.deleteButon.BorderRadius = 5;
            this.deleteButon.CheckedState.Parent = this.deleteButon;
            this.deleteButon.CustomImages.Parent = this.deleteButon;
            this.deleteButon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButon.ForeColor = System.Drawing.Color.White;
            this.deleteButon.HoverState.Parent = this.deleteButon;
            this.deleteButon.Location = new System.Drawing.Point(621, 407);
            this.deleteButon.Name = "deleteButon";
            this.deleteButon.ShadowDecoration.Parent = this.deleteButon;
            this.deleteButon.Size = new System.Drawing.Size(150, 50);
            this.deleteButon.TabIndex = 15;
            this.deleteButon.Text = "Удалить";
            // 
            // CaloriesRedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 520);
            this.Controls.Add(this.deleteButon);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.carbonLabel);
            this.Controls.Add(this.proteinsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaloriesRedactorForm";
            this.Text = "CaloriesRedactorForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button s;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox itemTextBox;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel caloriesLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel fatLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel proteinsLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel carbonLabel;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button deleteButon;
    }
}