namespace Atividade01.View
{
    partial class Atividade
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
            label1 = new Label();
            lbl_valor1 = new Label();
            lbn_valor2 = new Label();
            lbl_Display = new Label();
            btn_Calcular = new Button();
            txb_valor1 = new TextBox();
            txb_valor2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 60);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            // 
            // lbl_valor1
            // 
            lbl_valor1.AutoSize = true;
            lbl_valor1.Location = new Point(132, 138);
            lbl_valor1.Name = "lbl_valor1";
            lbl_valor1.Size = new Size(42, 15);
            lbl_valor1.TabIndex = 1;
            lbl_valor1.Text = "Valor1:";
            // 
            // lbn_valor2
            // 
            lbn_valor2.AutoSize = true;
            lbn_valor2.Location = new Point(132, 185);
            lbn_valor2.Name = "lbn_valor2";
            lbn_valor2.Size = new Size(39, 15);
            lbn_valor2.TabIndex = 2;
            lbn_valor2.Text = "Valor2";
            // 
            // lbl_Display
            // 
            lbl_Display.BackColor = SystemColors.MenuHighlight;
            lbl_Display.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Display.Location = new Point(132, 344);
            lbl_Display.Name = "lbl_Display";
            lbl_Display.Size = new Size(151, 76);
            lbl_Display.TabIndex = 3;
            lbl_Display.Text = "Resultado:";
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(132, 226);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(75, 23);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // txb_valor1
            // 
            txb_valor1.Location = new Point(191, 135);
            txb_valor1.Name = "txb_valor1";
            txb_valor1.Size = new Size(185, 23);
            txb_valor1.TabIndex = 5;
            // 
            // txb_valor2
            // 
            txb_valor2.Location = new Point(191, 177);
            txb_valor2.Name = "txb_valor2";
            txb_valor2.Size = new Size(185, 23);
            txb_valor2.TabIndex = 6;
            // 
            // Atividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 484);
            Controls.Add(txb_valor2);
            Controls.Add(txb_valor1);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Display);
            Controls.Add(lbn_valor2);
            Controls.Add(lbl_valor1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Atividade";
            Text = "Atividade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_valor1;
        private Label lbn_valor2;
        private Label lbl_Display;
        private Button btn_Calcular;
        private TextBox txb_valor1;
        private TextBox txb_valor2;
    }
}