namespace Ej1
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
            this.lisbo = new System.Windows.Forms.ListBox();
            this.bVer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lisbo
            // 
            this.lisbo.FormattingEnabled = true;
            this.lisbo.Location = new System.Drawing.Point(12, 12);
            this.lisbo.Name = "lisbo";
            this.lisbo.Size = new System.Drawing.Size(482, 316);
            this.lisbo.TabIndex = 0;
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(500, 12);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(118, 48);
            this.bVer.TabIndex = 1;
            this.bVer.Text = "Ver cuentas";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Importar cuentas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exportar cuentas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(500, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Resguardar(Backup)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(500, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Restaurar(Restore)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.lisbo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lisbo;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

