namespace Lição_10_18112020
{
    partial class frmLicao1018112020
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicao1018112020));
            this.bndnaviPreferencias = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bndnavibtnConfirma = new System.Windows.Forms.ToolStripButton();
            this.bndnaviTxtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.bndnavibtnPesquisa = new System.Windows.Forms.ToolStripButton();
            this.dtgdvwPreferencias = new System.Windows.Forms.DataGridView();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnAlterarBd = new System.Windows.Forms.Button();
            this.btnExcluirBd = new System.Windows.Forms.Button();
            this.btnIncluirBd = new System.Windows.Forms.Button();
            this.btnConsultBd = new System.Windows.Forms.Button();
            this.btnImprtBdDesc = new System.Windows.Forms.Button();
            this.btnImportBdConec = new System.Windows.Forms.Button();
            this.btnImportTxtWhile = new System.Windows.Forms.Button();
            this.btnDesvCondEnc = new System.Windows.Forms.Button();
            this.bndsrcPreferencias = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bndnaviPreferencias)).BeginInit();
            this.bndnaviPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // bndnaviPreferencias
            // 
            this.bndnaviPreferencias.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndnaviPreferencias.BindingSource = this.bndsrcPreferencias;
            this.bndnaviPreferencias.CountItem = this.bindingNavigatorCountItem;
            this.bndnaviPreferencias.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndnaviPreferencias.Dock = System.Windows.Forms.DockStyle.None;
            this.bndnaviPreferencias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bndnavibtnConfirma,
            this.bndnaviTxtPesquisa,
            this.bndnavibtnPesquisa});
            this.bndnaviPreferencias.Location = new System.Drawing.Point(260, 371);
            this.bndnaviPreferencias.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnaviPreferencias.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnaviPreferencias.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnaviPreferencias.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnaviPreferencias.Name = "bndnaviPreferencias";
            this.bndnaviPreferencias.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnaviPreferencias.Size = new System.Drawing.Size(422, 31);
            this.bndnaviPreferencias.TabIndex = 21;
            this.bndnaviPreferencias.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bndnavibtnConfirma
            // 
            this.bndnavibtnConfirma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavibtnConfirma.Image = ((System.Drawing.Image)(resources.GetObject("bndnavibtnConfirma.Image")));
            this.bndnavibtnConfirma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavibtnConfirma.Name = "bndnavibtnConfirma";
            this.bndnavibtnConfirma.Size = new System.Drawing.Size(23, 28);
            this.bndnavibtnConfirma.Text = "Confirma";
            // 
            // bndnaviTxtPesquisa
            // 
            this.bndnaviTxtPesquisa.Name = "bndnaviTxtPesquisa";
            this.bndnaviTxtPesquisa.Size = new System.Drawing.Size(100, 31);
            // 
            // bndnavibtnPesquisa
            // 
            this.bndnavibtnPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavibtnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("bndnavibtnPesquisa.Image")));
            this.bndnavibtnPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavibtnPesquisa.Name = "bndnavibtnPesquisa";
            this.bndnavibtnPesquisa.Size = new System.Drawing.Size(23, 28);
            this.bndnavibtnPesquisa.Text = "Pesquisa";
            // 
            // dtgdvwPreferencias
            // 
            this.dtgdvwPreferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdvwPreferencias.Location = new System.Drawing.Point(260, 405);
            this.dtgdvwPreferencias.Name = "dtgdvwPreferencias";
            this.dtgdvwPreferencias.RowTemplate.Height = 28;
            this.dtgdvwPreferencias.Size = new System.Drawing.Size(546, 303);
            this.dtgdvwPreferencias.TabIndex = 20;
            this.dtgdvwPreferencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwPreferencias_CellContentClick);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.ItemHeight = 20;
            this.lstbxPreferencias.Location = new System.Drawing.Point(260, 17);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(546, 304);
            this.lstbxPreferencias.TabIndex = 19;
            // 
            // btnAlterarBd
            // 
            this.btnAlterarBd.Location = new System.Drawing.Point(57, 646);
            this.btnAlterarBd.Name = "btnAlterarBd";
            this.btnAlterarBd.Size = new System.Drawing.Size(177, 62);
            this.btnAlterarBd.TabIndex = 18;
            this.btnAlterarBd.Text = "Alterar Bd";
            this.btnAlterarBd.UseVisualStyleBackColor = true;
            this.btnAlterarBd.Click += new System.EventHandler(this.btnAlterarBd_Click);
            // 
            // btnExcluirBd
            // 
            this.btnExcluirBd.Location = new System.Drawing.Point(57, 567);
            this.btnExcluirBd.Name = "btnExcluirBd";
            this.btnExcluirBd.Size = new System.Drawing.Size(177, 62);
            this.btnExcluirBd.TabIndex = 17;
            this.btnExcluirBd.Text = "Excluir Bd";
            this.btnExcluirBd.UseVisualStyleBackColor = true;
            this.btnExcluirBd.Click += new System.EventHandler(this.btnExcluirBd_Click);
            // 
            // btnIncluirBd
            // 
            this.btnIncluirBd.Location = new System.Drawing.Point(57, 486);
            this.btnIncluirBd.Name = "btnIncluirBd";
            this.btnIncluirBd.Size = new System.Drawing.Size(177, 62);
            this.btnIncluirBd.TabIndex = 16;
            this.btnIncluirBd.Text = "Incluir Bd";
            this.btnIncluirBd.UseVisualStyleBackColor = true;
            this.btnIncluirBd.Click += new System.EventHandler(this.btnIncluirBd_Click);
            // 
            // btnConsultBd
            // 
            this.btnConsultBd.Location = new System.Drawing.Point(57, 405);
            this.btnConsultBd.Name = "btnConsultBd";
            this.btnConsultBd.Size = new System.Drawing.Size(177, 62);
            this.btnConsultBd.TabIndex = 15;
            this.btnConsultBd.Text = "Consulta Bd";
            this.btnConsultBd.UseVisualStyleBackColor = true;
            this.btnConsultBd.Click += new System.EventHandler(this.btnConsultBd_Click);
            // 
            // btnImprtBdDesc
            // 
            this.btnImprtBdDesc.Location = new System.Drawing.Point(57, 259);
            this.btnImprtBdDesc.Name = "btnImprtBdDesc";
            this.btnImprtBdDesc.Size = new System.Drawing.Size(177, 62);
            this.btnImprtBdDesc.TabIndex = 14;
            this.btnImprtBdDesc.Text = "Importar Bd Desconectado";
            this.btnImprtBdDesc.UseVisualStyleBackColor = true;
            this.btnImprtBdDesc.Click += new System.EventHandler(this.btnImprtBdDesc_Click);
            // 
            // btnImportBdConec
            // 
            this.btnImportBdConec.Location = new System.Drawing.Point(57, 176);
            this.btnImportBdConec.Name = "btnImportBdConec";
            this.btnImportBdConec.Size = new System.Drawing.Size(177, 62);
            this.btnImportBdConec.TabIndex = 13;
            this.btnImportBdConec.Text = "Importar Bd Conectado";
            this.btnImportBdConec.UseVisualStyleBackColor = true;
            this.btnImportBdConec.Click += new System.EventHandler(this.btnImportBdConec_Click);
            // 
            // btnImportTxtWhile
            // 
            this.btnImportTxtWhile.Location = new System.Drawing.Point(57, 95);
            this.btnImportTxtWhile.Name = "btnImportTxtWhile";
            this.btnImportTxtWhile.Size = new System.Drawing.Size(177, 62);
            this.btnImportTxtWhile.TabIndex = 12;
            this.btnImportTxtWhile.Text = "Importa Txt While";
            this.btnImportTxtWhile.UseVisualStyleBackColor = true;
            this.btnImportTxtWhile.Click += new System.EventHandler(this.btnImportTxtWhile_Click);
            // 
            // btnDesvCondEnc
            // 
            this.btnDesvCondEnc.Location = new System.Drawing.Point(57, 17);
            this.btnDesvCondEnc.Name = "btnDesvCondEnc";
            this.btnDesvCondEnc.Size = new System.Drawing.Size(177, 62);
            this.btnDesvCondEnc.TabIndex = 11;
            this.btnDesvCondEnc.Text = "Desvio Condiconal Encadeado";
            this.btnDesvCondEnc.UseVisualStyleBackColor = true;
            this.btnDesvCondEnc.Click += new System.EventHandler(this.btnDesvCondEnc_Click);
            // 
            // frmLicao1018112020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 724);
            this.Controls.Add(this.bndnaviPreferencias);
            this.Controls.Add(this.dtgdvwPreferencias);
            this.Controls.Add(this.lstbxPreferencias);
            this.Controls.Add(this.btnAlterarBd);
            this.Controls.Add(this.btnExcluirBd);
            this.Controls.Add(this.btnIncluirBd);
            this.Controls.Add(this.btnConsultBd);
            this.Controls.Add(this.btnImprtBdDesc);
            this.Controls.Add(this.btnImportBdConec);
            this.Controls.Add(this.btnImportTxtWhile);
            this.Controls.Add(this.btnDesvCondEnc);
            this.Name = "frmLicao1018112020";
            this.Text = "Lição 10 18/11/2020";
            this.Load += new System.EventHandler(this.frmLicao1018112020_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bndnaviPreferencias)).EndInit();
            this.bndnaviPreferencias.ResumeLayout(false);
            this.bndnaviPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bndnaviPreferencias;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bndnavibtnConfirma;
        private System.Windows.Forms.ToolStripTextBox bndnaviTxtPesquisa;
        private System.Windows.Forms.ToolStripButton bndnavibtnPesquisa;
        private System.Windows.Forms.DataGridView dtgdvwPreferencias;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnAlterarBd;
        private System.Windows.Forms.Button btnExcluirBd;
        private System.Windows.Forms.Button btnIncluirBd;
        private System.Windows.Forms.Button btnConsultBd;
        private System.Windows.Forms.Button btnImprtBdDesc;
        private System.Windows.Forms.Button btnImportBdConec;
        private System.Windows.Forms.Button btnImportTxtWhile;
        private System.Windows.Forms.Button btnDesvCondEnc;
        private System.Windows.Forms.BindingSource bndsrcPreferencias;

    }
}

