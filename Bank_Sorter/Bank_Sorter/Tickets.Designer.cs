namespace Bank_Sorter
{
	partial class Tickets
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.dgvTurnos = new System.Windows.Forms.DataGridView();
			this.btngenerar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
			this.SuspendLayout();
			// 
			// mtxtDUI
			// 
			this.mtxtDUI.Location = new System.Drawing.Point(147, 180);
			this.mtxtDUI.Mask = "00000000-0";
			this.mtxtDUI.Name = "mtxtDUI";
			this.mtxtDUI.Size = new System.Drawing.Size(100, 22);
			this.mtxtDUI.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(314, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Siguiente →";
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.BackColor = System.Drawing.Color.Maroon;
			this.btnReiniciar.FlatAppearance.BorderSize = 0;
			this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReiniciar.ForeColor = System.Drawing.Color.White;
			this.btnReiniciar.Location = new System.Drawing.Point(449, 271);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(222, 26);
			this.btnReiniciar.TabIndex = 18;
			this.btnReiniciar.Text = "Reiniciar conteo de Tickets";
			this.btnReiniciar.UseVisualStyleBackColor = false;
			// 
			// dgvTurnos
			// 
			this.dgvTurnos.AllowUserToAddRows = false;
			this.dgvTurnos.AllowUserToDeleteRows = false;
			this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTurnos.EnableHeadersVisualStyles = false;
			this.dgvTurnos.Location = new System.Drawing.Point(416, 34);
			this.dgvTurnos.MultiSelect = false;
			this.dgvTurnos.Name = "dgvTurnos";
			this.dgvTurnos.ReadOnly = true;
			this.dgvTurnos.RowHeadersVisible = false;
			this.dgvTurnos.RowTemplate.Height = 30;
			this.dgvTurnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTurnos.Size = new System.Drawing.Size(304, 231);
			this.dgvTurnos.TabIndex = 17;
			// 
			// btngenerar
			// 
			this.btngenerar.BackColor = System.Drawing.Color.Black;
			this.btngenerar.FlatAppearance.BorderSize = 0;
			this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btngenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btngenerar.ForeColor = System.Drawing.Color.White;
			this.btngenerar.Location = new System.Drawing.Point(113, 217);
			this.btngenerar.Name = "btngenerar";
			this.btngenerar.Size = new System.Drawing.Size(134, 58);
			this.btngenerar.TabIndex = 16;
			this.btngenerar.Text = "Generar Ticket";
			this.btngenerar.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Agregue un turno nuevo";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Caja",
            "Sertracen",
            "Atención al cliente",
            "Créditos"});
			this.comboBox1.Location = new System.Drawing.Point(147, 114);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 17);
			this.label3.TabIndex = 23;
			this.label3.Text = "Operación";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(58, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Tipo Cliente";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Caja",
            "Sertracen",
            "Atención al cliente",
            "Créditos"});
			this.comboBox2.Location = new System.Drawing.Point(147, 146);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(110, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 17);
			this.label5.TabIndex = 26;
			this.label5.Text = "DUI";
			// 
			// Tickets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 347);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.mtxtDUI);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.dgvTurnos);
			this.Controls.Add(this.btngenerar);
			this.Controls.Add(this.label1);
			this.Name = "Tickets";
			this.Text = "Tickets";
			((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtxtDUI;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.DataGridView dgvTurnos;
		private System.Windows.Forms.Button btngenerar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label5;
	}
}