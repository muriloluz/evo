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
            this.grafico = new ScottPlot.FormsPlot();
            this.iniciar = new System.Windows.Forms.Button();
            this.lblPopulacao = new System.Windows.Forms.Label();
            this.graficoAptidao = new ScottPlot.FormsPlot();
            this.aptidao = new System.Windows.Forms.Label();
            this.lblGeracoes = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.Location = new System.Drawing.Point(857, 52);
            this.grafico.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(1414, 952);
            this.grafico.TabIndex = 0;
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iniciar.Location = new System.Drawing.Point(1932, 1033);
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
            this.lblPopulacao.Location = new System.Drawing.Point(906, 10);
            this.lblPopulacao.Name = "lblPopulacao";
            this.lblPopulacao.Size = new System.Drawing.Size(166, 37);
            this.lblPopulacao.TabIndex = 2;
            this.lblPopulacao.Text = "População ";
            // 
            // graficoAptidao
            // 
            this.graficoAptidao.Location = new System.Drawing.Point(-18, 52);
            this.graficoAptidao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.graficoAptidao.Name = "graficoAptidao";
            this.graficoAptidao.Size = new System.Drawing.Size(863, 952);
            this.graficoAptidao.TabIndex = 3;
            // 
            // aptidao
            // 
            this.aptidao.AutoSize = true;
            this.aptidao.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aptidao.Location = new System.Drawing.Point(27, 10);
            this.aptidao.Name = "aptidao";
            this.aptidao.Size = new System.Drawing.Size(121, 37);
            this.aptidao.TabIndex = 4;
            this.aptidao.Text = "Aptidão";
            // 
            // lblGeracoes
            // 
            this.lblGeracoes.AutoSize = true;
            this.lblGeracoes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGeracoes.Location = new System.Drawing.Point(27, 1033);
            this.lblGeracoes.Name = "lblGeracoes";
            this.lblGeracoes.Size = new System.Drawing.Size(121, 29);
            this.lblGeracoes.TabIndex = 5;
            this.lblGeracoes.Text = "Gerações:";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblx.Location = new System.Drawing.Point(228, 1033);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(34, 29);
            this.lblx.TabIndex = 6;
            this.lblx.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblY.Location = new System.Drawing.Point(433, 1033);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(33, 29);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.Location = new System.Drawing.Point(2107, 1037);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 50);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Nova";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // EVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2313, 1099);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblGeracoes);
            this.Controls.Add(this.aptidao);
            this.Controls.Add(this.graficoAptidao);
            this.Controls.Add(this.lblPopulacao);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EVO";
            this.Text = "EVO";
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
    }
}