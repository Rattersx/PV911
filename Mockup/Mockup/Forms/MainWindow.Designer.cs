
namespace Mockup
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Container = new System.Windows.Forms.Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.burgerMenuBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.expandBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "compress_96px.png");
            this.imageList1.Images.SetKeyName(1, "expand.png");
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 6;
            this.guna2GradientPanel1.Controls.Add(this.guna2ImageButton4);
            this.guna2GradientPanel1.Controls.Add(this.expandBtn);
            this.guna2GradientPanel1.Controls.Add(this.guna2ImageButton3);
            this.Animator.SetDecoration(this.guna2GradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1207, 46);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Animator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation3;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.Container, BunifuAnimatorNS.DecorationType.None);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(260, 46);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(947, 653);
            this.Container.TabIndex = 9;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.button1);
            this.guna2GradientPanel2.Controls.Add(this.guna2TileButton2);
            this.guna2GradientPanel2.Controls.Add(this.guna2TileButton3);
            this.guna2GradientPanel2.Controls.Add(this.burgerMenuBtn);
            this.guna2GradientPanel2.Controls.Add(this.guna2TileButton1);
            this.Animator.SetDecoration(this.guna2GradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.MediumTurquoise;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.LightCyan;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 46);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(260, 653);
            this.guna2GradientPanel2.TabIndex = 20;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Animated = true;
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.Animator.SetDecoration(this.guna2TileButton2, BunifuAnimatorNS.DecorationType.None);
            this.guna2TileButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Image = global::Mockup.Properties.Resources.paid_bill_96px;
            this.guna2TileButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TileButton2.ImageOffset = new System.Drawing.Point(0, 17);
            this.guna2TileButton2.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2TileButton2.Location = new System.Drawing.Point(0, 385);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(260, 35);
            this.guna2TileButton2.TabIndex = 18;
            this.guna2TileButton2.Text = "Редактор";
            this.guna2TileButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2TileButton2.TextOffset = new System.Drawing.Point(0, -20);
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.Animated = true;
            this.guna2TileButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.CheckedState.Parent = this.guna2TileButton3;
            this.guna2TileButton3.CustomImages.Parent = this.guna2TileButton3;
            this.Animator.SetDecoration(this.guna2TileButton3, BunifuAnimatorNS.DecorationType.None);
            this.guna2TileButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TileButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton3.HoverState.Parent = this.guna2TileButton3;
            this.guna2TileButton3.Image = global::Mockup.Properties.Resources.paid_bill_96px;
            this.guna2TileButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TileButton3.ImageOffset = new System.Drawing.Point(0, 17);
            this.guna2TileButton3.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2TileButton3.Location = new System.Drawing.Point(0, 316);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.ShadowDecoration.Parent = this.guna2TileButton3;
            this.guna2TileButton3.Size = new System.Drawing.Size(260, 35);
            this.guna2TileButton3.TabIndex = 19;
            this.guna2TileButton3.Text = "Расчёт потребления";
            this.guna2TileButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2TileButton3.TextOffset = new System.Drawing.Point(0, -20);
            // 
            // burgerMenuBtn
            // 
            this.burgerMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.burgerMenuBtn.CheckedState.Parent = this.burgerMenuBtn;
            this.Animator.SetDecoration(this.burgerMenuBtn, BunifuAnimatorNS.DecorationType.None);
            this.burgerMenuBtn.HoverState.Parent = this.burgerMenuBtn;
            this.burgerMenuBtn.Image = global::Mockup.Properties.Resources.BurgerMenu1;
            this.burgerMenuBtn.ImageSize = new System.Drawing.Size(48, 48);
            this.burgerMenuBtn.Location = new System.Drawing.Point(225, 6);
            this.burgerMenuBtn.Name = "burgerMenuBtn";
            this.burgerMenuBtn.PressedState.Parent = this.burgerMenuBtn;
            this.burgerMenuBtn.Size = new System.Drawing.Size(32, 32);
            this.burgerMenuBtn.TabIndex = 16;
            this.burgerMenuBtn.Click += new System.EventHandler(this.burgerMenuBtn_Click);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Animated = true;
            this.guna2TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.Animator.SetDecoration(this.guna2TileButton1, BunifuAnimatorNS.DecorationType.None);
            this.guna2TileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Image = global::Mockup.Properties.Resources.paid_bill_96px;
            this.guna2TileButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TileButton1.ImageOffset = new System.Drawing.Point(0, 17);
            this.guna2TileButton1.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2TileButton1.Location = new System.Drawing.Point(0, 247);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(260, 35);
            this.guna2TileButton1.TabIndex = 17;
            this.guna2TileButton1.Text = "Каллорийность";
            this.guna2TileButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2TileButton1.TextOffset = new System.Drawing.Point(0, -20);
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.Animator.SetDecoration(this.guna2ImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.guna2ImageButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = global::Mockup.Properties.Resources.rollDown1;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton4.Location = new System.Drawing.Point(1096, 0);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(37, 46);
            this.guna2ImageButton4.TabIndex = 7;
            this.guna2ImageButton4.Click += new System.EventHandler(this.guna2ImageButton4_Click);
            // 
            // expandBtn
            // 
            this.expandBtn.BackColor = System.Drawing.Color.Transparent;
            this.expandBtn.CheckedState.Parent = this.expandBtn;
            this.Animator.SetDecoration(this.expandBtn, BunifuAnimatorNS.DecorationType.None);
            this.expandBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandBtn.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.expandBtn.HoverState.Parent = this.expandBtn;
            this.expandBtn.Image = global::Mockup.Properties.Resources.compress_96px1;
            this.expandBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.expandBtn.Location = new System.Drawing.Point(1133, 0);
            this.expandBtn.Name = "expandBtn";
            this.expandBtn.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.expandBtn.PressedState.Parent = this.expandBtn;
            this.expandBtn.Size = new System.Drawing.Size(37, 46);
            this.expandBtn.TabIndex = 2;
            this.expandBtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.Animator.SetDecoration(this.guna2ImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.guna2ImageButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::Mockup.Properties.Resources.exit1;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton3.Location = new System.Drawing.Point(1170, 0);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(37, 46);
            this.guna2ImageButton3.TabIndex = 4;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // button1
            // 
            this.Animator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(68, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1207, 699);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton expandBtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2ImageButton burgerMenuBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.Panel Container;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

