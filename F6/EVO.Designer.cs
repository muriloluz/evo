namespace F6
{
    partial class EVO
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
            this.grafico = new ScottPlot.FormsPlot();
            this.iniciar = new System.Windows.Forms.Button();
            this.lblPopulacao = new System.Windows.Forms.Label();
            this.graficoAptidao = new ScottPlot.FormsPlot();
            this.aptidao = new System.Windows.Forms.Label();
            this.lblGeracoes = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptidaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSourceIndividuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.individuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSourceExecucoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptidaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceIndividuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceExecucoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.Location = new System.Drawing.Point(1182, 43);
            this.grafico.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(1187, 999);
            this.grafico.TabIndex = 0;
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iniciar.Location = new System.Drawing.Point(1475, 1149);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(140, 54);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // lblPopulacao
            // 
            this.lblPopulacao.AutoSize = true;
            this.lblPopulacao.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPopulacao.Location = new System.Drawing.Point(1225, 12);
            this.lblPopulacao.Name = "lblPopulacao";
            this.lblPopulacao.Size = new System.Drawing.Size(166, 37);
            this.lblPopulacao.TabIndex = 2;
            this.lblPopulacao.Text = "População ";
            // 
            // graficoAptidao
            // 
            this.graficoAptidao.Location = new System.Drawing.Point(48, 43);
            this.graficoAptidao.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.graficoAptidao.Name = "graficoAptidao";
            this.graficoAptidao.Size = new System.Drawing.Size(1125, 999);
            this.graficoAptidao.TabIndex = 3;
            // 
            // aptidao
            // 
            this.aptidao.AutoSize = true;
            this.aptidao.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aptidao.Location = new System.Drawing.Point(48, 12);
            this.aptidao.Name = "aptidao";
            this.aptidao.Size = new System.Drawing.Size(121, 37);
            this.aptidao.TabIndex = 4;
            this.aptidao.Text = "Aptidão";
            // 
            // lblGeracoes
            // 
            this.lblGeracoes.AutoSize = true;
            this.lblGeracoes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeracoes.Location = new System.Drawing.Point(197, 1174);
            this.lblGeracoes.Name = "lblGeracoes";
            this.lblGeracoes.Size = new System.Drawing.Size(121, 29);
            this.lblGeracoes.TabIndex = 5;
            this.lblGeracoes.Text = "Gerações:";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblx.Location = new System.Drawing.Point(438, 1174);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(34, 29);
            this.lblx.TabIndex = 6;
            this.lblx.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblY.Location = new System.Drawing.Point(685, 1174);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(33, 29);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Location = new System.Drawing.Point(1836, 1149);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 50);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Nova";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParar.Location = new System.Drawing.Point(1650, 1149);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(144, 54);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2386, 1102);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grafico);
            this.tabPage1.Controls.Add(this.aptidao);
            this.tabPage1.Controls.Add(this.graficoAptidao);
            this.tabPage1.Controls.Add(this.lblPopulacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2378, 1060);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visão Gráfica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2378, 1060);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.aptidaoDataGridViewTextBoxColumn1,
            this.xDataGridViewTextBoxColumn1,
            this.yDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.dataSourceExecucoesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1400, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(815, 652);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aptidaoDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataSourceIndividuoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 965);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 350;
            // 
            // aptidaoDataGridViewTextBoxColumn
            // 
            this.aptidaoDataGridViewTextBoxColumn.DataPropertyName = "Aptidao";
            this.aptidaoDataGridViewTextBoxColumn.HeaderText = "Aptidao";
            this.aptidaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aptidaoDataGridViewTextBoxColumn.Name = "aptidaoDataGridViewTextBoxColumn";
            this.aptidaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.aptidaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            this.xDataGridViewTextBoxColumn.Width = 250;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            this.yDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataSourceIndividuoBindingSource
            // 
            this.dataSourceIndividuoBindingSource.DataSource = typeof(F6.Entidades.DataSourceIndividuo);
            // 
            // individuoBindingSource
            // 
            this.individuoBindingSource.DataSource = typeof(F6.Entidades.Individuo);
            // 
            // dataSourceExecucoesBindingSource
            // 
            this.dataSourceExecucoesBindingSource.DataSource = typeof(F6.Entidades.DataSourceExecucoes);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // aptidaoDataGridViewTextBoxColumn1
            // 
            this.aptidaoDataGridViewTextBoxColumn1.DataPropertyName = "Aptidao";
            this.aptidaoDataGridViewTextBoxColumn1.HeaderText = "Aptidao";
            this.aptidaoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.aptidaoDataGridViewTextBoxColumn1.Name = "aptidaoDataGridViewTextBoxColumn1";
            this.aptidaoDataGridViewTextBoxColumn1.Width = 200;
            // 
            // xDataGridViewTextBoxColumn1
            // 
            this.xDataGridViewTextBoxColumn1.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn1.HeaderText = "X";
            this.xDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.xDataGridViewTextBoxColumn1.Name = "xDataGridViewTextBoxColumn1";
            this.xDataGridViewTextBoxColumn1.Width = 200;
            // 
            // yDataGridViewTextBoxColumn1
            // 
            this.yDataGridViewTextBoxColumn1.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn1.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.yDataGridViewTextBoxColumn1.Name = "yDataGridViewTextBoxColumn1";
            this.yDataGridViewTextBoxColumn1.Width = 200;
            // 
            // EVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2389, 1243);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblGeracoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EVO";
            this.Text = "EVO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceIndividuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceExecucoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot grafico;
        private Button iniciar;
        private Label lblPopulacao;
        private ScottPlot.FormsPlot graficoAptidao;
        private Label aptidao;
        private Label lblGeracoes;
        private Label lblx;
        private Label lblY;
        private Button btnNovo;
        private Button btnParar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private BindingSource individuoBindingSource;
        private BindingSource dataSourceIndividuoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aptidaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn aptidaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn1;
        private BindingSource dataSourceExecucoesBindingSource;
    }
}