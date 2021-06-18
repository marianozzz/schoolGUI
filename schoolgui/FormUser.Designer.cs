namespace schoolgui
{
    partial class FormUser
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.group_users = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.group_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 28);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_apellido.Location = new System.Drawing.Point(6, 64);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(100, 23);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(6, 102);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(100, 23);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            this.lbl_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_password.Location = new System.Drawing.Point(6, 145);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 23);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Clave";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_users
            // 
            this.group_users.Controls.Add(this.lbl_detalle);
            this.group_users.Controls.Add(this.lbl_resultado);
            this.group_users.Controls.Add(this.btn_agregar);
            this.group_users.Controls.Add(this.txt_password);
            this.group_users.Controls.Add(this.txt_email);
            this.group_users.Controls.Add(this.txt_apellido);
            this.group_users.Controls.Add(this.txt_nombre);
            this.group_users.Controls.Add(this.lbl_nombre);
            this.group_users.Controls.Add(this.lbl_password);
            this.group_users.Controls.Add(this.lbl_apellido);
            this.group_users.Controls.Add(this.lbl_email);
            this.group_users.Location = new System.Drawing.Point(12, 12);
            this.group_users.Name = "group_users";
            this.group_users.Size = new System.Drawing.Size(709, 230);
            this.group_users.TabIndex = 4;
            this.group_users.TabStop = false;
            this.group_users.Text = "Alta de Usuarios";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(137, 30);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(153, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(137, 64);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(153, 20);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(137, 105);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(153, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(137, 146);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(153, 20);
            this.txt_password.TabIndex = 7;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(434, 30);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(76, 34);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_resultado.Location = new System.Drawing.Point(431, 122);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(223, 79);
            this.lbl_resultado.TabIndex = 9;
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(431, 107);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(55, 13);
            this.lbl_detalle.TabIndex = 10;
            this.lbl_detalle.Text = "DETALLE";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 323);
            this.Controls.Add(this.group_users);
            this.Name = "FormUser";
            this.Text = "Inicio";
            this.group_users.ResumeLayout(false);
            this.group_users.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.GroupBox group_users;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_detalle;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

