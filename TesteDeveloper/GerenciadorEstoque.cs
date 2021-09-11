﻿using System;
using System.Collections.Generic;

namespace TesteDeveloper
{
    /// <summary>
    /// Implementação da administração de estoque
    /// </summary>
    public class GerenciadorEstoque
    {
        //Saldos de estoque por referência
        private readonly IList<EstoqueProduto> _estoques;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="estoques">Saldos de estoquee por referência</param>
        public GerenciadorEstoque(IList<EstoqueProduto> estoques)
        {
            _estoques = estoques ?? throw new ArgumentNullException(nameof(estoques));
        }

        /// <summary>
        /// Verifica se a quantidade requerida existe no estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <param name="quantidadeRequerida">Quantidade requerida</param>
        /// <returns>Indica se a quantidade requerida existe ou não no estoque</returns>
        public bool EstoqueDisponivel(string referencia, int quantidadeRequerida)
        {
            //TODO - Implemente sua lógica para validar o estoque da referência contra a quantidade requerida
            //Dica: Os estoques estão na lista _estoques inicializada no construtor

            int qt = quantidadeRequerida;
            for (int i = 0; i < _estoques.Count; i++)
            {
                var est = _estoques[i];
                if (est.Referencia == referencia)
                {
                    if (est.SaldoEstoque >= qt) //se 
                    {
                        return true;
                    }
                    else //senao
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Buscar saldo de estoque da referência
        /// </summary>
        /// <param name="referencia">Identificador da referência/produto</param>
        /// <returns>Saldo de estoque</returns>
        public int GetSaldo(string referencia)
        {
            //TODO - Implemente sua lógica para buscar e retornar o estoque da referência
            //Dica: Os estoques estão na lista _estoques inicializada no construtor

            int qt = 0;
            for (int i = 0; i < _estoques.Count; i++)
            {
                var est = _estoques[i];
                if (est.Referencia == referencia)
                {
                    int saldo = est.SaldoEstoque;
                    return saldo;
                }
            }
            return qt;
        }


        /// <summary>
        /// Gera string com os estoques no formato [Referência: {Referencia} Saldo: {SaldoEstoque}] com uma linha para cada referência
        /// Ex: 
        /// Referência: A345 Saldo: 98
        /// Referência: B456 Saldo: 15
        /// 
        /// </summary>
        /// <returns>String formatada</returns>
        public override string ToString()
        {
            //TODO - Implemente sua lógica para formatar uma string no formato esperado
            //Dica: Os estoques estão na lista _estoques inicializada no construtor

            string retorno = "";
            int contador = _estoques.Count;
            for (int i = 0; i < contador; i++)
            {
                String referencia = _estoques[i].Referencia;
                String saldo = _estoques[i].SaldoEstoque.ToString();
                retorno = (retorno + "Referencia: " + referencia + " Saldo: " + saldo + "\n");
            }
            return retorno;
        }


    }
}
