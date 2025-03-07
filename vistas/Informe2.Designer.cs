namespace Jacaton.vistas
{
    partial class Informe2
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
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla1 = new System.Windows.Forms.DataGridView();
            this.Tabla2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de los vendedores y facturación en tienda de los que estén activos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(159, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = " Nombre de la plataforma online y facturación total por cada una de ellas";
            // 
            // Tabla1
            // 
            this.Tabla1.AllowUserToAddRows = false;
            this.Tabla1.AllowUserToDeleteRows = false;
            this.Tabla1.AllowUserToResizeColumns = false;
            this.Tabla1.AllowUserToResizeRows = false;
            this.Tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla1.Location = new System.Drawing.Point(97, 135);
            this.Tabla1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tabla1.Name = "Tabla1";
            this.Tabla1.ReadOnly = true;
            this.Tabla1.RowHeadersWidth = 51;
            this.Tabla1.Size = new System.Drawing.Size(861, 132);
            this.Tabla1.TabIndex = 15;
            // 
            // Tabla2
            // 
            this.Tabla2.AllowUserToAddRows = false;
            this.Tabla2.AllowUserToDeleteRows = false;
            this.Tabla2.AllowUserToResizeColumns = false;
            this.Tabla2.AllowUserToResizeRows = false;
            this.Tabla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla2.Location = new System.Drawing.Point(97, 351);
            this.Tabla2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tabla2.Name = "Tabla2";
            this.Tabla2.ReadOnly = true;
            this.Tabla2.RowHeadersWidth = 51;
            this.Tabla2.Size = new System.Drawing.Size(861, 151);
            this.Tabla2.TabIndex = 16;
            // 
            // Informe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Tabla2);
            this.Controls.Add(this.Tabla1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informe2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informe2";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Tabla1;
        private System.Windows.Forms.DataGridView Tabla2;
    }
}