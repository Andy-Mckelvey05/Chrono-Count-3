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
            GBremove = new GroupBox();
            RemoveBTN = new Button();
            DataDropDown = new ComboBox();
            PageDropDown = new ComboBox();
            GBremove.SuspendLayout();
            SuspendLayout();
            // 
            // GBremove
            // 
            GBremove.Controls.Add(RemoveBTN);
            GBremove.Controls.Add(DataDropDown);
            GBremove.Controls.Add(PageDropDown);
            GBremove.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GBremove.Location = new Point(15, 15);
            GBremove.Margin = new Padding(6);
            GBremove.Name = "GBremove";
            GBremove.Padding = new Padding(6);
            GBremove.Size = new Size(623, 143);
            GBremove.TabIndex = 11;
            GBremove.TabStop = false;
            GBremove.Text = "Remove";
            // 
            // RemoveBTN
            // 
            RemoveBTN.BackColor = Color.FromArgb(128, 128, 255);
            RemoveBTN.FlatAppearance.BorderColor = Color.White;
            RemoveBTN.FlatStyle = FlatStyle.Flat;
            RemoveBTN.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveBTN.Location = new Point(7, 72);
            RemoveBTN.Margin = new Padding(4, 3, 4, 3);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(607, 54);
            RemoveBTN.TabIndex = 2;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = false;
            // 
            // DataDropDown
            // 
            DataDropDown.BackColor = Color.FromArgb(160, 204, 250);
            DataDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            DataDropDown.FlatStyle = FlatStyle.Flat;
            DataDropDown.FormattingEnabled = true;
            DataDropDown.Location = new Point(87, 34);
            DataDropDown.Margin = new Padding(4, 3, 4, 3);
            DataDropDown.Name = "DataDropDown";
            DataDropDown.Size = new Size(527, 32);
            DataDropDown.TabIndex = 1;
            // 
            // PageDropDown
            // 
            PageDropDown.BackColor = Color.FromArgb(160, 204, 250);
            PageDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            PageDropDown.FlatStyle = FlatStyle.Flat;
            PageDropDown.FormattingEnabled = true;
            PageDropDown.Location = new Point(7, 34);
            PageDropDown.Margin = new Padding(4, 3, 4, 3);
            PageDropDown.Name = "PageDropDown";
            PageDropDown.Size = new Size(72, 32);
            PageDropDown.TabIndex = 0;
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 116, 212);
            ClientSize = new Size(654, 173);
            Controls.Add(GBremove);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Remove Item";
            GBremove.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox GBremove;
        private Button RemoveBTN;
        private ComboBox DataDropDown;
        private ComboBox PageDropDown;
    }
}