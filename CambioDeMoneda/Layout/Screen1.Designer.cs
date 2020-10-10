namespace CambioDeMoneda.Layout
{
    partial class Screen1
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
            this.TextBoxCantidad = new System.Windows.Forms.TextBox();
            this.LabelPesos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelDolares = new System.Windows.Forms.Label();
            this.TextBoxCambioTotal = new System.Windows.Forms.TextBox();
            this.GroupBoxOption = new System.Windows.Forms.GroupBox();
            this.RbDtoP = new System.Windows.Forms.RadioButton();
            this.RbPtoD = new System.Windows.Forms.RadioButton();
            this.ButtConvertir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caluladoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxOption.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxCantidad
            // 
            this.TextBoxCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.TextBoxCantidad.Location = new System.Drawing.Point(83, 51);
            this.TextBoxCantidad.Name = "TextBoxCantidad";
            this.TextBoxCantidad.Size = new System.Drawing.Size(181, 20);
            this.TextBoxCantidad.TabIndex = 0;
            // 
            // LabelPesos
            // 
            this.LabelPesos.AutoSize = true;
            this.LabelPesos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPesos.ForeColor = System.Drawing.Color.White;
            this.LabelPesos.Location = new System.Drawing.Point(12, 54);
            this.LabelPesos.Name = "LabelPesos";
            this.LabelPesos.Size = new System.Drawing.Size(65, 17);
            this.LabelPesos.TabIndex = 1;
            this.LabelPesos.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dolar: 21.13$";
            // 
            // LabelDolares
            // 
            this.LabelDolares.AutoSize = true;
            this.LabelDolares.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDolares.ForeColor = System.Drawing.Color.White;
            this.LabelDolares.Location = new System.Drawing.Point(12, 88);
            this.LabelDolares.Name = "LabelDolares";
            this.LabelDolares.Size = new System.Drawing.Size(89, 17);
            this.LabelDolares.TabIndex = 4;
            this.LabelDolares.Text = "Cambio total:";
            // 
            // TextBoxCambioTotal
            // 
            this.TextBoxCambioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxCambioTotal.ForeColor = System.Drawing.Color.White;
            this.TextBoxCambioTotal.Location = new System.Drawing.Point(107, 85);
            this.TextBoxCambioTotal.Name = "TextBoxCambioTotal";
            this.TextBoxCambioTotal.ReadOnly = true;
            this.TextBoxCambioTotal.Size = new System.Drawing.Size(157, 20);
            this.TextBoxCambioTotal.TabIndex = 3;
            // 
            // GroupBoxOption
            // 
            this.GroupBoxOption.Controls.Add(this.RbDtoP);
            this.GroupBoxOption.Controls.Add(this.RbPtoD);
            this.GroupBoxOption.ForeColor = System.Drawing.Color.White;
            this.GroupBoxOption.Location = new System.Drawing.Point(272, 40);
            this.GroupBoxOption.Name = "GroupBoxOption";
            this.GroupBoxOption.Size = new System.Drawing.Size(200, 65);
            this.GroupBoxOption.TabIndex = 5;
            this.GroupBoxOption.TabStop = false;
            this.GroupBoxOption.Text = "Orden de conversion";
            // 
            // RbDtoP
            // 
            this.RbDtoP.AutoSize = true;
            this.RbDtoP.Location = new System.Drawing.Point(7, 43);
            this.RbDtoP.Name = "RbDtoP";
            this.RbDtoP.Size = new System.Drawing.Size(104, 17);
            this.RbDtoP.TabIndex = 1;
            this.RbDtoP.Text = "Dolares a pesos.";
            this.RbDtoP.UseVisualStyleBackColor = true;
            // 
            // RbPtoD
            // 
            this.RbPtoD.AutoSize = true;
            this.RbPtoD.Checked = true;
            this.RbPtoD.Location = new System.Drawing.Point(7, 20);
            this.RbPtoD.Name = "RbPtoD";
            this.RbPtoD.Size = new System.Drawing.Size(103, 17);
            this.RbPtoD.TabIndex = 0;
            this.RbPtoD.TabStop = true;
            this.RbPtoD.Text = "Pesos a dolares.";
            this.RbPtoD.UseVisualStyleBackColor = true;
            // 
            // ButtConvertir
            // 
            this.ButtConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ButtConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtConvertir.ForeColor = System.Drawing.Color.White;
            this.ButtConvertir.Location = new System.Drawing.Point(16, 120);
            this.ButtConvertir.Name = "ButtConvertir";
            this.ButtConvertir.Size = new System.Drawing.Size(249, 23);
            this.ButtConvertir.TabIndex = 6;
            this.ButtConvertir.Text = "Convertir moneda";
            this.ButtConvertir.UseVisualStyleBackColor = false;
            this.ButtConvertir.Click += new System.EventHandler(this.ButtConvertir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caluladoraToolStripMenuItem});
            this.calculadoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.calculadoraToolStripMenuItem.Text = "Herramientas";
            // 
            // caluladoraToolStripMenuItem
            // 
            this.caluladoraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.caluladoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.caluladoraToolStripMenuItem.Name = "caluladoraToolStripMenuItem";
            this.caluladoraToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.caluladoraToolStripMenuItem.Text = "Caluladora";
            this.caluladoraToolStripMenuItem.Click += new System.EventHandler(this.caluladoraToolStripMenuItem_Click);
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(484, 170);
            this.Controls.Add(this.ButtConvertir);
            this.Controls.Add(this.GroupBoxOption);
            this.Controls.Add(this.LabelDolares);
            this.Controls.Add(this.TextBoxCambioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPesos);
            this.Controls.Add(this.TextBoxCantidad);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Screen1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de moneda. v1.0 - NelsonJfsg";
            this.GroupBoxOption.ResumeLayout(false);
            this.GroupBoxOption.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCantidad;
        private System.Windows.Forms.Label LabelPesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelDolares;
        private System.Windows.Forms.TextBox TextBoxCambioTotal;
        private System.Windows.Forms.GroupBox GroupBoxOption;
        private System.Windows.Forms.RadioButton RbDtoP;
        private System.Windows.Forms.RadioButton RbPtoD;
        private System.Windows.Forms.Button ButtConvertir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caluladoraToolStripMenuItem;
    }
}