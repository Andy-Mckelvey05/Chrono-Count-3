namespace Chrono_Count_3.Forms
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            groupbox_Layout = new GroupBox();
            textbox_Time = new TextBox();
            label_Time = new Label();
            label_Name = new Label();
            textbox_Name = new TextBox();
            button_CreateItem = new Button();
            groupbox_Layout.SuspendLayout();
            SuspendLayout();
            // 
            // groupbox_Layout
            // 
            groupbox_Layout.Controls.Add(textbox_Time);
            groupbox_Layout.Controls.Add(label_Time);
            groupbox_Layout.Controls.Add(label_Name);
            groupbox_Layout.Controls.Add(textbox_Name);
            groupbox_Layout.Controls.Add(button_CreateItem);
            groupbox_Layout.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_Layout.Location = new Point(15, 15);
            groupbox_Layout.Margin = new Padding(6);
            groupbox_Layout.Name = "groupbox_Layout";
            groupbox_Layout.Padding = new Padding(6);
            groupbox_Layout.Size = new Size(520, 185);
            groupbox_Layout.TabIndex = 10;
            groupbox_Layout.TabStop = false;
            groupbox_Layout.Text = "Create";
            // 
            // textbox_Time
            // 
            textbox_Time.BackColor = Color.FromArgb(160, 204, 250);
            textbox_Time.BorderStyle = BorderStyle.FixedSingle;
            textbox_Time.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Time.Location = new Point(196, 73);
            textbox_Time.Margin = new Padding(4, 3, 4, 3);
            textbox_Time.MaxLength = 99;
            textbox_Time.Name = "textbox_Time";
            textbox_Time.Size = new Size(314, 39);
            textbox_Time.TabIndex = 3;
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Time.Location = new Point(12, 78);
            label_Time.Margin = new Padding(4, 0, 4, 0);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(179, 32);
            label_Time.TabIndex = 5;
            label_Time.Text = "Event Time:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(12, 34);
            label_Name.Margin = new Padding(4, 0, 4, 0);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(179, 32);
            label_Name.TabIndex = 4;
            label_Name.Text = "Event Name:";
            // 
            // textbox_Name
            // 
            textbox_Name.BackColor = Color.FromArgb(160, 204, 250);
            textbox_Name.BorderStyle = BorderStyle.FixedSingle;
            textbox_Name.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_Name.Location = new Point(196, 29);
            textbox_Name.Margin = new Padding(4, 3, 4, 3);
            textbox_Name.MaxLength = 99;
            textbox_Name.Name = "textbox_Name";
            textbox_Name.Size = new Size(314, 39);
            textbox_Name.TabIndex = 2;
            // 
            // button_CreateItem
            // 
            button_CreateItem.BackColor = Color.FromArgb(128, 128, 255);
            button_CreateItem.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button_CreateItem.FlatStyle = FlatStyle.Flat;
            button_CreateItem.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_CreateItem.Location = new Point(9, 118);
            button_CreateItem.Margin = new Padding(4, 3, 4, 3);
            button_CreateItem.Name = "button_CreateItem";
            button_CreateItem.Size = new Size(501, 56);
            button_CreateItem.TabIndex = 4;
            button_CreateItem.Text = "Create";
            button_CreateItem.UseVisualStyleBackColor = false;
            button_CreateItem.Click += button_CreateItem_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 116, 212);
            ClientSize = new Size(554, 211);
            Controls.Add(groupbox_Layout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Item";
            groupbox_Layout.ResumeLayout(false);
            groupbox_Layout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox groupbox_Layout;
        internal TextBox textbox_Time;
        internal Label label_Time;
        internal Label label_Name;
        internal TextBox textbox_Name;
        internal Button button_CreateItem;
    }
}