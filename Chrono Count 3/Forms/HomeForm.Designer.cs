namespace Chrono_Count_3
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label_PageDisplay = new Label();
            button_MovePageLeft = new Button();
            button_MovePageRight = new Button();
            button_OpenSettingsForm = new Button();
            textbox_CurrentTime = new TextBox();
            button_OpenRemoveForm = new Button();
            button_OpenCreateForm = new Button();
            listbox_MainDisplay = new ListBox();
            timer_GameTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label_PageDisplay
            // 
            label_PageDisplay.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_PageDisplay.Location = new Point(408, 12);
            label_PageDisplay.Margin = new Padding(4, 0, 4, 0);
            label_PageDisplay.Name = "label_PageDisplay";
            label_PageDisplay.Size = new Size(178, 39);
            label_PageDisplay.TabIndex = 0;
            label_PageDisplay.Text = "#/#";
            label_PageDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_MovePageLeft
            // 
            button_MovePageLeft.BackColor = Color.FromArgb(128, 128, 255);
            button_MovePageLeft.BackgroundImage = Properties.Resources.LeftArrow;
            button_MovePageLeft.BackgroundImageLayout = ImageLayout.Stretch;
            button_MovePageLeft.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_MovePageLeft.FlatStyle = FlatStyle.Flat;
            button_MovePageLeft.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_MovePageLeft.Location = new Point(353, 12);
            button_MovePageLeft.Margin = new Padding(4, 3, 4, 3);
            button_MovePageLeft.Name = "button_MovePageLeft";
            button_MovePageLeft.Size = new Size(47, 39);
            button_MovePageLeft.TabIndex = 1;
            button_MovePageLeft.UseVisualStyleBackColor = false;
            button_MovePageLeft.Click += button_MovePageLeft_Click;
            // 
            // button_MovePageRight
            // 
            button_MovePageRight.BackColor = Color.FromArgb(128, 128, 255);
            button_MovePageRight.BackgroundImage = Properties.Resources.RightArrow;
            button_MovePageRight.BackgroundImageLayout = ImageLayout.Stretch;
            button_MovePageRight.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_MovePageRight.FlatStyle = FlatStyle.Flat;
            button_MovePageRight.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_MovePageRight.Location = new Point(594, 12);
            button_MovePageRight.Margin = new Padding(4, 3, 4, 3);
            button_MovePageRight.Name = "button_MovePageRight";
            button_MovePageRight.Size = new Size(47, 39);
            button_MovePageRight.TabIndex = 2;
            button_MovePageRight.UseVisualStyleBackColor = false;
            button_MovePageRight.Click += button_MovePageRight_Click;
            // 
            // button_OpenSettingsForm
            // 
            button_OpenSettingsForm.BackColor = Color.FromArgb(128, 128, 255);
            button_OpenSettingsForm.BackgroundImage = Properties.Resources.Settings;
            button_OpenSettingsForm.BackgroundImageLayout = ImageLayout.Stretch;
            button_OpenSettingsForm.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_OpenSettingsForm.FlatStyle = FlatStyle.Flat;
            button_OpenSettingsForm.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_OpenSettingsForm.Location = new Point(649, 12);
            button_OpenSettingsForm.Margin = new Padding(4, 3, 4, 3);
            button_OpenSettingsForm.Name = "button_OpenSettingsForm";
            button_OpenSettingsForm.Size = new Size(39, 39);
            button_OpenSettingsForm.TabIndex = 5;
            button_OpenSettingsForm.UseVisualStyleBackColor = false;
            button_OpenSettingsForm.Click += button_OpenSettingsForm_Click;
            // 
            // textbox_CurrentTime
            // 
            textbox_CurrentTime.BackColor = Color.FromArgb(160, 204, 250);
            textbox_CurrentTime.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_CurrentTime.Location = new Point(13, 12);
            textbox_CurrentTime.Margin = new Padding(4, 3, 4, 3);
            textbox_CurrentTime.MaximumSize = new Size(10000, 39);
            textbox_CurrentTime.MinimumSize = new Size(0, 39);
            textbox_CurrentTime.Name = "textbox_CurrentTime";
            textbox_CurrentTime.ReadOnly = true;
            textbox_CurrentTime.Size = new Size(335, 39);
            textbox_CurrentTime.TabIndex = 0;
            textbox_CurrentTime.TabStop = false;
            // 
            // button_OpenRemoveForm
            // 
            button_OpenRemoveForm.BackColor = Color.FromArgb(128, 128, 255);
            button_OpenRemoveForm.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_OpenRemoveForm.FlatStyle = FlatStyle.Flat;
            button_OpenRemoveForm.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_OpenRemoveForm.Location = new Point(353, 57);
            button_OpenRemoveForm.Margin = new Padding(4, 3, 4, 3);
            button_OpenRemoveForm.Name = "button_OpenRemoveForm";
            button_OpenRemoveForm.Size = new Size(335, 65);
            button_OpenRemoveForm.TabIndex = 4;
            button_OpenRemoveForm.Text = "Remove";
            button_OpenRemoveForm.UseVisualStyleBackColor = false;
            button_OpenRemoveForm.Click += button_OpenRemoveForm_Click;
            // 
            // button_OpenCreateForm
            // 
            button_OpenCreateForm.BackColor = Color.FromArgb(128, 128, 255);
            button_OpenCreateForm.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_OpenCreateForm.FlatStyle = FlatStyle.Flat;
            button_OpenCreateForm.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_OpenCreateForm.Location = new Point(13, 57);
            button_OpenCreateForm.Margin = new Padding(4, 3, 4, 3);
            button_OpenCreateForm.Name = "button_OpenCreateForm";
            button_OpenCreateForm.Size = new Size(335, 65);
            button_OpenCreateForm.TabIndex = 3;
            button_OpenCreateForm.Text = "Create";
            button_OpenCreateForm.UseVisualStyleBackColor = false;
            button_OpenCreateForm.Click += button_OpenCreateForm_Click;
            // 
            // listbox_MainDisplay
            // 
            listbox_MainDisplay.BackColor = Color.FromArgb(160, 204, 250);
            listbox_MainDisplay.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbox_MainDisplay.FormattingEnabled = true;
            listbox_MainDisplay.IntegralHeight = false;
            listbox_MainDisplay.ItemHeight = 24;
            listbox_MainDisplay.Location = new Point(14, 128);
            listbox_MainDisplay.Margin = new Padding(4, 3, 4, 3);
            listbox_MainDisplay.Name = "listbox_MainDisplay";
            listbox_MainDisplay.SelectionMode = SelectionMode.None;
            listbox_MainDisplay.Size = new Size(675, 32);
            listbox_MainDisplay.TabIndex = 0;
            listbox_MainDisplay.TabStop = false;
            // 
            // timer_GameTime
            // 
            timer_GameTime.Enabled = true;
            timer_GameTime.Interval = 500;
            timer_GameTime.Tick += timer_GameTime_Tick;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 116, 212);
            ClientSize = new Size(702, 172);
            Controls.Add(label_PageDisplay);
            Controls.Add(button_MovePageLeft);
            Controls.Add(button_MovePageRight);
            Controls.Add(button_OpenSettingsForm);
            Controls.Add(textbox_CurrentTime);
            Controls.Add(button_OpenRemoveForm);
            Controls.Add(button_OpenCreateForm);
            Controls.Add(listbox_MainDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(2000, 10000);
            MinimizeBox = false;
            MinimumSize = new Size(500, 0);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChronoCount3";
            ResizeEnd += HomeForm_ResizeEnd;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_PageDisplay;
        internal Button button_MovePageLeft;
        internal Button button_MovePageRight;
        internal Button button_OpenSettingsForm;
        internal TextBox textbox_CurrentTime;
        internal Button button_OpenRemoveForm;
        internal Button button_OpenCreateForm;
        internal ListBox listbox_MainDisplay;
        private System.Windows.Forms.Timer timer_GameTime;
    }
}
