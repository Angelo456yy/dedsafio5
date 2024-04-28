namespace CUOTAS
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
            Pts = new TextBox();
            Ts = new TextBox();
            Pg = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(268, 31);
            label1.Name = "label1";
            label1.Size = new Size(290, 50);
            label1.TabIndex = 0;
            label1.Text = "Calcular Cuotas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(85, 116);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 1;
            label2.Text = "Prestamo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(85, 172);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 2;
            label3.Text = "Tasa de interes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(85, 225);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 3;
            label4.Text = "Pagos";
            label4.Click += label4_Click;
            // 
            // Pts
            // 
            Pts.Location = new Point(268, 125);
            Pts.Name = "Pts";
            Pts.Size = new Size(119, 23);
            Pts.TabIndex = 8;
            Pts.TextChanged += Pts_TextChanged;
            // 
            // Ts
            // 
            Ts.Location = new Point(268, 172);
            Ts.Name = "Ts";
            Ts.Size = new Size(119, 23);
            Ts.TabIndex = 5;
            Ts.TextChanged += Ts_TextChanged;
            // 
            // Pg
            // 
            Pg.Location = new Point(268, 225);
            Pg.Name = "Pg";
            Pg.Size = new Size(119, 23);
            Pg.TabIndex = 6;
            Pg.TextChanged += Pg_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(517, 112);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 7;
            button1.Text = "Transmitir ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(517, 203);
            button2.Name = "button2";
            button2.Size = new Size(142, 45);
            button2.TabIndex = 9;
            button2.Text = "Finalizar Tramite";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pg);
            Controls.Add(Ts);
            Controls.Add(Pts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private TextBox Pts;
        private TextBox Ts;
        private TextBox Pg;
        private Button button1;
        private Button button2;
    }
}
