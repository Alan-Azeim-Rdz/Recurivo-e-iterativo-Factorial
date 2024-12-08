namespace Recurivo_e_iterativo
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
            LstViewIterativo = new ListView();
            LstViewRecurcivo = new ListView();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            LblTimeIterativo = new Label();
            LblTimeRecursivo = new Label();
            label2 = new Label();
            label1 = new Label();
            TextIterativo = new TextBox();
            TextRecurcive = new TextBox();
            BtnIterativo = new Button();
            BtnRecurcivo = new Button();
            SuspendLayout();
            // 
            // LstViewIterativo
            // 
            LstViewIterativo.Location = new Point(578, 27);
            LstViewIterativo.Name = "LstViewIterativo";
            LstViewIterativo.Size = new Size(179, 411);
            LstViewIterativo.TabIndex = 6;
            LstViewIterativo.UseCompatibleStateImageBehavior = false;
            // 
            // LstViewRecurcivo
            // 
            LstViewRecurcivo.Location = new Point(360, 27);
            LstViewRecurcivo.Name = "LstViewRecurcivo";
            LstViewRecurcivo.Size = new Size(183, 411);
            LstViewRecurcivo.TabIndex = 7;
            LstViewRecurcivo.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 9);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "Recurcivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Iterativo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 32);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 35;
            label6.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 232);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 34;
            label5.Text = "Time";
            // 
            // LblTimeIterativo
            // 
            LblTimeIterativo.AutoSize = true;
            LblTimeIterativo.Location = new Point(113, 232);
            LblTimeIterativo.Name = "LblTimeIterativo";
            LblTimeIterativo.Size = new Size(0, 15);
            LblTimeIterativo.TabIndex = 33;
            // 
            // LblTimeRecursivo
            // 
            LblTimeRecursivo.AutoSize = true;
            LblTimeRecursivo.Location = new Point(113, 32);
            LblTimeRecursivo.Name = "LblTimeRecursivo";
            LblTimeRecursivo.Size = new Size(0, 15);
            LblTimeRecursivo.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 268);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 31;
            label2.Text = "Iterativo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 69);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 30;
            label1.Text = "Recurcivo";
            // 
            // TextIterativo
            // 
            TextIterativo.Location = new Point(34, 286);
            TextIterativo.Name = "TextIterativo";
            TextIterativo.Size = new Size(218, 23);
            TextIterativo.TabIndex = 29;
            // 
            // TextRecurcive
            // 
            TextRecurcive.Location = new Point(34, 87);
            TextRecurcive.Name = "TextRecurcive";
            TextRecurcive.Size = new Size(218, 23);
            TextRecurcive.TabIndex = 28;
            // 
            // BtnIterativo
            // 
            BtnIterativo.Location = new Point(101, 315);
            BtnIterativo.Name = "BtnIterativo";
            BtnIterativo.Size = new Size(75, 23);
            BtnIterativo.TabIndex = 27;
            BtnIterativo.Text = "Insert";
            BtnIterativo.UseVisualStyleBackColor = true;
            BtnIterativo.Click += BtnIterativo_Click;
            // 
            // BtnRecurcivo
            // 
            BtnRecurcivo.Location = new Point(101, 116);
            BtnRecurcivo.Name = "BtnRecurcivo";
            BtnRecurcivo.Size = new Size(75, 23);
            BtnRecurcivo.TabIndex = 26;
            BtnRecurcivo.Text = "Insert";
            BtnRecurcivo.UseVisualStyleBackColor = true;
            BtnRecurcivo.Click += BtnRecurcivo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LblTimeIterativo);
            Controls.Add(LblTimeRecursivo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextIterativo);
            Controls.Add(TextRecurcive);
            Controls.Add(BtnIterativo);
            Controls.Add(BtnRecurcivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LstViewRecurcivo);
            Controls.Add(LstViewIterativo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView LstViewIterativo;
        private ListView LstViewRecurcivo;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label LblTimeIterativo;
        private Label LblTimeRecursivo;
        private Label label2;
        private Label label1;
        private TextBox TextIterativo;
        private TextBox TextRecurcive;
        private Button BtnIterativo;
        private Button BtnRecurcivo;
    }
}
