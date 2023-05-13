namespace Sapphire_LITE {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.FadeInTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlbar = new System.Windows.Forms.Panel();
            this.watermarkImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.leftCpsSlider = new FlatUI.FlatTrackBar();
            this.rightClickerBindButton = new System.Windows.Forms.Label();
            this.leftClickerBindButton = new System.Windows.Forms.Label();
            this.presetSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toggleSmartMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.randomizationText = new System.Windows.Forms.Label();
            this.toggleAlwaysOn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.randomizationSlider = new FlatUI.FlatTrackBar();
            this.toggleShiftDisable = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rightCpsText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toggleRandomization = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rightCpsSlider = new FlatUI.FlatTrackBar();
            this.leftCpsText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dragBar = new System.Windows.Forms.Panel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.controlbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FadeInTimer
            // 
            this.FadeInTimer.Enabled = true;
            this.FadeInTimer.Interval = 25;
            this.FadeInTimer.Tick += new System.EventHandler(this.FadeInTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.controlbar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dragBar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 336);
            this.panel1.TabIndex = 0;
            // 
            // controlbar
            // 
            this.controlbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.controlbar.Controls.Add(this.watermarkImage);
            this.controlbar.Controls.Add(this.pictureBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox2);
            this.controlbar.Controls.Add(this.guna2ControlBox1);
            this.controlbar.Controls.Add(this.panel7);
            this.controlbar.Location = new System.Drawing.Point(0, 5);
            this.controlbar.Name = "controlbar";
            this.controlbar.Size = new System.Drawing.Size(461, 45);
            this.controlbar.TabIndex = 4;
            // 
            // watermarkImage
            // 
            this.watermarkImage.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Watermark;
            this.watermarkImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watermarkImage.Location = new System.Drawing.Point(32, 5);
            this.watermarkImage.Name = "watermarkImage";
            this.watermarkImage.Size = new System.Drawing.Size(139, 35);
            this.watermarkImage.TabIndex = 6;
            this.watermarkImage.TabStop = false;
            this.watermarkImage.Click += new System.EventHandler(this.watermarkImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Sapphire_LITE.Properties.Resources.Logo_with_glow___backgdasdsround;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(338, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 44);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(386, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(47, 44);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 52);
            this.panel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(18, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 248);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.leftCpsSlider);
            this.panel4.Controls.Add(this.rightClickerBindButton);
            this.panel4.Controls.Add(this.leftClickerBindButton);
            this.panel4.Controls.Add(this.presetSelector);
            this.panel4.Controls.Add(this.toggleSmartMode);
            this.panel4.Controls.Add(this.randomizationText);
            this.panel4.Controls.Add(this.toggleAlwaysOn);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.randomizationSlider);
            this.panel4.Controls.Add(this.toggleShiftDisable);
            this.panel4.Controls.Add(this.rightCpsText);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.toggleRandomization);
            this.panel4.Controls.Add(this.rightCpsSlider);
            this.panel4.Controls.Add(this.leftCpsText);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 246);
            this.panel4.TabIndex = 4;
            // 
            // leftCpsSlider
            // 
            this.leftCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftCpsSlider.Decimal = false;
            this.leftCpsSlider.FloatValue = 0D;
            this.leftCpsSlider.Full = false;
            this.leftCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftCpsSlider.Location = new System.Drawing.Point(17, 70);
            this.leftCpsSlider.Maximum = 300;
            this.leftCpsSlider.Minimum = 50;
            this.leftCpsSlider.Name = "leftCpsSlider";
            this.leftCpsSlider.ShowValue = false;
            this.leftCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.leftCpsSlider.TabIndex = 2;
            this.leftCpsSlider.Text = "flatTrackBar1";
            this.ToolTip.SetToolTip(this.leftCpsSlider, "Average amount of left clicks that will be sent to the game");
            this.leftCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.leftCpsSlider.Value = 125;
            this.leftCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.leftCpsSlider_Scroll);
            // 
            // rightClickerBindButton
            // 
            this.rightClickerBindButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightClickerBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rightClickerBindButton.Location = new System.Drawing.Point(67, 94);
            this.rightClickerBindButton.Name = "rightClickerBindButton";
            this.rightClickerBindButton.Size = new System.Drawing.Size(134, 17);
            this.rightClickerBindButton.TabIndex = 15;
            this.rightClickerBindButton.Text = "[none]";
            this.rightClickerBindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightClickerBindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightClickerBindButton_MouseDown);
            // 
            // leftClickerBindButton
            // 
            this.leftClickerBindButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftClickerBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.leftClickerBindButton.Location = new System.Drawing.Point(59, 50);
            this.leftClickerBindButton.Name = "leftClickerBindButton";
            this.leftClickerBindButton.Size = new System.Drawing.Size(134, 17);
            this.leftClickerBindButton.TabIndex = 14;
            this.leftClickerBindButton.Text = "[none]";
            this.leftClickerBindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftClickerBindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftClickerBindButton_MouseDown);
            // 
            // presetSelector
            // 
            this.presetSelector.Animated = true;
            this.presetSelector.BackColor = System.Drawing.Color.Transparent;
            this.presetSelector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.presetSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.presetSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetSelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.presetSelector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetSelector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.presetSelector.FocusedState.Parent = this.presetSelector;
            this.presetSelector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.presetSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.presetSelector.FormattingEnabled = true;
            this.presetSelector.HoverState.Parent = this.presetSelector;
            this.presetSelector.ItemHeight = 30;
            this.presetSelector.Items.AddRange(new object[] {
            "Default",
            "Low CPS",
            "High CPS"});
            this.presetSelector.ItemsAppearance.Parent = this.presetSelector;
            this.presetSelector.Location = new System.Drawing.Point(231, 186);
            this.presetSelector.Name = "presetSelector";
            this.presetSelector.ShadowDecoration.Parent = this.presetSelector;
            this.presetSelector.Size = new System.Drawing.Size(141, 36);
            this.presetSelector.StartIndex = 0;
            this.presetSelector.TabIndex = 13;
            this.ToolTip.SetToolTip(this.presetSelector, "Allows you to set a preset depending on what cps you want.");
            this.presetSelector.SelectedIndexChanged += new System.EventHandler(this.presetSelector_SelectedIndexChanged);
            // 
            // toggleSmartMode
            // 
            this.toggleSmartMode.Animated = true;
            this.toggleSmartMode.AutoSize = true;
            this.toggleSmartMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleSmartMode.CheckedState.BorderRadius = 1;
            this.toggleSmartMode.CheckedState.BorderThickness = 0;
            this.toggleSmartMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleSmartMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toggleSmartMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleSmartMode.Location = new System.Drawing.Point(128, 207);
            this.toggleSmartMode.Name = "toggleSmartMode";
            this.toggleSmartMode.Size = new System.Drawing.Size(90, 19);
            this.toggleSmartMode.TabIndex = 8;
            this.toggleSmartMode.Text = "smart mode";
            this.ToolTip.SetToolTip(this.toggleSmartMode, "Disables the clicker when a menu/inventory is detected. Re-activate if quick refi" +
        "lling is detected.");
            this.toggleSmartMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleSmartMode.UncheckedState.BorderRadius = 1;
            this.toggleSmartMode.UncheckedState.BorderThickness = 0;
            this.toggleSmartMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleSmartMode.UseVisualStyleBackColor = true;
            this.toggleSmartMode.CheckedChanged += new System.EventHandler(this.toggleSmartMode_CheckedChanged);
            // 
            // randomizationText
            // 
            this.randomizationText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizationText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.randomizationText.Location = new System.Drawing.Point(192, 139);
            this.randomizationText.Name = "randomizationText";
            this.randomizationText.Size = new System.Drawing.Size(180, 17);
            this.randomizationText.TabIndex = 12;
            this.randomizationText.Text = "25%";
            this.randomizationText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleAlwaysOn
            // 
            this.toggleAlwaysOn.Animated = true;
            this.toggleAlwaysOn.AutoSize = true;
            this.toggleAlwaysOn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleAlwaysOn.CheckedState.BorderRadius = 1;
            this.toggleAlwaysOn.CheckedState.BorderThickness = 0;
            this.toggleAlwaysOn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleAlwaysOn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toggleAlwaysOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleAlwaysOn.Location = new System.Drawing.Point(128, 186);
            this.toggleAlwaysOn.Name = "toggleAlwaysOn";
            this.toggleAlwaysOn.Size = new System.Drawing.Size(78, 19);
            this.toggleAlwaysOn.TabIndex = 7;
            this.toggleAlwaysOn.Text = "always on";
            this.ToolTip.SetToolTip(this.toggleAlwaysOn, "Allows left or right clicker to click automatically when they\'re enabled.");
            this.toggleAlwaysOn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleAlwaysOn.UncheckedState.BorderRadius = 1;
            this.toggleAlwaysOn.UncheckedState.BorderThickness = 0;
            this.toggleAlwaysOn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleAlwaysOn.UseVisualStyleBackColor = true;
            this.toggleAlwaysOn.CheckedChanged += new System.EventHandler(this.toggleAlwaysOn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(16, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "randomization distribution";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.label7, "The slight MS adjustment applied to the existing randomized cps.");
            // 
            // randomizationSlider
            // 
            this.randomizationSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.randomizationSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.randomizationSlider.Decimal = false;
            this.randomizationSlider.FloatValue = 0D;
            this.randomizationSlider.Full = false;
            this.randomizationSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.Location = new System.Drawing.Point(17, 159);
            this.randomizationSlider.Maximum = 100;
            this.randomizationSlider.Minimum = 1;
            this.randomizationSlider.Name = "randomizationSlider";
            this.randomizationSlider.ShowValue = false;
            this.randomizationSlider.Size = new System.Drawing.Size(355, 12);
            this.randomizationSlider.TabIndex = 10;
            this.randomizationSlider.Text = "flatTrackBar3";
            this.ToolTip.SetToolTip(this.randomizationSlider, "The amount of deviation the randomization is allowed to have from its intended cp" +
        "s");
            this.randomizationSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.randomizationSlider.Value = 25;
            this.randomizationSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.jitterSlider_Scroll);
            // 
            // toggleShiftDisable
            // 
            this.toggleShiftDisable.Animated = true;
            this.toggleShiftDisable.AutoSize = true;
            this.toggleShiftDisable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleShiftDisable.CheckedState.BorderRadius = 1;
            this.toggleShiftDisable.CheckedState.BorderThickness = 0;
            this.toggleShiftDisable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleShiftDisable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toggleShiftDisable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleShiftDisable.Location = new System.Drawing.Point(19, 207);
            this.toggleShiftDisable.Name = "toggleShiftDisable";
            this.toggleShiftDisable.Size = new System.Drawing.Size(89, 19);
            this.toggleShiftDisable.TabIndex = 6;
            this.toggleShiftDisable.Text = "shift disable";
            this.ToolTip.SetToolTip(this.toggleShiftDisable, "Disables all function when the \"Shift\" key is held.");
            this.toggleShiftDisable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleShiftDisable.UncheckedState.BorderRadius = 1;
            this.toggleShiftDisable.UncheckedState.BorderThickness = 0;
            this.toggleShiftDisable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleShiftDisable.UseVisualStyleBackColor = true;
            this.toggleShiftDisable.CheckedChanged += new System.EventHandler(this.toggleShiftDisable_CheckedChanged);
            // 
            // rightCpsText
            // 
            this.rightCpsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightCpsText.Location = new System.Drawing.Point(192, 94);
            this.rightCpsText.Name = "rightCpsText";
            this.rightCpsText.Size = new System.Drawing.Size(180, 17);
            this.rightCpsText.TabIndex = 9;
            this.rightCpsText.Text = "12.5";
            this.rightCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "right cps";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleRandomization
            // 
            this.toggleRandomization.Animated = true;
            this.toggleRandomization.AutoSize = true;
            this.toggleRandomization.Checked = true;
            this.toggleRandomization.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleRandomization.CheckedState.BorderRadius = 1;
            this.toggleRandomization.CheckedState.BorderThickness = 0;
            this.toggleRandomization.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.toggleRandomization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleRandomization.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toggleRandomization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toggleRandomization.Location = new System.Drawing.Point(19, 186);
            this.toggleRandomization.Name = "toggleRandomization";
            this.toggleRandomization.Size = new System.Drawing.Size(104, 19);
            this.toggleRandomization.TabIndex = 5;
            this.toggleRandomization.Text = "randomization";
            this.ToolTip.SetToolTip(this.toggleRandomization, "Create a more \"humanized\" randomization to lower the chances of getting detected." +
        "");
            this.toggleRandomization.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleRandomization.UncheckedState.BorderRadius = 1;
            this.toggleRandomization.UncheckedState.BorderThickness = 0;
            this.toggleRandomization.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleRandomization.UseVisualStyleBackColor = true;
            this.toggleRandomization.CheckedChanged += new System.EventHandler(this.toggleRandomization_CheckedChanged);
            // 
            // rightCpsSlider
            // 
            this.rightCpsSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightCpsSlider.ColorScheme1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightCpsSlider.ColorScheme2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rightCpsSlider.Decimal = false;
            this.rightCpsSlider.FloatValue = 0D;
            this.rightCpsSlider.Full = false;
            this.rightCpsSlider.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightCpsSlider.Location = new System.Drawing.Point(17, 114);
            this.rightCpsSlider.Maximum = 300;
            this.rightCpsSlider.Minimum = 50;
            this.rightCpsSlider.Name = "rightCpsSlider";
            this.rightCpsSlider.ShowValue = false;
            this.rightCpsSlider.Size = new System.Drawing.Size(355, 12);
            this.rightCpsSlider.TabIndex = 7;
            this.rightCpsSlider.Text = "flatTrackBar2";
            this.ToolTip.SetToolTip(this.rightCpsSlider, "Average amount of right clicks that will be sent to the game");
            this.rightCpsSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.rightCpsSlider.Value = 125;
            this.rightCpsSlider.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.rightCpsSlider_Scroll);
            // 
            // leftCpsText
            // 
            this.leftCpsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftCpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftCpsText.Location = new System.Drawing.Point(192, 50);
            this.leftCpsText.Name = "leftCpsText";
            this.leftCpsText.Size = new System.Drawing.Size(180, 17);
            this.leftCpsText.TabIndex = 6;
            this.leftCpsText.Text = "12.5";
            this.leftCpsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "left cps";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.panel5.Location = new System.Drawing.Point(-139, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 5);
            this.panel5.TabIndex = 2;
            // 
            // dragBar
            // 
            this.dragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(126)))), ((int)(((byte)(226)))));
            this.dragBar.Location = new System.Drawing.Point(-3, 0);
            this.dragBar.Name = "dragBar";
            this.dragBar.Size = new System.Drawing.Size(464, 5);
            this.dragBar.TabIndex = 1;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.dragBar;
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 300;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // DragControl2
            // 
            this.DragControl2.TargetControl = this.controlbar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 338);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.controlbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watermarkImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FadeInTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dragBar;
        private FlatUI.FlatTrackBar leftCpsSlider;
        private System.Windows.Forms.Panel controlbar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label randomizationText;
        private System.Windows.Forms.Label label7;
        private FlatUI.FlatTrackBar randomizationSlider;
        private System.Windows.Forms.Label rightCpsText;
        private System.Windows.Forms.Label label5;
        private FlatUI.FlatTrackBar rightCpsSlider;
        private System.Windows.Forms.Label leftCpsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox watermarkImage;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2CheckBox toggleRandomization;
        private Guna.UI2.WinForms.Guna2ComboBox presetSelector;
        private Guna.UI2.WinForms.Guna2CheckBox toggleSmartMode;
        private Guna.UI2.WinForms.Guna2CheckBox toggleAlwaysOn;
        private Guna.UI2.WinForms.Guna2CheckBox toggleShiftDisable;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private System.Windows.Forms.Label rightClickerBindButton;
        private System.Windows.Forms.Label leftClickerBindButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
    }
}

