namespace CadastroCliente
{
    partial class frmCadastroCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.txtID = new System.Windows.Forms.Label();
            this.btnGravar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.txtCelular = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCEP = new MetroFramework.Controls.MetroTextBox();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.lblCEP = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblCelular = new MetroFramework.Controls.MetroLabel();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.grdCliente = new MetroFramework.Controls.MetroGrid();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeBusca = new MetroFramework.Controls.MetroTextBox();
            this.lblEndereco = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblEndereco);
            this.metroPanel1.Controls.Add(this.btnExcluir);
            this.metroPanel1.Controls.Add(this.txtID);
            this.metroPanel1.Controls.Add(this.btnGravar);
            this.metroPanel1.Controls.Add(this.btnLimpar);
            this.metroPanel1.Controls.Add(this.txtNome);
            this.metroPanel1.Controls.Add(this.txtTelefone);
            this.metroPanel1.Controls.Add(this.txtCelular);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtCEP);
            this.metroPanel1.Controls.Add(this.txtEndereco);
            this.metroPanel1.Controls.Add(this.lblCEP);
            this.metroPanel1.Controls.Add(this.lblEmail);
            this.metroPanel1.Controls.Add(this.lblCelular);
            this.metroPanel1.Controls.Add(this.lblTelefone);
            this.metroPanel1.Controls.Add(this.lblNome);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(432, 290);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(138, 181);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(384, 267);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(45, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "Valor ID";
            this.txtID.Visible = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(344, 181);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseSelectable = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(241, 181);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(86, 5);
            this.txtNome.MaxLength = 250;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(333, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(86, 34);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PromptText = "(11) 9999-9999";
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(127, 23);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.WaterMark = "(11) 9999-9999";
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCelular
            // 
            // 
            // 
            // 
            this.txtCelular.CustomButton.Image = null;
            this.txtCelular.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCelular.CustomButton.Name = "";
            this.txtCelular.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular.CustomButton.TabIndex = 1;
            this.txtCelular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular.CustomButton.UseSelectable = true;
            this.txtCelular.CustomButton.Visible = false;
            this.txtCelular.Lines = new string[0];
            this.txtCelular.Location = new System.Drawing.Point(86, 63);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.PromptText = "(11) 99999-9999";
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.ShortcutsEnabled = true;
            this.txtCelular.Size = new System.Drawing.Size(127, 23);
            this.txtCelular.TabIndex = 3;
            this.txtCelular.UseSelectable = true;
            this.txtCelular.WaterMark = "(11) 99999-9999";
            this.txtCelular.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(86, 91);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "teste@teste.com";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(333, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "teste@teste.com";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCEP
            // 
            // 
            // 
            // 
            this.txtCEP.CustomButton.Image = null;
            this.txtCEP.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCEP.CustomButton.Name = "";
            this.txtCEP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCEP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCEP.CustomButton.TabIndex = 1;
            this.txtCEP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCEP.CustomButton.UseSelectable = true;
            this.txtCEP.CustomButton.Visible = false;
            this.txtCEP.Lines = new string[0];
            this.txtCEP.Location = new System.Drawing.Point(86, 121);
            this.txtCEP.MaxLength = 32767;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.PromptText = "00000-000";
            this.txtCEP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.ShortcutsEnabled = true;
            this.txtCEP.Size = new System.Drawing.Size(75, 23);
            this.txtCEP.TabIndex = 5;
            this.txtCEP.UseSelectable = true;
            this.txtCEP.WaterMark = "00000-000";
            this.txtCEP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCEP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEndereco
            // 
            // 
            // 
            // 
            this.txtEndereco.CustomButton.Image = null;
            this.txtEndereco.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtEndereco.CustomButton.Name = "";
            this.txtEndereco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndereco.CustomButton.TabIndex = 1;
            this.txtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndereco.CustomButton.UseSelectable = true;
            this.txtEndereco.CustomButton.Visible = false;
            this.txtEndereco.Lines = new string[0];
            this.txtEndereco.Location = new System.Drawing.Point(86, 151);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(333, 23);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.UseSelectable = true;
            this.txtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(13, 121);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(36, 19);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 63);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 19);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 33);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 19);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 4);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AllowUserToResizeRows = false;
            this.grdCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Id,
            this.Telefone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCliente.EnableHeadersVisualStyles = false;
            this.grdCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCliente.Location = new System.Drawing.Point(448, 63);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCliente.Size = new System.Drawing.Size(427, 264);
            this.grdCliente.TabIndex = 9;
            this.grdCliente.DoubleClick += new System.EventHandler(this.grdCliente_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(800, 352);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(448, 330);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Localizar Cliente por Nome:";
            // 
            // txtNomeBusca
            // 
            // 
            // 
            // 
            this.txtNomeBusca.CustomButton.Image = null;
            this.txtNomeBusca.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtNomeBusca.CustomButton.Name = "";
            this.txtNomeBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeBusca.CustomButton.TabIndex = 1;
            this.txtNomeBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeBusca.CustomButton.UseSelectable = true;
            this.txtNomeBusca.CustomButton.Visible = false;
            this.txtNomeBusca.Lines = new string[0];
            this.txtNomeBusca.Location = new System.Drawing.Point(448, 352);
            this.txtNomeBusca.MaxLength = 32767;
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.PasswordChar = '\0';
            this.txtNomeBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeBusca.SelectedText = "";
            this.txtNomeBusca.SelectionLength = 0;
            this.txtNomeBusca.SelectionStart = 0;
            this.txtNomeBusca.ShortcutsEnabled = true;
            this.txtNomeBusca.Size = new System.Drawing.Size(333, 23);
            this.txtNomeBusca.TabIndex = 10;
            this.txtNomeBusca.UseSelectable = true;
            this.txtNomeBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(14, 151);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 19);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 386);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid grdCliente;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomeBusca;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblCelular;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        private MetroFramework.Controls.MetroTextBox txtCelular;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtCEP;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroLabel lblCEP;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnGravar;
        private System.Windows.Forms.Label txtID;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroLabel lblEndereco;
    }
}

