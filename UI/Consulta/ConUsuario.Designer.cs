namespace Registro
{
    partial class ConUsuario
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
            this.ConsultarDataGridView = new System.Windows.Forms.Button();
            this.LabelFiltros = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriteriosTextBox = new System.Windows.Forms.TextBox();
            this.LabelCriterios = new System.Windows.Forms.Label();
            this.Datagriedview = new System.Windows.Forms.DataGridView();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelDesde = new System.Windows.Forms.Label();
            this.LabelHasta = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Datagriedview)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarDataGridView
            // 
            this.ConsultarDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarDataGridView.Image = global::Registro.Properties.Resources.iconfinder_system_search_118797;
            this.ConsultarDataGridView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarDataGridView.Location = new System.Drawing.Point(465, 12);
            this.ConsultarDataGridView.Name = "ConsultarDataGridView";
            this.ConsultarDataGridView.Size = new System.Drawing.Size(104, 38);
            this.ConsultarDataGridView.TabIndex = 0;
            this.ConsultarDataGridView.Text = "Consultar";
            this.ConsultarDataGridView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarDataGridView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConsultarDataGridView.UseVisualStyleBackColor = true;
            this.ConsultarDataGridView.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // LabelFiltros
            // 
            this.LabelFiltros.AutoSize = true;
            this.LabelFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltros.Location = new System.Drawing.Point(258, 6);
            this.LabelFiltros.Name = "LabelFiltros";
            this.LabelFiltros.Size = new System.Drawing.Size(39, 17);
            this.LabelFiltros.TabIndex = 2;
            this.LabelFiltros.Text = "Filtro";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre",
            "Email",
            "Nivel Usuario",
            "Usuario"});
            this.FiltroComboBox.Location = new System.Drawing.Point(225, 26);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 3;
            // 
            // CriteriosTextBox
            // 
            this.CriteriosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriosTextBox.Location = new System.Drawing.Point(352, 27);
            this.CriteriosTextBox.Name = "CriteriosTextBox";
            this.CriteriosTextBox.Size = new System.Drawing.Size(107, 23);
            this.CriteriosTextBox.TabIndex = 4;
            // 
            // LabelCriterios
            // 
            this.LabelCriterios.AutoSize = true;
            this.LabelCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCriterios.Location = new System.Drawing.Point(377, 6);
            this.LabelCriterios.Name = "LabelCriterios";
            this.LabelCriterios.Size = new System.Drawing.Size(60, 17);
            this.LabelCriterios.TabIndex = 5;
            this.LabelCriterios.Text = "Criterios";
            // 
            // Datagriedview
            // 
            this.Datagriedview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagriedview.Location = new System.Drawing.Point(4, 56);
            this.Datagriedview.Name = "Datagriedview";
            this.Datagriedview.Size = new System.Drawing.Size(565, 239);
            this.Datagriedview.TabIndex = 10;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(12, 27);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(95, 23);
            this.DesdeDateTimePicker.TabIndex = 7;
            // 
            // LabelDesde
            // 
            this.LabelDesde.AutoSize = true;
            this.LabelDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesde.Location = new System.Drawing.Point(28, 7);
            this.LabelDesde.Name = "LabelDesde";
            this.LabelDesde.Size = new System.Drawing.Size(49, 17);
            this.LabelDesde.TabIndex = 8;
            this.LabelDesde.Text = "Desde";
            // 
            // LabelHasta
            // 
            this.LabelHasta.AutoSize = true;
            this.LabelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHasta.Location = new System.Drawing.Point(136, 7);
            this.LabelHasta.Name = "LabelHasta";
            this.LabelHasta.Size = new System.Drawing.Size(45, 17);
            this.LabelHasta.TabIndex = 9;
            this.LabelHasta.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(113, 27);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(99, 23);
            this.HastaDateTimePicker.TabIndex = 6;
            // 
            // ConUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 305);
            this.Controls.Add(this.Datagriedview);
            this.Controls.Add(this.LabelHasta);
            this.Controls.Add(this.LabelDesde);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.LabelCriterios);
            this.Controls.Add(this.CriteriosTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.LabelFiltros);
            this.Controls.Add(this.ConsultarDataGridView);
            this.Name = "ConUsuario";
            this.Text = "ConUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.Datagriedview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultarDataGridView;
        private System.Windows.Forms.Label LabelFiltros;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriteriosTextBox;
        private System.Windows.Forms.Label LabelCriterios;
        private System.Windows.Forms.DataGridView Datagriedview;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label LabelDesde;
        private System.Windows.Forms.Label LabelHasta;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
    }
}