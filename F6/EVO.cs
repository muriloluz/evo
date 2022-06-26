using F6.Entidades;
using ScottPlot.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F6
{

    public partial class EVO : Form
    {
        private EnumTipoEstrategia tipoEstrategia = EnumTipoEstrategia.AG;

        private EstrategiaPE estrategiaPE;
        private const int tamanhoPopulacaoPE = 500;
        private const int qntGeracoesPE = 200;

        private EstrategiaAG estrategiaAG;
        private const int tamanhoPopulacaoAG = 100;
        private const int qntGeracoesAG = 2500;
        private const int qntExecucoes = 1;

        private bool plotarGraficos = true;

        private Individuo melhorIndividuo;
        private List<double> melhoresAptidoes;
        private List<DataSourceExecucoes> dataSourceExecucoes;

        private bool Parar = false;

        public EVO()
        {
            InitializeComponent();

            melhoresAptidoes = new List<double>();

            this.dataSourceExecucoes = new List<DataSourceExecucoes>();

            grafico.Refresh();
            grafico.Plot.SetInnerViewLimits(-100, 100, -100, 100);
            grafico.Plot.SetOuterViewLimits(-100, 100, -100, 100);

            graficoAptidao.Refresh();

            if (this.PE())
            {
                this.ComportamentoPE();
            }

            if (this.AG())
            {
                this.ComportamentoAG();
            }

            this.btnNovo.Enabled = false;
        }

        private void ComportamentoAG()
        {
            estrategiaAG = new EstrategiaAG(tamanhoPopulacaoAG);
            lblPopulacao.Text = "Tamanho População Pais: " + estrategiaAG.Pais.Count;
            aptidao.Text = "Melhor aptidão: ";
        }

        private void ComportamentoPE()
        {
            estrategiaPE = new EstrategiaPE(tamanhoPopulacaoPE);
            lblPopulacao.Text = "Tamanho População: " + estrategiaPE.Individuos.Count;
            aptidao.Text = "Melhor aptidão: ";
        }

        public void AtualizarGraficos()
        {
            if (this.PE())
            {
                this.GraficosPE();
            }

            if (this.AG())
            {
                this.GraficosAG();
            }
        }

        private void GraficosAG()
        {
            var listaAptidao = new List<double>();

            foreach (var item in estrategiaAG.Pais)
            {
                if (plotarGraficos)
                {
                    grafico.Plot.AddPoint(item.X(), item.Y(), Color.Blue);
                }

                listaAptidao.Add(item.Aptidao());
            }

            if (plotarGraficos)
            {
                foreach (var item in estrategiaAG.FilhosParaGrafico)
                {

                    grafico.Plot.AddPoint(item.X(), item.Y(), Color.Red);
                }
            }

            grafico.Plot.AddCrosshair(0, 0);

            estrategiaAG.FilhosParaGrafico.Clear();

            var melhorAptidao = listaAptidao.Max();

            melhorIndividuo = estrategiaAG.Pais.Where(x => x.Aptidao() == melhorAptidao).First();

            this.melhoresAptidoes.Add(melhorAptidao);

            aptidao.Text = "Melhor aptidão: " + melhorIndividuo.Aptidao();
        }

        private void GraficosPE()
        {
            var listaAptidao = new List<double>();

            foreach (var item in estrategiaPE.Individuos)
            {
                if (plotarGraficos)
                {
                    grafico.Plot.AddPoint(item.X(), item.Y(), Color.Blue);
                }

                listaAptidao.Add(item.Aptidao());
            }

            grafico.Plot.AddCrosshair(0, 0);

            var melhorAptidao = listaAptidao.Max();

            melhorIndividuo = estrategiaPE.Individuos.Where(x => x.Aptidao() == melhorAptidao).First();

            this.melhoresAptidoes.Add(melhorAptidao);

            aptidao.Text = "Melhor aptidão: " + melhorIndividuo.Aptidao();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            this.iniciar.Enabled = false;

            if (this.PE())
            {
                this.IniciarPE();
            }

            if (this.AG())
            {
                this.IniciarAG();
            }

            this.btnNovo.Enabled = true;
        }

        private void IniciarPE()
        {
            for (int j = 1; j <= qntExecucoes; j++)
            {

                for (int i = 0; i <= qntGeracoesPE; i++)
                {
                    grafico.Plot.Clear();
                    AtualizarGraficos();
                    grafico.Refresh();
                    graficoAptidao.Refresh();

                    lblPopulacao.Text = "Tamanho População: " + estrategiaPE.Individuos.Count;
                    lblGeracoes.Text = "Geração: " + i;
                    lblx.Text = "X: " + melhorIndividuo.X();
                    lblY.Text = "Y: " + melhorIndividuo.Y();

                    estrategiaPE.Iniciar();

                    if (plotarGraficos)
                    {
                        graficoAptidao.Plot.Clear();
                        graficoAptidao.Plot.AddBar(this.melhoresAptidoes.ToArray(), color: Color.CadetBlue);
                        this.dataGridView1.DataSource = estrategiaPE.ObtemDataSourcePopulacao().OrderByDescending(x => x.Aptidao).ToList();
                    }

                    if (this.Parar)
                    {
                        break;
                    }
                }


                this.dataSourceExecucoes.Add(new DataSourceExecucoes(j, this.melhorIndividuo));
                this.dataGridView2.DataSource = this.dataSourceExecucoes.ToList();
                this.PreparanovaExecucao();
            }

        }

        private void IniciarAG()
        {
            for (int j = 1; j <= qntExecucoes; j++)
            {
                for (int i = 1; i <= qntGeracoesAG; i++)
                {
                    grafico.Plot.Clear();
                    AtualizarGraficos();
                    grafico.Refresh();

                    graficoAptidao.Refresh();


                    lblPopulacao.Text = "Tamanho População Pais: " + estrategiaAG.Pais.Count;
                    lblGeracoes.Text = "Geração: " + i;

                    lblx.Text = "X: " + melhorIndividuo.X();
                    lblY.Text = "Y: " + melhorIndividuo.Y();

                    estrategiaAG.Iniciar();

                    if (plotarGraficos)
                    {
                        graficoAptidao.Plot.Clear();
                        graficoAptidao.Plot.AddBar(this.melhoresAptidoes.ToArray(), color: Color.CadetBlue);
                        this.dataGridView1.DataSource = estrategiaAG.ObtemDataSourcePais().OrderByDescending(x => x.Aptidao).ToList();
                    }

                    if (this.Parar)
                    {
                        break;
                    }
                }


                this.dataSourceExecucoes.Add(new DataSourceExecucoes(j, this.melhorIndividuo));
                this.dataGridView2.DataSource = this.dataSourceExecucoes.ToList();


                this.PreparanovaExecucao();
            }

            var detalhes = new List<DataSourceAptidoesAgrupadas>();

            var agrupado = this.dataSourceExecucoes.GroupBy(x => x.Aptidao);

            foreach(var i in agrupado)
            {
                detalhes.Add(new DataSourceAptidoesAgrupadas() { Aptidao = i.Key, QuantidadeIndividuos = i.Count() });
            }

            this.dataGridView3.DataSource = detalhes.ToList();
        }

        private bool AG()
        {
            return this.tipoEstrategia == EnumTipoEstrategia.AG;
        }

        private bool PE()
        {
            return this.tipoEstrategia == EnumTipoEstrategia.PE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreparanovaExecucao();
        }

        private void PreparanovaExecucao()
        {
            estrategiaPE = new EstrategiaPE(tamanhoPopulacaoPE);
            estrategiaAG = new EstrategiaAG(tamanhoPopulacaoAG);

            grafico.Plot.Clear();
            grafico.Refresh();
            graficoAptidao.Plot.Clear();
            graficoAptidao.Refresh();

            this.melhoresAptidoes.Clear();
            this.melhorIndividuo = null;

            iniciar.Enabled = true;

            this.Parar = false;

            lblPopulacao.Text = "Tamanho População: ";
            lblGeracoes.Text = "Geração: ";
            lblx.Text = "X: ";
            lblY.Text = "Y: ";

            this.AtualizaLabelPopulacao();

            aptidao.Text = "Melhor aptidão: ";

            this.btnNovo.Enabled = false;
        }

        private void AtualizaLabelPopulacao()
        {
            if (this.PE())
            {
                lblPopulacao.Text = "Tamanho População: " + estrategiaPE.Individuos.Count;
            }

            if (this.AG())
            {

                lblPopulacao.Text = "Tamanho População: " + estrategiaAG.Pais.Count;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            this.Parar = true;
        }
    }
}