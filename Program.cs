using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variais e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUniarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
                
                // Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                { "Estrutura DoWhile - Estrutura de Controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                { "Estrutura Foreach - Estrutura de Controle", EstruturaForeach.Executar},
                { "Usando Break - Estrutura de Controle", EstruturaBreak.Executar},
                { "Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parametros Nomeados - Classes e Métodos", ParamsNomeados.Executar},
                { "Get Set - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Readonly - Classes e Métodos", Readonly.Executar},
                { "Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Exemplo Struct - Classes e Métodos", Struct.Executar},
                { "Struct Vs Class- Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos",ParametrosPorReferencia.Executar},
                { "Parâmetros com Valor Padrão - Classes e Métodos",ParametroPadrao.Executar},

                // Coleções
                { "Array - Coleções",Colecoes.Array.Executar},
                { "List - Coleções",ColecoesList.Executar},
                { "Coleção List - Coleções",ColecoesArrayList.Executar},
                { "Coleção Set - Coleções",ColecoesSet.Executar},
                { "Coleção Queue - Coleções",ColecoesQueue.Executar},
                { "Igualdade - Coleções",Igualdade.Executar},
                { "Coleções Stack - Coleções",ColecoesStack.Executar},
                { "Coleções Dictionary - Coleções",ColecoesDictionary.Executar},

                // OO
                { "Herança - OO",Heranca.Executar},
                { "Construtor This - OO",ConstrutorThis.Executar},
                { "Encapsulamento - OO",Encapsulamento .Executar},
                { "Polimorfismo - OO",Polimorfismo.Executar},
                { "Abstract - OO",Abstract.Executar},
                { "Interface - OO",Interface.Executar},
                { "Sealed - OO",Sealed.Executar},

                // Métodos & Funções
                { "Exemplo Lambda - Métodos & Funções",ExemploLambda.Executar},
                { "Exemplo Lambda com Delegates - Métodos & Funções",LambdaDelegate.Executar},
                { "Usando Delegates - Métodos & Funções",UsandoDelegates.Executar},
                { "Delegates Como Função Anonima - Métodos & Funções",DelegateFunAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos & Funções",DelegatesComoParametros.Executar},
                { "Métodos de Extensão - Métodos & Funções",MetodosDeExtensao.Executar},

                // Exceções
                { "Primeira Exceção - Exceções",PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções",ExcecoesPersonalizadas.Executar},
                
                // Api
                { "Primeiro Arqueivo usando Api - Api",PrimeiroArquivo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}