namespace Chrono_Count_3.Forms
{
    partial class RemoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveForm));
            groupbox_remove = new GroupBox();
            button_Remove = new Button();
            combobox_ItemDropDown = new ComboBox();
            comboBox_PageDropDown = new ComboBox();
            groupbox_remove.SuspendLayout();
            SuspendLayout();
            // 
            // groupbox_remove
            // 
            groupbox_remove.Controls.Add(button_Remove);
            groupbox_remove.Controls.Add(combobox_ItemDropDown);
            groupbox_remove.Controls.Add(comboBox_PageDropDown);
            groupbox_remove.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_remove.Location = new Point(15, 15);
            groupbox_remove.Margin = new Padding(6);
            groupbox_remove.Name = "groupbox_remove";
            groupbox_remove.Padding = new Padding(6);
            groupbox_remove.Size = new Size(623, 143);
            groupbox_remove.TabIndex = 0;
            groupbox_remove.TabStop = false;
            groupbox_remove.Text = "Remove";
            // 
            // button_Remove
            // 
            button_Remove.BackColor = Color.FromArgb(128, 128, 255);
            button_Remove.FlatAppearance.BorderColor = Color.White;
            button_Remove.FlatStyle = FlatStyle.Flat;
            button_Remove.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Remove.Location = new Point(7, 72);
            button_Remove.Margin = new Padding(4, 3, 4, 3);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(607, 54);
            button_Remove.TabIndex = 3;
            button_Remove.Text = "Remove";
            button_Remove.UseVisualStyleBackColor = false;
            button_Remove.Click += button_Remove_Click;
            // 
            // combobox_ItemDropDown
            // 
            combobox_ItemDropDown.BackColor = Color.FromArgb(160, 204, 250);
            combobox_ItemDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_ItemDropDown.FlatStyle = FlatStyle.Flat;
            combobox_ItemDropDown.FormattingEnabled = true;
            combobox_ItemDropDown.Location = new Point(87, 34);
            combobox_ItemDropDown.Margin = new Padding(4, 3, 4, 3);
            combobox_ItemDropDown.Name = "combobox_ItemDropDown";
            combobox_ItemDropDown.Size = new Size(527, 32);
            combobox_ItemDropDown.TabIndex = 2;
            // 
            // comboBox_PageDropDown
            // 
            comboBox_PageDropDown.BackColor = Color.FromArgb(160, 204, 250);
            comboBox_PageDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_PageDropDown.FlatStyle = FlatStyle.Flat;
            comboBox_PageDropDown.FormattingEnabled = true;
            comboBox_PageDropDown.Location = new Point(7, 34);
            comboBox_PageDropDown.Margin = new Padding(4, 3, 4, 3);
            comboBox_PageDropDown.Name = "comboBox_PageDropDown";
            comboBox_PageDropDown.Size = new Size(72, 32);
            comboBox_PageDropDown.TabIndex = 1;
            comboBox_PageDropDown.SelectedIndexChanged += comboBox_PageDropDown_SelectedIndexChanged;
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 116, 212);
            ClientSize = new Size(654, 173);
            Controls.Add(groupbox_remove);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Remove Item";
            groupbox_remove.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox groupbox_remove;
        private Button button_Remove;
        private ComboBox combobox_ItemDropDown;
        private ComboBox comboBox_PageDropDown;
    }
}