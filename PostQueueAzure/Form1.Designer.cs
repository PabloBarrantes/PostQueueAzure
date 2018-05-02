namespace PostQueueAzure
{
    partial class Form1
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
            this.lblpintar = new System.Windows.Forms.Label();
            this.btnborrartarea = new System.Windows.Forms.Button();
            this.btnborrarmensaje = new System.Windows.Forms.Button();
            this.btnmodificarmensaje = new System.Windows.Forms.Button();
            this.btncrearmensaje = new System.Windows.Forms.Button();
            this.btntodosmensajes = new System.Windows.Forms.Button();
            this.btnultimomensaje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvmensajes = new System.Windows.Forms.ListView();
            this.Mensajes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblpintar
            // 
            this.lblpintar.AutoSize = true;
            this.lblpintar.Location = new System.Drawing.Point(273, 184);
            this.lblpintar.Name = "lblpintar";
            this.lblpintar.Size = new System.Drawing.Size(35, 13);
            this.lblpintar.TabIndex = 25;
            this.lblpintar.Text = "label3";
            // 
            // btnborrartarea
            // 
            this.btnborrartarea.Location = new System.Drawing.Point(505, 236);
            this.btnborrartarea.Name = "btnborrartarea";
            this.btnborrartarea.Size = new System.Drawing.Size(121, 40);
            this.btnborrartarea.TabIndex = 24;
            this.btnborrartarea.Text = "Borrar tarea";
            this.btnborrartarea.UseVisualStyleBackColor = true;
            this.btnborrartarea.Click += new System.EventHandler(this.btnborrartarea_Click);
            // 
            // btnborrarmensaje
            // 
            this.btnborrarmensaje.Location = new System.Drawing.Point(505, 173);
            this.btnborrarmensaje.Name = "btnborrarmensaje";
            this.btnborrarmensaje.Size = new System.Drawing.Size(121, 40);
            this.btnborrarmensaje.TabIndex = 23;
            this.btnborrarmensaje.Text = "Borrar mensaje";
            this.btnborrarmensaje.UseVisualStyleBackColor = true;
            this.btnborrarmensaje.Click += new System.EventHandler(this.btnborrarmensaje_Click);
            // 
            // btnmodificarmensaje
            // 
            this.btnmodificarmensaje.Location = new System.Drawing.Point(505, 106);
            this.btnmodificarmensaje.Name = "btnmodificarmensaje";
            this.btnmodificarmensaje.Size = new System.Drawing.Size(121, 40);
            this.btnmodificarmensaje.TabIndex = 22;
            this.btnmodificarmensaje.Text = "Modificar mensaje";
            this.btnmodificarmensaje.UseVisualStyleBackColor = true;
            this.btnmodificarmensaje.Click += new System.EventHandler(this.btnmodificarmensaje_Click);
            // 
            // btncrearmensaje
            // 
            this.btncrearmensaje.Location = new System.Drawing.Point(505, 35);
            this.btncrearmensaje.Name = "btncrearmensaje";
            this.btncrearmensaje.Size = new System.Drawing.Size(121, 40);
            this.btncrearmensaje.TabIndex = 21;
            this.btncrearmensaje.Text = "Crear Mensaje";
            this.btncrearmensaje.UseVisualStyleBackColor = true;
            this.btncrearmensaje.Click += new System.EventHandler(this.btncrearmensaje_Click);
            // 
            // btntodosmensajes
            // 
            this.btntodosmensajes.Location = new System.Drawing.Point(276, 236);
            this.btntodosmensajes.Name = "btntodosmensajes";
            this.btntodosmensajes.Size = new System.Drawing.Size(121, 40);
            this.btntodosmensajes.TabIndex = 20;
            this.btntodosmensajes.Text = "Todos mensajes";
            this.btntodosmensajes.UseVisualStyleBackColor = true;
            this.btntodosmensajes.Click += new System.EventHandler(this.btntodosmensajes_Click);
            // 
            // btnultimomensaje
            // 
            this.btnultimomensaje.Location = new System.Drawing.Point(135, 236);
            this.btnultimomensaje.Name = "btnultimomensaje";
            this.btnultimomensaje.Size = new System.Drawing.Size(121, 40);
            this.btnultimomensaje.TabIndex = 19;
            this.btnultimomensaje.Text = "Ultimo mensaje";
            this.btnultimomensaje.UseVisualStyleBackColor = true;
            this.btnultimomensaje.Click += new System.EventHandler(this.btnultimomensaje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuarios";
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Items.AddRange(new object[] {
            "tareasprogramador1",
            "tareasprogramador2"});
            this.cmbusuarios.Location = new System.Drawing.Point(135, 184);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbusuarios.TabIndex = 17;
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(135, 25);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(347, 108);
            this.txtmensaje.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mensaje";
            // 
            // lsvmensajes
            // 
            this.lsvmensajes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mensajes});
            this.lsvmensajes.Location = new System.Drawing.Point(132, 308);
            this.lsvmensajes.Name = "lsvmensajes";
            this.lsvmensajes.Size = new System.Drawing.Size(494, 119);
            this.lsvmensajes.TabIndex = 14;
            this.lsvmensajes.UseCompatibleStateImageBehavior = false;
            this.lsvmensajes.View = System.Windows.Forms.View.Details;
            // 
            // Mensajes
            // 
            this.Mensajes.Text = "Mensajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 552);
            this.Controls.Add(this.lblpintar);
            this.Controls.Add(this.btnborrartarea);
            this.Controls.Add(this.btnborrarmensaje);
            this.Controls.Add(this.btnmodificarmensaje);
            this.Controls.Add(this.btncrearmensaje);
            this.Controls.Add(this.btntodosmensajes);
            this.Controls.Add(this.btnultimomensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbusuarios);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvmensajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpintar;
        private System.Windows.Forms.Button btnborrartarea;
        private System.Windows.Forms.Button btnborrarmensaje;
        private System.Windows.Forms.Button btnmodificarmensaje;
        private System.Windows.Forms.Button btncrearmensaje;
        private System.Windows.Forms.Button btntodosmensajes;
        private System.Windows.Forms.Button btnultimomensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvmensajes;
        private System.Windows.Forms.ColumnHeader Mensajes;
    }
}

