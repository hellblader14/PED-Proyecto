namespace Bank_Sorter
{
	partial class clientes
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
			this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbTercera = new System.Windows.Forms.RadioButton();
			this.rbBlack = new System.Windows.Forms.RadioButton();
			this.rbNormal = new System.Windows.Forms.RadioButton();
			this.rbVIP = new System.Windows.Forms.RadioButton();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mtxtDUI
			// 
			this.mtxtDUI.Location = new System.Drawing.Point(181, 52);
			this.mtxtDUI.Mask = "00000000-0";
			this.mtxtDUI.Name = "mtxtDUI";
			this.mtxtDUI.Size = new System.Drawing.Size(100, 22);
			this.mtxtDUI.TabIndex = 42;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(317, 354);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(116, 44);
			this.btnActualizar.TabIndex = 41;
			this.btnActualizar.Text = "Actualizar Cliente";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Visible = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(185, 354);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 44);
			this.btnEliminar.TabIndex = 40;
			this.btnEliminar.Text = "Eliminar Cliente";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.AllowUserToOrderColumns = true;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(400, 57);
			this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowTemplate.Height = 24;
			this.dgvClientes.Size = new System.Drawing.Size(329, 268);
			this.dgvClientes.TabIndex = 39;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(50, 354);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(116, 44);
			this.btnAdd.TabIndex = 38;
			this.btnAdd.Text = "Añadir Cliente";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbTercera);
			this.groupBox1.Controls.Add(this.rbBlack);
			this.groupBox1.Controls.Add(this.rbNormal);
			this.groupBox1.Controls.Add(this.rbVIP);
			this.groupBox1.Location = new System.Drawing.Point(67, 192);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(300, 130);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de Cliente";
			// 
			// rbTercera
			// 
			this.rbTercera.AutoSize = true;
			this.rbTercera.Location = new System.Drawing.Point(166, 32);
			this.rbTercera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbTercera.Name = "rbTercera";
			this.rbTercera.Size = new System.Drawing.Size(116, 21);
			this.rbTercera.TabIndex = 3;
			this.rbTercera.TabStop = true;
			this.rbTercera.Text = "Tercera Edad";
			this.rbTercera.UseVisualStyleBackColor = true;
			// 
			// rbBlack
			// 
			this.rbBlack.AutoSize = true;
			this.rbBlack.Location = new System.Drawing.Point(16, 32);
			this.rbBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbBlack.Name = "rbBlack";
			this.rbBlack.Size = new System.Drawing.Size(63, 21);
			this.rbBlack.TabIndex = 2;
			this.rbBlack.TabStop = true;
			this.rbBlack.Text = "Black";
			this.rbBlack.UseVisualStyleBackColor = true;
			// 
			// rbNormal
			// 
			this.rbNormal.AutoSize = true;
			this.rbNormal.Location = new System.Drawing.Point(166, 78);
			this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbNormal.Name = "rbNormal";
			this.rbNormal.Size = new System.Drawing.Size(74, 21);
			this.rbNormal.TabIndex = 1;
			this.rbNormal.TabStop = true;
			this.rbNormal.Text = "Normal";
			this.rbNormal.UseVisualStyleBackColor = true;
			// 
			// rbVIP
			// 
			this.rbVIP.AutoSize = true;
			this.rbVIP.Location = new System.Drawing.Point(16, 78);
			this.rbVIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbVIP.Name = "rbVIP";
			this.rbVIP.Size = new System.Drawing.Size(50, 21);
			this.rbVIP.TabIndex = 0;
			this.rbVIP.TabStop = true;
			this.rbVIP.Text = "VIP";
			this.rbVIP.UseVisualStyleBackColor = true;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(181, 147);
			this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(185, 22);
			this.txtApellido.TabIndex = 36;
			this.txtApellido.Visible = false;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(181, 100);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(185, 22);
			this.txtNombre.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(117, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 17);
			this.label3.TabIndex = 33;
			this.label3.Text = "Apellido";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(117, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 32;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 17);
			this.label1.TabIndex = 31;
			this.label1.Text = "Número de Documento";
			// 
			// clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(799, 450);
			this.Controls.Add(this.mtxtDUI);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "clientes";
			this.Text = "clientes";
			this.Load += new System.EventHandler(this.clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtxtDUI;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbNormal;
		private System.Windows.Forms.RadioButton rbVIP;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbTercera;
		private System.Windows.Forms.RadioButton rbBlack;
	}
}