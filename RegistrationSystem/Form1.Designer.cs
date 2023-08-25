namespace RegistrationSystem
{
    partial class Form1
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
            TechRubro = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            TXTSenha = new TextBox();
            TXTLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TechRubro.SuspendLayout();
            SuspendLayout();
            // 
            // TechRubro
            // 
            TechRubro.BackColor = SystemColors.ButtonShadow;
            TechRubro.Controls.Add(button2);
            TechRubro.Controls.Add(button1);
            TechRubro.Controls.Add(TXTSenha);
            TechRubro.Controls.Add(TXTLogin);
            TechRubro.Controls.Add(label2);
            TechRubro.Controls.Add(label1);
            TechRubro.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TechRubro.Location = new Point(14, 12);
            TechRubro.Name = "TechRubro";
            TechRubro.Size = new Size(531, 296);
            TechRubro.TabIndex = 0;
            TechRubro.TabStop = false;
            TechRubro.Text = "TechRubro";
            TechRubro.Enter += TechRubro_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(357, 262);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 5;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(445, 262);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TXTSenha
            // 
            TXTSenha.CharacterCasing = CharacterCasing.Upper;
            TXTSenha.Font = new Font("Simplex_IV25", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TXTSenha.Location = new Point(26, 154);
            TXTSenha.Name = "TXTSenha";
            TXTSenha.Size = new Size(344, 30);
            TXTSenha.TabIndex = 3;
            TXTSenha.UseSystemPasswordChar = true;
            // 
            // TXTLogin
            // 
            TXTLogin.CharacterCasing = CharacterCasing.Upper;
            TXTLogin.Font = new Font("Simplex_IV25", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TXTLogin.Location = new Point(26, 71);
            TXTLogin.Name = "TXTLogin";
            TXTLogin.Size = new Size(344, 30);
            TXTLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 120);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 320);
            Controls.Add(TechRubro);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TechRubro.ResumeLayout(false);
            TechRubro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TechRubro;
        private Label label1;
        private Label label2;
        private TextBox TXTSenha;
        private TextBox TXTLogin;
        private Button button2;
        private Button button1;
    }
}