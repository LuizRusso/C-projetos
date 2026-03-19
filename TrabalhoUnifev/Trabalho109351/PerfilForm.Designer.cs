namespace Trabalho109351
{
    partial class PerfilForm
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
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emalLabel = new System.Windows.Forms.Label();
            this.informacoesLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.corButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(256, 426);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 0;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(300, 12);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            this.nomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(303, 28);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(396, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(306, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(393, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // emalLabel
            // 
            this.emalLabel.AutoSize = true;
            this.emalLabel.Location = new System.Drawing.Point(303, 100);
            this.emalLabel.Name = "emalLabel";
            this.emalLabel.Size = new System.Drawing.Size(35, 13);
            this.emalLabel.TabIndex = 4;
            this.emalLabel.Text = "E-mail";
            // 
            // informacoesLabel
            // 
            this.informacoesLabel.AutoSize = true;
            this.informacoesLabel.Location = new System.Drawing.Point(306, 175);
            this.informacoesLabel.Name = "informacoesLabel";
            this.informacoesLabel.Size = new System.Drawing.Size(65, 13);
            this.informacoesLabel.TabIndex = 5;
            this.informacoesLabel.Text = "Informações";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(306, 192);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(393, 121);
            this.infoTextBox.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(624, 319);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tema";
            // 
            // corButton
            // 
            this.corButton.Location = new System.Drawing.Point(309, 345);
            this.corButton.Name = "corButton";
            this.corButton.Size = new System.Drawing.Size(106, 21);
            this.corButton.TabIndex = 10;
            this.corButton.Text = "Escolher Cor";
            this.corButton.UseVisualStyleBackColor = true;
            this.corButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PerfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.corButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.informacoesLabel);
            this.Controls.Add(this.emalLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PerfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Shown += new System.EventHandler(this.PerfilForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emalLabel;
        private System.Windows.Forms.Label informacoesLabel;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button corButton;
    }
}