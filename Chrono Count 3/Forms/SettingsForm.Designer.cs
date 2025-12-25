namespace Chrono_Count_3.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            button_SetDefault = new Button();
            button_EditToggle = new Button();
            groupbox_SettingsPage = new GroupBox();
            groupbox_Display = new GroupBox();
            combobox_DescLength = new ComboBox();
            label_ExampleTimeStamp = new Label();
            combobox_DateLength = new ComboBox();
            combobox_TimeLength = new ComboBox();
            groupbox_Colours = new GroupBox();
            BackColourIndicator = new Panel();
            MidColourIndicator = new Panel();
            ForeColourIndicator = new Panel();
            label_ForeColour = new Label();
            textbox_MidColour = new TextBox();
            textbox_ForeColour = new TextBox();
            button_EditBackColour = new Button();
            label_BackColour = new Label();
            textbox_BackColour = new TextBox();
            button_EditForeColour = new Button();
            label_MidColour = new Label();
            button_EditMidColour = new Button();
            label_ItemsPerPage = new Label();
            textbox_ItemsPerPage = new TextBox();
            groupbox_SettingsPage.SuspendLayout();
            groupbox_Display.SuspendLayout();
            groupbox_Colours.SuspendLayout();
            SuspendLayout();
            // 
            // button_SetDefault
            // 
            button_SetDefault.BackColor = Color.FromArgb(128, 128, 255);
            button_SetDefault.FlatAppearance.BorderColor = Color.Black;
            button_SetDefault.FlatStyle = FlatStyle.Flat;
            button_SetDefault.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SetDefault.Location = new Point(13, 92);
            button_SetDefault.Margin = new Padding(4, 3, 4, 3);
            button_SetDefault.Name = "button_SetDefault";
            button_SetDefault.Size = new Size(496, 29);
            button_SetDefault.TabIndex = 2;
            button_SetDefault.Text = "Restore to Default Settings";
            button_SetDefault.UseVisualStyleBackColor = false;
            button_SetDefault.Click += button_SetDefault_Click;
            // 
            // button_EditToggle
            // 
            button_EditToggle.BackColor = Color.FromArgb(128, 128, 255);
            button_EditToggle.FlatAppearance.BorderColor = Color.Black;
            button_EditToggle.FlatStyle = FlatStyle.Flat;
            button_EditToggle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_EditToggle.Location = new Point(13, 12);
            button_EditToggle.Margin = new Padding(4, 3, 4, 3);
            button_EditToggle.Name = "button_EditToggle";
            button_EditToggle.Size = new Size(496, 74);
            button_EditToggle.TabIndex = 1;
            button_EditToggle.Text = "Click to Edit Settings";
            button_EditToggle.UseVisualStyleBackColor = false;
            button_EditToggle.Click += button_EditToggle_Click;
            // 
            // groupbox_SettingsPage
            // 
            groupbox_SettingsPage.Controls.Add(groupbox_Display);
            groupbox_SettingsPage.Controls.Add(groupbox_Colours);
            groupbox_SettingsPage.Controls.Add(label_ItemsPerPage);
            groupbox_SettingsPage.Controls.Add(textbox_ItemsPerPage);
            groupbox_SettingsPage.Font = new Font("Consolas", 15.75F);
            groupbox_SettingsPage.Location = new Point(13, 127);
            groupbox_SettingsPage.Margin = new Padding(4, 3, 4, 3);
            groupbox_SettingsPage.Name = "groupbox_SettingsPage";
            groupbox_SettingsPage.Padding = new Padding(4, 3, 4, 3);
            groupbox_SettingsPage.Size = new Size(496, 390);
            groupbox_SettingsPage.TabIndex = 5;
            groupbox_SettingsPage.TabStop = false;
            groupbox_SettingsPage.Text = "Settings";
            // 
            // groupbox_Display
            // 
            groupbox_Display.Controls.Add(combobox_DescLength);
            groupbox_Display.Controls.Add(label_ExampleTimeStamp);
            groupbox_Display.Controls.Add(combobox_DateLength);
            groupbox_Display.Controls.Add(combobox_TimeLength);
            groupbox_Display.Location = new Point(7, 73);
            groupbox_Display.Name = "groupbox_Display";
            groupbox_Display.Size = new Size(478, 147);
            groupbox_Display.TabIndex = 35;
            groupbox_Display.TabStop = false;
            groupbox_Display.Text = "Item Display";
            // 
            // combobox_DescLength
            // 
            combobox_DescLength.BackColor = Color.FromArgb(128, 128, 255);
            combobox_DescLength.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_DescLength.FlatStyle = FlatStyle.Popup;
            combobox_DescLength.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_DescLength.FormattingEnabled = true;
            combobox_DescLength.Location = new Point(6, 31);
            combobox_DescLength.Name = "combobox_DescLength";
            combobox_DescLength.Size = new Size(150, 32);
            combobox_DescLength.TabIndex = 4;
            combobox_DescLength.SelectionChangeCommitted += combobox_DescLength_SelectionChangeCommitted;
            // 
            // label_ExampleTimeStamp
            // 
            label_ExampleTimeStamp.BackColor = Color.FromArgb(160, 204, 250);
            label_ExampleTimeStamp.BorderStyle = BorderStyle.FixedSingle;
            label_ExampleTimeStamp.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ExampleTimeStamp.Location = new Point(6, 66);
            label_ExampleTimeStamp.Name = "label_ExampleTimeStamp";
            label_ExampleTimeStamp.Size = new Size(462, 68);
            label_ExampleTimeStamp.TabIndex = 34;
            label_ExampleTimeStamp.Text = "---------------------------------------------\r\n---------------------------------------------\r\n---------------------------------------------";
            // 
            // combobox_DateLength
            // 
            combobox_DateLength.BackColor = Color.FromArgb(128, 128, 255);
            combobox_DateLength.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_DateLength.FlatStyle = FlatStyle.Popup;
            combobox_DateLength.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_DateLength.FormattingEnabled = true;
            combobox_DateLength.Location = new Point(162, 31);
            combobox_DateLength.Name = "combobox_DateLength";
            combobox_DateLength.Size = new Size(150, 32);
            combobox_DateLength.TabIndex = 5;
            combobox_DateLength.SelectionChangeCommitted += combobox_DateLength_SelectionChangeCommitted;
            // 
            // combobox_TimeLength
            // 
            combobox_TimeLength.BackColor = Color.FromArgb(128, 128, 255);
            combobox_TimeLength.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_TimeLength.FlatStyle = FlatStyle.Popup;
            combobox_TimeLength.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_TimeLength.FormattingEnabled = true;
            combobox_TimeLength.Location = new Point(318, 31);
            combobox_TimeLength.Name = "combobox_TimeLength";
            combobox_TimeLength.Size = new Size(150, 32);
            combobox_TimeLength.TabIndex = 6;
            combobox_TimeLength.SelectionChangeCommitted += combobox_TimeLength_SelectionChangeCommitted;
            // 
            // groupbox_Colours
            // 
            groupbox_Colours.Controls.Add(BackColourIndicator);
            groupbox_Colours.Controls.Add(MidColourIndicator);
            groupbox_Colours.Controls.Add(ForeColourIndicator);
            groupbox_Colours.Controls.Add(label_ForeColour);
            groupbox_Colours.Controls.Add(textbox_MidColour);
            groupbox_Colours.Controls.Add(textbox_ForeColour);
            groupbox_Colours.Controls.Add(button_EditBackColour);
            groupbox_Colours.Controls.Add(label_BackColour);
            groupbox_Colours.Controls.Add(textbox_BackColour);
            groupbox_Colours.Controls.Add(button_EditForeColour);
            groupbox_Colours.Controls.Add(label_MidColour);
            groupbox_Colours.Controls.Add(button_EditMidColour);
            groupbox_Colours.Location = new Point(7, 226);
            groupbox_Colours.Name = "groupbox_Colours";
            groupbox_Colours.Size = new Size(478, 156);
            groupbox_Colours.TabIndex = 10;
            groupbox_Colours.TabStop = false;
            groupbox_Colours.Text = "Colours";
            // 
            // BackColourIndicator
            // 
            BackColourIndicator.BorderStyle = BorderStyle.FixedSingle;
            BackColourIndicator.Location = new Point(278, 111);
            BackColourIndicator.Name = "BackColourIndicator";
            BackColourIndicator.Size = new Size(90, 33);
            BackColourIndicator.TabIndex = 31;
            // 
            // MidColourIndicator
            // 
            MidColourIndicator.BorderStyle = BorderStyle.FixedSingle;
            MidColourIndicator.Location = new Point(278, 67);
            MidColourIndicator.Name = "MidColourIndicator";
            MidColourIndicator.Size = new Size(90, 33);
            MidColourIndicator.TabIndex = 30;
            // 
            // ForeColourIndicator
            // 
            ForeColourIndicator.BorderStyle = BorderStyle.FixedSingle;
            ForeColourIndicator.Location = new Point(278, 28);
            ForeColourIndicator.Name = "ForeColourIndicator";
            ForeColourIndicator.Size = new Size(90, 33);
            ForeColourIndicator.TabIndex = 29;
            // 
            // label_ForeColour
            // 
            label_ForeColour.AutoSize = true;
            label_ForeColour.Font = new Font("Consolas", 18F);
            label_ForeColour.Location = new Point(7, 28);
            label_ForeColour.Margin = new Padding(4, 0, 4, 0);
            label_ForeColour.Name = "label_ForeColour";
            label_ForeColour.Size = new Size(77, 28);
            label_ForeColour.TabIndex = 20;
            label_ForeColour.Text = "Fore:";
            label_ForeColour.TextAlign = ContentAlignment.TopRight;
            // 
            // textbox_MidColour
            // 
            textbox_MidColour.BackColor = Color.FromArgb(160, 204, 250);
            textbox_MidColour.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_MidColour.Location = new Point(92, 67);
            textbox_MidColour.Margin = new Padding(4, 3, 4, 3);
            textbox_MidColour.Name = "textbox_MidColour";
            textbox_MidColour.ReadOnly = true;
            textbox_MidColour.Size = new Size(180, 36);
            textbox_MidColour.TabIndex = 28;
            textbox_MidColour.TabStop = false;
            // 
            // textbox_ForeColour
            // 
            textbox_ForeColour.BackColor = Color.FromArgb(160, 204, 250);
            textbox_ForeColour.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_ForeColour.Location = new Point(92, 25);
            textbox_ForeColour.Margin = new Padding(4, 3, 4, 3);
            textbox_ForeColour.Name = "textbox_ForeColour";
            textbox_ForeColour.ReadOnly = true;
            textbox_ForeColour.Size = new Size(180, 36);
            textbox_ForeColour.TabIndex = 26;
            textbox_ForeColour.TabStop = false;
            // 
            // button_EditBackColour
            // 
            button_EditBackColour.BackColor = Color.FromArgb(128, 128, 255);
            button_EditBackColour.FlatAppearance.BorderColor = Color.Black;
            button_EditBackColour.FlatStyle = FlatStyle.Flat;
            button_EditBackColour.Location = new Point(375, 111);
            button_EditBackColour.Margin = new Padding(4, 3, 4, 3);
            button_EditBackColour.Name = "button_EditBackColour";
            button_EditBackColour.Size = new Size(88, 33);
            button_EditBackColour.TabIndex = 9;
            button_EditBackColour.Text = "Edit";
            button_EditBackColour.UseVisualStyleBackColor = false;
            button_EditBackColour.Click += button_EditBackColour_Click;
            // 
            // label_BackColour
            // 
            label_BackColour.AutoSize = true;
            label_BackColour.Font = new Font("Consolas", 18F);
            label_BackColour.Location = new Point(7, 112);
            label_BackColour.Margin = new Padding(4, 0, 4, 0);
            label_BackColour.Name = "label_BackColour";
            label_BackColour.Size = new Size(77, 28);
            label_BackColour.TabIndex = 22;
            label_BackColour.Text = "Back:";
            // 
            // textbox_BackColour
            // 
            textbox_BackColour.BackColor = Color.FromArgb(160, 204, 250);
            textbox_BackColour.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_BackColour.Location = new Point(92, 110);
            textbox_BackColour.Margin = new Padding(4, 3, 4, 3);
            textbox_BackColour.Name = "textbox_BackColour";
            textbox_BackColour.ReadOnly = true;
            textbox_BackColour.Size = new Size(180, 36);
            textbox_BackColour.TabIndex = 27;
            textbox_BackColour.TabStop = false;
            // 
            // button_EditForeColour
            // 
            button_EditForeColour.BackColor = Color.FromArgb(128, 128, 255);
            button_EditForeColour.FlatAppearance.BorderColor = Color.Black;
            button_EditForeColour.FlatStyle = FlatStyle.Flat;
            button_EditForeColour.Location = new Point(375, 27);
            button_EditForeColour.Margin = new Padding(4, 3, 4, 3);
            button_EditForeColour.Name = "button_EditForeColour";
            button_EditForeColour.Size = new Size(88, 33);
            button_EditForeColour.TabIndex = 7;
            button_EditForeColour.Text = "Edit";
            button_EditForeColour.UseVisualStyleBackColor = false;
            button_EditForeColour.Click += button_EditForeColour_Click;
            // 
            // label_MidColour
            // 
            label_MidColour.AutoSize = true;
            label_MidColour.Font = new Font("Consolas", 18F);
            label_MidColour.Location = new Point(20, 70);
            label_MidColour.Margin = new Padding(4, 0, 4, 0);
            label_MidColour.Name = "label_MidColour";
            label_MidColour.Size = new Size(64, 28);
            label_MidColour.TabIndex = 21;
            label_MidColour.Text = "Mid:";
            // 
            // button_EditMidColour
            // 
            button_EditMidColour.BackColor = Color.FromArgb(128, 128, 255);
            button_EditMidColour.FlatAppearance.BorderColor = Color.Black;
            button_EditMidColour.FlatStyle = FlatStyle.Flat;
            button_EditMidColour.Location = new Point(375, 67);
            button_EditMidColour.Margin = new Padding(4, 3, 4, 3);
            button_EditMidColour.Name = "button_EditMidColour";
            button_EditMidColour.Size = new Size(88, 33);
            button_EditMidColour.TabIndex = 8;
            button_EditMidColour.Text = "Edit";
            button_EditMidColour.UseVisualStyleBackColor = false;
            button_EditMidColour.Click += button_EditMidColour_Click;
            // 
            // label_ItemsPerPage
            // 
            label_ItemsPerPage.AutoSize = true;
            label_ItemsPerPage.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ItemsPerPage.Location = new Point(7, 34);
            label_ItemsPerPage.Margin = new Padding(4, 0, 4, 0);
            label_ItemsPerPage.Name = "label_ItemsPerPage";
            label_ItemsPerPage.Size = new Size(155, 28);
            label_ItemsPerPage.TabIndex = 16;
            label_ItemsPerPage.Text = "Items/Page:";
            // 
            // textbox_ItemsPerPage
            // 
            textbox_ItemsPerPage.BackColor = Color.FromArgb(160, 204, 250);
            textbox_ItemsPerPage.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_ItemsPerPage.Location = new Point(170, 31);
            textbox_ItemsPerPage.Margin = new Padding(4, 3, 4, 3);
            textbox_ItemsPerPage.MaxLength = 4;
            textbox_ItemsPerPage.Name = "textbox_ItemsPerPage";
            textbox_ItemsPerPage.Size = new Size(60, 36);
            textbox_ItemsPerPage.TabIndex = 3;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 116, 212);
            ClientSize = new Size(523, 522);
            Controls.Add(groupbox_SettingsPage);
            Controls.Add(button_SetDefault);
            Controls.Add(button_EditToggle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings Form";
            Load += SettingsForm_Load;
            groupbox_SettingsPage.ResumeLayout(false);
            groupbox_SettingsPage.PerformLayout();
            groupbox_Display.ResumeLayout(false);
            groupbox_Colours.ResumeLayout(false);
            groupbox_Colours.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_SetDefault;
        private Button button_EditToggle;
        private GroupBox groupbox_SettingsPage;
        private Button button_EditBackColour;
        private Button button_EditMidColour;
        private Button button_EditForeColour;
        private Label label_BackColour;
        private Label label_MidColour;
        private Label label_ForeColour;
        private Label label_ItemsPerPage;
        private TextBox textbox_ItemsPerPage;
        private TextBox textbox_MidColour;
        private TextBox textbox_BackColour;
        private TextBox textbox_ForeColour;
        private GroupBox groupbox_Colours;
        private ComboBox combobox_DescLength;
        private ComboBox combobox_TimeLength;
        private ComboBox combobox_DateLength;
        private Label label_ExampleTimeStamp;
        private GroupBox groupbox_Display;
        private Panel BackColourIndicator;
        private Panel MidColourIndicator;
        private Panel ForeColourIndicator;
    }
}