namespace Login
{
    partial class Inicio
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
            this.tbUsuarioLog = new System.Windows.Forms.TextBox();
            this.tbPassLog = new System.Windows.Forms.TextBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLogRegister = new System.Windows.Forms.Button();
            this.lbUsuarioError = new System.Windows.Forms.Label();
            this.labPassError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuarioLog
            // 
            this.tbUsuarioLog.Location = new System.Drawing.Point(60, 58);
            this.tbUsuarioLog.MaxLength = 15;
            this.tbUsuarioLog.Name = "tbUsuarioLog";
            this.tbUsuarioLog.Size = new System.Drawing.Size(165, 20);
            this.tbUsuarioLog.TabIndex = 0;
            this.tbUsuarioLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuarioLog_KeyPress);
            // 
            // tbPassLog
            // 
            this.tbPassLog.Location = new System.Drawing.Point(60, 121);
            this.tbPassLog.MaxLength = 20;
            this.tbPassLog.Name = "tbPassLog";
            this.tbPassLog.Size = new System.Drawing.Size(165, 20);
            this.tbPassLog.TabIndex = 1;
            this.tbPassLog.UseSystemPasswordChar = true;
            this.tbPassLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassLog_KeyPress);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(57, 33);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(43, 13);
            this.labUsuario.TabIndex = 2;
            this.labUsuario.Text = "Usuario";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Location = new System.Drawing.Point(57, 96);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(53, 13);
            this.labPass.TabIndex = 3;
            this.labPass.Text = "Password";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(60, 176);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(78, 23);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLogRegister
            // 
            this.btnLogRegister.Location = new System.Drawing.Point(145, 176);
            this.btnLogRegister.Name = "btnLogRegister";
            this.btnLogRegister.Size = new System.Drawing.Size(80, 23);
            this.btnLogRegister.TabIndex = 5;
            this.btnLogRegister.Text = "Registrarse";
            this.btnLogRegister.UseVisualStyleBackColor = true;
            this.btnLogRegister.Click += new System.EventHandler(this.btnLogRegister_Click);
            // 
            // lbUsuarioError
            // 
            this.lbUsuarioError.AutoSize = true;
            this.lbUsuarioError.Location = new System.Drawing.Point(60, 80);
            this.lbUsuarioError.Name = "lbUsuarioError";
            this.lbUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lbUsuarioError.TabIndex = 6;
            // 
            // labPassError
            // 
            this.labPassError.AutoSize = true;
            this.labPassError.Location = new System.Drawing.Point(60, 148);
            this.labPassError.Name = "labPassError";
            this.labPassError.Size = new System.Drawing.Size(0, 13);
            this.labPassError.TabIndex = 7;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 244);
            this.Controls.Add(this.labPassError);
            this.Controls.Add(this.lbUsuarioError);
            this.Controls.Add(this.btnLogRegister);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.tbPassLog);
            this.Controls.Add(this.tbUsuarioLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuarioLog;
        private System.Windows.Forms.TextBox tbPassLog;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLogRegister;
        private System.Windows.Forms.Label lbUsuarioError;
        private System.Windows.Forms.Label labPassError;
    }
}

