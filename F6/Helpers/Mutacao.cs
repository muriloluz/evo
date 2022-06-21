﻿using F6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public static class Mutacao
    {
        public static void Muta(Individuo individuo, int taxaMutacao)
        {
            for(int i = 0; i < individuo.Genes.Length; i++ )
            {
                var random =  Constantes.Randomico.ProximoInt(101);
                if (random <= taxaMutacao){

                    if (individuo.Genes[i] == '1')
                    {
                        individuo.Genes[i] = '0';
                    }
                    else
                    {
                        individuo.Genes[i] = '1';
                    }
                }
            }
        }
    }
}
