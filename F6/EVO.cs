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
        private Populacao populacao;
        private Individuo melhorIndividuo;
        private const int tamanhoPopulacao = 100;
        private const int qntGeracoes = 1000;

        public EVO()
        {
            InitializeComponent();
            grafico.Refresh();
            graficoAptidao.Refresh();
            populacao = new Populacao(tamanhoPopulacao);

            lblPopulacao.Text = "Tamanho População: " + populacao.Individuos.Count;
            aptidao.Text = "Melhor aptidão: ";
            this.btnNovo.Enabled = false;
        }

        public void AtualizarGraficos()
        {
            var listaAptidao = new List<double>();

            foreach(var item in populacao.Individuos)
            {
                grafico.Plot.AddPoint(item.X(), item.Y());
                listaAptidao.Add(item.Aptidao());   
            }

            var melhorAptidao = listaAptidao.Max();
            graficoAptidao.Plot.AddVerticalLine(listaAptidao.Max());
            melhorIndividuo = populacao.Individuos.Where(x => x.Aptidao() == melhorAptidao).First();
            aptidao.Text = "Melhor aptidão: " + listaAptidao.Max();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            this.iniciar.Enabled = false;

            for(int i = 0; i <= qntGeracoes; i ++) { 
                grafico.Plot.Clear();
                AtualizarGraficos();
                grafico.Refresh();
                graficoAptidao.Refresh();

                lblPopulacao.Text = "Tamanho População: " + populacao.Individuos.Count;
                lblGeracoes.Text = "Geração: " + i;
                lblx.Text = "X: " + melhorIndividuo.X();
                lblY.Text = "Y: " + melhorIndividuo.Y();

                populacao.EstrategiaGA();

            }

            this.btnNovo.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            populacao = new Populacao(tamanhoPopulacao);
            grafico.Plot.Clear();
            grafico.Refresh();
            graficoAptidao.Plot.Clear();
            graficoAptidao.Refresh();

            iniciar.Enabled = true;


            lblPopulacao.Text = "Tamanho População: ";
            lblGeracoes.Text = "Geração: ";
            lblx.Text = "X: ";
            lblY.Text = "Y: ";

            lblPopulacao.Text = "Tamanho População: " + populacao.Individuos.Count;
            aptidao.Text = "Melhor aptidão: ";

            this.btnNovo.Enabled = false;
        }
    }
}