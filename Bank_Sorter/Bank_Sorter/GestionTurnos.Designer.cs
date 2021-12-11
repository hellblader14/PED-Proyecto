namespace Bank_Sorter
{
	partial class GestionTurnos
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbTurno = new System.Windows.Forms.Label();
			this.btnLlamar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtMesa = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lbTurno, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnLlamar, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 353);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lbTurno
			// 
			this.lbTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbTurno.AutoSize = true;
			this.lbTurno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTurno.Location = new System.Drawing.Point(199, 201);
			this.lbTurno.Name = "lbTurno";
			this.lbTurno.Size = new System.Drawing.Size(183, 37);
			this.lbTurno.TabIndex = 4;
			this.lbTurno.Text = "-En Espera-";
			// 
			// btnLlamar
			// 
			this.btnLlamar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLlamar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLlamar.Location = new System.Drawing.Point(233, 285);
			this.btnLlamar.Name = "btnLlamar";
			this.btnLlamar.Size = new System.Drawing.Size(115, 46);
			this.btnLlamar.TabIndex = 5;
			this.btnLlamar.Text = "Llamar";
			this.btnLlamar.UseVisualStyleBackColor = true;
			this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(192, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Siguiente turno:";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.txtMesa, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(574, 98);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Escritorio";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btnGuardar, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnModificar, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(347, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(224, 92);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnGuardar.Location = new System.Drawing.Point(56, 7);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(112, 31);
			this.btnGuardar.TabIndex = 0;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnModificar.Location = new System.Drawing.Point(58, 51);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(107, 36);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// txtMesa
			// 
			this.txtMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtMesa.Location = new System.Drawing.Point(210, 38);
			this.txtMesa.Name = "txtMesa";
			this.txtMesa.Size = new System.Drawing.Size(96, 22);
			this.txtMesa.TabIndex = 2;
			this.txtMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 3500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// GestionTurnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(582, 353);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "GestionTurnos";
			this.Text = "GestionTurnos";
			this.Load += new System.EventHandler(this.GestionTurnos_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbTurno;
		private System.Windows.Forms.Button btnLlamar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.TextBox txtMesa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
	}
}