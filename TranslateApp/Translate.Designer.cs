namespace TranslateApp
{
    partial class Translate
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
            this.fromText = new System.Windows.Forms.TextBox();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromText
            // 
            this.fromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromText.Location = new System.Drawing.Point(11, 65);
            this.fromText.Margin = new System.Windows.Forms.Padding(2);
            this.fromText.Multiline = true;
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(323, 338);
            this.fromText.TabIndex = 0;
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.DisplayMember = "English";
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            "English-en",
            "Russian-ru",
            "Arabic-ar",
            "Spanish-es",
            "German-de",
            "French-fr",
            "Hindi-hi",
            "Italian-it",
            "Japanese-ja",
            "Turkish-tr"});
            this.comboBoxLanguages.Location = new System.Drawing.Point(599, 33);
            this.comboBoxLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLanguages.TabIndex = 1;
            this.comboBoxLanguages.Text = "English-en";
            // 
            // toText
            // 
            this.toText.BackColor = System.Drawing.SystemColors.Window;
            this.toText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toText.Location = new System.Drawing.Point(443, 65);
            this.toText.Margin = new System.Windows.Forms.Padding(2);
            this.toText.Multiline = true;
            this.toText.Name = "toText";
            this.toText.ReadOnly = true;
            this.toText.Size = new System.Drawing.Size(323, 338);
            this.toText.TabIndex = 2;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(342, 24);
            this.translateButton.Margin = new System.Windows.Forms.Padding(2);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(89, 36);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // wait
            // 
            this.wait.AutoSize = true;
            this.wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wait.Location = new System.Drawing.Point(339, 189);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(95, 18);
            this.wait.TabIndex = 4;
            this.wait.Text = "Please wait...";
            this.wait.Visible = false;
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 425);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.fromText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Translate";
            this.Text = "Translate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label wait;
    }
}

