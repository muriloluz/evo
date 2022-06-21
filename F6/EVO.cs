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
        private const int qntGeracoesPE = 100;

        private EstrategiaAG estrategiaAG;
        private const int tamanhoPopulacaoAG = 100;
        private const int qntGeracoesAG = 1000;

        private Individuo melhorIndividuo;

        public EVO()
        {
            InitializeComponent();

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
                grafico.Plot.AddPoint(item.X(), item.Y(), Color.Blue);
                listaAptidao.Add(item.Aptidao());
            }

            foreach (var item in estrategiaAG.FilhosParaGrafico)
            {
                grafico.Plot.AddPoint(item.X(), item.Y(), Color.Red);
            }

            estrategiaAG.FilhosParaGrafico.Clear();

            var melhorAptidao = listaAptidao.Max();

            graficoAptidao.Plot.AddVerticalLine(listaAptidao.Max());

            melhorIndividuo = estrategiaAG.Pais.Where(x => x.Aptidao() == melhorAptidao).First();

            aptidao.Text = "Melhor aptidão: " + melhorIndividuo.Aptidao();
        }

        private void GraficosPE()
        {
            var listaAptidao = new List<double>();

            foreach (var item in estrategiaPE.Individuos)
            {
                grafico.Plot.AddPoint(item.X(), item.Y());
                listaAptidao.Add(item.Aptidao());
            }

            var melhorAptidao = listaAptidao.Max();
            graficoAptidao.Plot.AddVerticalLine(listaAptidao.Max());

            melhorIndividuo = estrategiaPE.Individuos.Where(x => x.Aptidao() == melhorAptidao).First();

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

            }
        }

        private void IniciarAG()
        {
            for(int i = 0; i <= qntGeracoesAG; i++)
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
            }
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
            estrategiaPE = new EstrategiaPE(tamanhoPopulacaoPE);
            estrategiaAG = new EstrategiaAG(tamanhoPopulacaoAG);

            grafico.Plot.Clear();
            grafico.Refresh();
            graficoAptidao.Plot.Clear();
            graficoAptidao.Refresh();

            iniciar.Enabled = true;

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

            if (this.AG()){

                lblPopulacao.Text = "Tamanho População: " + estrategiaAG.Pais.Count;
            }
        }
    }
}