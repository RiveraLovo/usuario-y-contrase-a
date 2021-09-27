
namespace usuario_y_contraseña
{
    partial class Flogin
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
            this.components = new System.ComponentModel.Container();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.usuarioDataSet = new usuario_y_contraseña.usuarioDataSet();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaTableAdapter = new usuario_y_contraseña.usuarioDataSetTableAdapters.sistemaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(69, 188);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(176, 188);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sistemaBindingSource, "nombre", true));
            this.txtusuario.Location = new System.Drawing.Point(151, 65);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(175, 20);
            this.txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sistemaBindingSource, "clave", true));
            this.txtcontraseña.Location = new System.Drawing.Point(151, 104);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(175, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "usuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaBindingSource
            // 
            this.sistemaBindingSource.DataMember = "sistema";
            this.sistemaBindingSource.DataSource = this.usuarioDataSet;
            // 
            // sistemaTableAdapter
            // 
            this.sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 295);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Name = "Flogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private usuarioDataSet usuarioDataSet;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private usuarioDataSetTableAdapters.sistemaTableAdapter sistemaTableAdapter;
    }
}