
using System;

using Calculadora.Services; // importação da pasta Services da raiz Calculadora

namespace CalculadoraTeste
{

    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes; // declara da classe dentro do escopo da classe teste

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString(); // classe a ser testada instanciada dentro do construtor
        }

        [Fact]
        public void Contar3CaracteresEmOlaEretornar3()
        {
            // Arrange
            string txt = "Olá"; // declaração de variável a ser usada no teste(cenário)

            // Act
            int resultado = _validacoes.ContarCaracteres(txt); // chamando o método a ser testado

            //Assert
            Assert.Equal(3, resultado); // verificando se o resultado está como esperado
        }
    }
}
