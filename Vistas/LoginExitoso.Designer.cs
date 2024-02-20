namespace Login.Vistas
{
    partial class LoginExitoso
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNombreAEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(720, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felicidades sos uno de los usuarios que se registró con exito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwUsers
            // 
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.PASS});
            this.dgwUsers.Location = new System.Drawing.Point(229, 122);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(343, 253);
            this.dgwUsers.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PASS
            // 
            this.PASS.Frozen = true;
            this.PASS.HeaderText = "PASS";
            this.PASS.Name = "PASS";
            this.PASS.ReadOnly = true;
            this.PASS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbNombreAEliminar
            // 
            this.tbNombreAEliminar.Location = new System.Drawing.Point(229, 392);
            this.tbNombreAEliminar.Name = "tbNombreAEliminar";
            this.tbNombreAEliminar.Size = new System.Drawing.Size(100, 20);
            this.tbNombreAEliminar.TabIndex = 2;
            // 
            // btnEliminarNombre
            // 
            this.btnEliminarNombre.Location = new System.Drawing.Point(348, 390);
            this.btnEliminarNombre.Name = "btnEliminarNombre";
            this.btnEliminarNombre.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarNombre.TabIndex = 3;
            this.btnEliminarNombre.Text = "Eliminar Nombre";
            this.btnEliminarNombre.UseVisualStyleBackColor = true;
            this.btnEliminarNombre.Click += new System.EventHandler(this.btnEliminarNombre_Click);
            // 
            // LoginExitoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarNombre);
            this.Controls.Add(this.tbNombreAEliminar);
            this.Controls.Add(this.dgwUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginExitoso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginExitoso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginExitoso_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.TextBox tbNombreAEliminar;
        private System.Windows.Forms.Button btnEliminarNombre;
    }
}