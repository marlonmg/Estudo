using System;
using System.Collections.Generic;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero", FormatandoNumero.Executar},
                {"Conversões", Conversoes.Executar},
                {"Operadores Aritméticos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais", OperadoresRelacionais.Executar},
                {"Operadores Logicos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição", OperadoresAtribuicao.Executar},
                               
                //Estrutura de Controle
                {"Estrutura If", EstruturaIf.Executar},

                //Classes e Métodos
                {"Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e metodos", Construtores.Executar},
                {"Construtores - Classes com retorno", MetodosComRetorno.Executar},
            });

            central.SelecionarEExecutar();
        }
    }   
}