namespace App_Rever.View
{
    partial class TelaForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Resultado = new Label();
            tbx_PrimeiroValor = new TextBox();
            tbx_SegundoValor = new TextBox();
            tbx_TerceiroValor = new TextBox();
            btn_Calcular = new Button();
            btn_Apagar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 32);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Maior Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 110);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 1;
            label2.Text = "Primeiro Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(143, 182);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 2;
            label3.Text = "Segundo Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(143, 249);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 3;
            label4.Text = "Terceiro Valor:";
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = Color.FromArgb(255, 128, 128);
            lbl_Resultado.Location = new Point(126, 418);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(278, 99);
            lbl_Resultado.TabIndex = 4;
            lbl_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbx_PrimeiroValor
            // 
            tbx_PrimeiroValor.Location = new Point(274, 108);
            tbx_PrimeiroValor.Name = "tbx_PrimeiroValor";
            tbx_PrimeiroValor.Size = new Size(100, 23);
            tbx_PrimeiroValor.TabIndex = 5;
            // 
            // tbx_SegundoValor
            // 
            tbx_SegundoValor.Location = new Point(274, 180);
            tbx_SegundoValor.Name = "tbx_SegundoValor";
            tbx_SegundoValor.Size = new Size(100, 23);
            tbx_SegundoValor.TabIndex = 6;
            // 
            // tbx_TerceiroValor
            // 
            tbx_TerceiroValor.Location = new Point(274, 247);
            tbx_TerceiroValor.Name = "tbx_TerceiroValor";
            tbx_TerceiroValor.Size = new Size(100, 23);
            tbx_TerceiroValor.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(126, 301);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(278, 47);
            btn_Calcular.TabIndex = 8;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Apagar
            // 
            btn_Apagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Apagar.Location = new Point(126, 361);
            btn_Apagar.Name = "btn_Apagar";
            btn_Apagar.Size = new Size(278, 47);
            btn_Apagar.TabIndex = 9;
            btn_Apagar.Text = "Apagar";
            btn_Apagar.UseVisualStyleBackColor = true;
            btn_Apagar.Click += btn_Apagar_Click;
            // 
            // TelaForm
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(531, 559);
            Controls.Add(btn_Apagar);
            Controls.Add(btn_Calcular);
            Controls.Add(tbx_TerceiroValor);
            Controls.Add(tbx_SegundoValor);
            Controls.Add(tbx_PrimeiroValor);
            Controls.Add(lbl_Resultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Resultado;
        private TextBox tbx_PrimeiroValor;
        private TextBox tbx_SegundoValor;
        private TextBox tbx_TerceiroValor;
        private Button btn_Calcular;
        private Button btn_Apagar;
    }
}