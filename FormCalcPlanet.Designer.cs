
namespace CalculadoraPlanetaria
{
    partial class FormCalcPlanet
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
            this.cbxPlaneta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTuPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPlaneta
            // 
            this.cbxPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlaneta.FormattingEnabled = true;
            this.cbxPlaneta.Items.AddRange(new object[] {
            "Mercurio",
            "Venus",
            "Tierra",
            "Luna",
            "Marte",
            "Jupiter",
            "Saturno",
            "Urano",
            "Neptuno"});
            this.cbxPlaneta.Location = new System.Drawing.Point(132, 12);
            this.cbxPlaneta.Name = "cbxPlaneta";
            this.cbxPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cbxPlaneta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona tu planeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Cuánto pesas en la Tierra? (kg)";
            // 
            // tbxTuPeso
            // 
            this.tbxTuPeso.Location = new System.Drawing.Point(180, 43);
            this.tbxTuPeso.Name = "tbxTuPeso";
            this.tbxTuPeso.Size = new System.Drawing.Size(73, 20);
            this.tbxTuPeso.TabIndex = 3;
            this.tbxTuPeso.TextChanged += new System.EventHandler(this.tbxTuPeso_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 74);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormCalcPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 109);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxTuPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPlaneta);
            this.Name = "FormCalcPlanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Planetaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTuPeso;
        private System.Windows.Forms.Button btnCalcular;
    }
}

