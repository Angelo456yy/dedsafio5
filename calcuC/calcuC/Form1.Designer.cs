namespace calcuC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MI = new TextBox();
            TIA = new TextBox();
            PI = new TextBox();
            button1 = new Button();
            Lim = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(279, 48);
            label1.Name = "label1";
            label1.Size = new Size(248, 29);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR CAPITAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(68, 131);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 1;
            label2.Text = "Monto inicial ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(68, 191);
            label3.Name = "label3";
            label3.Size = new Size(216, 19);
            label3.TabIndex = 2;
            label3.Text = "Tasa de interes Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(68, 251);
            label4.Name = "label4";
            label4.Size = new Size(210, 19);
            label4.TabIndex = 3;
            label4.Text = "Periodo de inversion ";
            // 
            // MI
            // 
            MI.ForeColor = SystemColors.InfoText;
            MI.Location = new Point(292, 127);
            MI.Name = "MI";
            MI.Size = new Size(118, 23);
            MI.TabIndex = 4;
            MI.TextChanged += MI_TextChanged;
            // 
            // TIA
            // 
            TIA.Location = new Point(292, 187);
            TIA.Name = "TIA";
            TIA.Size = new Size(118, 23);
            TIA.TabIndex = 5;
            TIA.TextChanged += TIA_TextChanged;
            // 
            // PI
            // 
            PI.Location = new Point(292, 251);
            PI.Name = "PI";
            PI.Size = new Size(118, 23);
            PI.TabIndex = 6;
            PI.TextChanged += PI_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(511, 178);
            button1.Name = "button1";
            button1.Size = new Size(106, 47);
            button1.TabIndex = 7;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Lim
            // 
            Lim.BackColor = Color.FromArgb(192, 0, 192);
            Lim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lim.ForeColor = SystemColors.ButtonHighlight;
            Lim.Location = new Point(511, 282);
            Lim.Name = "Lim";
            Lim.Size = new Size(106, 47);
            Lim.TabIndex = 8;
            Lim.Text = "LIMPIAR";
            Lim.UseVisualStyleBackColor = false;
            Lim.Click += Lim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Lim);
            Controls.Add(button1);
            Controls.Add(PI);
            Controls.Add(TIA);
            Controls.Add(MI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox MI;
        private TextBox TIA;
        private TextBox PI;
        private Button button1;
        private Button Lim;
    }
}
