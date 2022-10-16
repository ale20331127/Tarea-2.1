
namespace CalculadoraInteres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.comboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.txt_num4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(24, 58);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(116, 23);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(219, 58);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(116, 23);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(24, 150);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(116, 23);
            this.txtNum3.TabIndex = 2;
            // 
            // comboOpciones
            // 
            this.comboOpciones.FormattingEnabled = true;
            this.comboOpciones.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Diario"});
            this.comboOpciones.Location = new System.Drawing.Point(205, 150);
            this.comboOpciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboOpciones.Name = "comboOpciones";
            this.comboOpciones.Size = new System.Drawing.Size(140, 23);
            this.comboOpciones.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(118, 211);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 39);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // txt_num1
            // 
            this.txt_num1.BackColor = System.Drawing.Color.White;
            this.txt_num1.Location = new System.Drawing.Point(56, 28);
            this.txt_num1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(48, 23);
            this.txt_num1.TabIndex = 5;
            this.txt_num1.Text = "Capital";
            // 
            // txt_num2
            // 
            this.txt_num2.BackColor = System.Drawing.Color.White;
            this.txt_num2.Location = new System.Drawing.Point(230, 28);
            this.txt_num2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(94, 23);
            this.txt_num2.TabIndex = 6;
            this.txt_num2.Text = "Tasa de interés";
            // 
            // txt_num3
            // 
            this.txt_num3.BackColor = System.Drawing.Color.White;
            this.txt_num3.Location = new System.Drawing.Point(56, 120);
            this.txt_num3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(52, 23);
            this.txt_num3.TabIndex = 7;
            this.txt_num3.Text = "Tiempo";
            // 
            // txt_num4
            // 
            this.txt_num4.BackColor = System.Drawing.Color.White;
            this.txt_num4.Location = new System.Drawing.Point(219, 120);
            this.txt_num4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_num4.Name = "txt_num4";
            this.txt_num4.Size = new System.Drawing.Size(116, 23);
            this.txt_num4.TabIndex = 8;
            this.txt_num4.Text = "Período de tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(374, 269);
            this.Controls.Add(this.txt_num4);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboOpciones);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.TextBox txt_num4;
    }
}