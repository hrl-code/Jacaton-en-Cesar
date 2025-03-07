using System;
using System.Windows.Forms;

namespace Jacaton
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.campoPass);
            this.panel1.Controls.Add(this.campoUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.botonRegistro);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 415);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(180, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(185, 245);
            this.campoPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(132, 22);
            this.campoPass.TabIndex = 5;
            this.campoPass.UseSystemPasswordChar = true;
            this.campoPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // campoUser
            // 
            this.campoUser.Location = new System.Drawing.Point(185, 134);
            this.campoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.campoUser.Name = "campoUser";
            this.campoUser.Size = new System.Drawing.Size(132, 22);
            this.campoUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(199, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonRegistro
            // 
            this.botonRegistro.Location = new System.Drawing.Point(204, 316);
            this.botonRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(107, 37);
            this.botonRegistro.TabIndex = 1;
            this.botonRegistro.Text = "Registrar";
            this.botonRegistro.UseVisualStyleBackColor = true;
            this.botonRegistro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(545, 444);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUser;

        public void Entrar()
        {
            string miNombre = campoUser.Text;
            string miPass = campoPass.Text;


            if (BBDD.Conexion.Acceder(miNombre, miPass))
            {
                Principal p = new Principal();
                p.Show();

                this.Hide();

                p.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoPass.Text = "";
                campoUser.Text = "";
            }
        }
    }
}