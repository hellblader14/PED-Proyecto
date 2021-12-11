namespace Bank_Sorter
{
	partial class MainMenu
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnVentanilla = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 77);
			this.button1.TabIndex = 0;
			this.button1.Text = "Clientes";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 106);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 77);
			this.button2.TabIndex = 1;
			this.button2.Text = "Gestor de Turnos";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 268);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(99, 77);
			this.button3.TabIndex = 2;
			this.button3.Text = "Usuarios";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 185);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(99, 77);
			this.button4.TabIndex = 3;
			this.button4.Text = "Creación de tickets";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(117, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(958, 515);
			this.panel1.TabIndex = 4;
			// 
			// btnVentanilla
			// 
			this.btnVentanilla.Location = new System.Drawing.Point(12, 355);
			this.btnVentanilla.Name = "btnVentanilla";
			this.btnVentanilla.Size = new System.Drawing.Size(99, 77);
			this.btnVentanilla.TabIndex = 5;
			this.btnVentanilla.Text = "Ventanillas";
			this.btnVentanilla.UseVisualStyleBackColor = true;
			this.btnVentanilla.Click += new System.EventHandler(this.btnVentanilla_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(12, 438);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(99, 77);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "Cerrar Sesión";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.button6_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1087, 539);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnVentanilla);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnVentanilla;
		private System.Windows.Forms.Button btnCerrar;
	}
}