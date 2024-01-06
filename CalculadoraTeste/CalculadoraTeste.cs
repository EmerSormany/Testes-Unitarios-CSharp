using System.Reflection;
using Calculadora.Services; // importação do diretório Services, na raiz Calculadora

namespace CalculadoraTeste;

public class CalculadoraTeste
{

    private CalculadoraImplementacao _calc; // declara da classe dentro do escopo da classe teste

    public CalculadoraTeste()
    {
        _calc = new CalculadoraImplementacao(); // classe a ser testada instanciada dentro do construtor
    }

    [Fact]
    public void DeveSomar5com10eRetornar15()
    {
        //Arrange
        int num1 = 10;  // declaração de variável a ser usada no teste(cenário)
        int num2 = 5;  // declaração de variável a ser usada no teste(cenário)

        //Act
        int resultado = _calc.Somar(num1 , num2); // chamando o método a ser testado

        //Assert
        Assert.Equal(15, resultado); // verificando se o resultado está como esperado
    }

    [Fact] // determinação de método teste
    public void VerificaSe4ehParEretornarVerdadeiro()
    {
        //Arrange
        int num = 4; // declaração de variável a ser usada no teste(cenário)

        //Act
        bool resultado = _calc.ehPar(num); // chamando o método a ser testado

        //Assert
        Assert.True(resultado); // verificando se o resultado está como esperado
    }

    [Fact] // determinação de método teste
    public void VerificaSe5EhParERetornarFalso()
    {
        //Arrange
        int num = 5; // declaração de variável a ser usada no teste(cenário)

        //Act
        bool resultado = _calc.ehPar(num); // chamando o método a ser testado

        //Assert
        Assert.False(resultado); // verificando se o resultado está como esperado
    }

    [Theory] // determinação de testes em cadeia
    [InlineData(1)] // cada numero entre parênteses será passado como valor no argumento num
    [InlineData(3)] // cada numero entre parênteses será passado como valor no argumento num
    [InlineData(5)] // cada numero entre parênteses será passado como valor no argumento num
    [InlineData(7)] // cada numero entre parênteses será passado como valor no argumento num
    public void VerificaSeOsNumerosSaoParesRetornandoFalso(int num)
    {
        //Arrange -> argumento recebido
        
        //Act
        bool resultado = _calc.ehPar(num); // chamando o método a ser testado

        //Assert
        Assert.False(resultado); // verificando se o resultado está como esperado
        // neste Assert foi usado o método False para verificar se o resultado do teste é false
    }

    [Theory] // determinação de testes em cadeia
    [InlineData(new int[] { 2, 4, 8, 6, 10})] // array de dados
    public void VerificaSeOsNumerosSaoPares(int[] numeros) // método espera um array como argumento
    {
        //Arrange -> É o array recebido como argumento
        
        //Act e Assert unidos

        // Método All vai percorrer o array e colocar cada elemento no parâmetro x
        // o x será passado como argumento no método ehPar, que está sendo testado
        // o retorno do método ehPar é o argumento do método True do Assert
        Assert.All(numeros, x => Assert.True(_calc.ehPar(x)));
    }
}