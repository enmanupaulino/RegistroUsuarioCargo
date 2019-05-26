namespace Registro.UI.Consulta
{
    partial class ConCargod
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
            this.Datagriedview = new System.Windows.Forms.DataGridView();
            this.LabelCriterios = new System.Windows.Forms.Label();
            this.CriteriosTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.LabelFiltros = new System.Windows.Forms.Label();
            this.ConsultarDataGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagriedview)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagriedview
            // 
            this.Datagriedview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagriedview.Location = new System.Drawing.Point(12, 55);
            this.Datagriedview.Name = "Datagriedview";
            this.Datagriedview.Size = new System.Drawing.Size(356, 239);
            this.Datagriedview.TabIndex = 20;
            // 
            // LabelCriterios
            // 
            this.LabelCriterios.AutoSize = true;
            this.LabelCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCriterios.Location = new System.Drawing.Point(181, 5);
            this.LabelCriterios.Name = "LabelCriterios";
            this.LabelCriterios.Size = new System.Drawing.Size(60, 17);
            this.LabelCriterios.TabIndex = 15;
            this.LabelCriterios.Text = "Criterios";
            // 
            // CriteriosTextBox
            // 
            this.CriteriosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriosTextBox.Location = new System.Drawing.Point(153, 26);
            this.CriteriosTextBox.Name = "CriteriosTextBox";
            this.CriteriosTextBox.Size = new System.Drawing.Size(107, 23);
            this.CriteriosTextBox.TabIndex = 14;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Descripcion"});
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 25);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 13;
            // 
            // LabelFiltros
            // 
            this.LabelFiltros.AutoSize = true;
            this.LabelFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiltros.Location = new System.Drawing.Point(45, 5);
            this.LabelFiltros.Name = "LabelFiltros";
            this.LabelFiltros.Size = new System.Drawing.Size(39, 17);
            this.LabelFiltros.TabIndex = 12;
            this.LabelFiltros.Text = "Filtro";
            // 
            // ConsultarDataGridView
            // 
            this.ConsultarDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarDataGridView.Image = global::Registro.Properties.Resources.iconfinder_system_search_118797;
            this.ConsultarDataGridView.Location = new System.Drawing.Point(266, 17);
            this.ConsultarDataGridView.Name = "ConsultarDataGridView";
            this.ConsultarDataGridView.Size = new System.Drawing.Size(111, 32);
            this.ConsultarDataGridView.TabIndex = 11;
            this.ConsultarDataGridView.Text = "Consultar";
            this.ConsultarDataGridView.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ConsultarDataGridView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConsultarDataGridView.UseVisualStyleBackColor = true;
            this.ConsultarDataGridView.UseWaitCursor = true;
            this.ConsultarDataGridView.Click += new System.EventHandler(this.ConsultarDataGridView_Click);
            // 
            // ConCargod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 303);
            this.Controls.Add(this.Datagriedview);
            this.Controls.Add(this.LabelCriterios);
            this.Controls.Add(this.CriteriosTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.LabelFiltros);
            this.Controls.Add(this.ConsultarDataGridView);
            this.Name = "ConCargod";
            this.Text = "ConCargod";
            ((System.ComponentModel.ISupportInitialize)(this.Datagriedview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datagriedview;
        private System.Windows.Forms.Label LabelCriterios;
        private System.Windows.Forms.TextBox CriteriosTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label LabelFiltros;
        private System.Windows.Forms.Button ConsultarDataGridView;
    }
}