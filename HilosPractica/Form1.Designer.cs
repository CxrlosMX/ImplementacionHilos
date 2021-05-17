
namespace HilosPractica
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnMostrarMsg = new System.Windows.Forms.Button();
            this.prbProgreso = new System.Windows.Forms.ProgressBar();
            this.lbProgreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(145, 38);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(196, 61);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Proceso";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnMostrarMsg
            // 
            this.btnMostrarMsg.Location = new System.Drawing.Point(145, 132);
            this.btnMostrarMsg.Name = "btnMostrarMsg";
            this.btnMostrarMsg.Size = new System.Drawing.Size(196, 60);
            this.btnMostrarMsg.TabIndex = 2;
            this.btnMostrarMsg.Text = "Mostrar Mensaje";
            this.btnMostrarMsg.UseVisualStyleBackColor = true;
            this.btnMostrarMsg.Click += new System.EventHandler(this.btnMostrarMsg_Click_1);
            // 
            // prbProgreso
            // 
            this.prbProgreso.Location = new System.Drawing.Point(61, 252);
            this.prbProgreso.Name = "prbProgreso";
            this.prbProgreso.Size = new System.Drawing.Size(346, 27);
            this.prbProgreso.TabIndex = 3;
            this.prbProgreso.Click += new System.EventHandler(this.prbProgreso_Click);
            // 
            // lbProgreso
            // 
            this.lbProgreso.AutoSize = true;
            this.lbProgreso.Location = new System.Drawing.Point(58, 227);
            this.lbProgreso.Name = "lbProgreso";
            this.lbProgreso.Size = new System.Drawing.Size(49, 13);
            this.lbProgreso.TabIndex = 4;
            this.lbProgreso.Text = "Progreso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 330);
            this.Controls.Add(this.lbProgreso);
            this.Controls.Add(this.prbProgreso);
            this.Controls.Add(this.btnMostrarMsg);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnMostrarMsg;
        private System.Windows.Forms.ProgressBar prbProgreso;
        private System.Windows.Forms.Label lbProgreso;
    }
}

