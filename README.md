


# Testes Unitários em C#

Os testes estão intimamente ligados à qualidade de um software, servindo principalmente para validar se o que foi construído atende às expectativas do software. Como a qualidade é algo inegociável, os testes devem ser implementados.

# O que são testes unitários?

São testes realizados diretamente no código-fonte, buscando testar a menor unidade de código possível, por meio de cenários que podem ocorrer no sistema.

Os testes devem avaliar todos os cenários possíveis, tanto os positivos quanto os negativos, no caso do usuário fornecer algum dado fora do padrão esperado pelo sistema.

### Vantagens

 * A maior vantagem é a qualidade.
 * Garante que a alteração não tenha impacto no sistema.
 * Menos bugs.
 * Maior confiança de que suas classes e métodos funcionam.
 * Prevenir problemas futuros.

### Frameworks de Testes

 * MSTest
 * NUnit
 * xUnit

Vamos usar o framework xUnit.

# Como iniciar o desenvolvimento de testes com xUnit?

1 - Para iniciar o desenvolvimento com testes xUnit, primeiramente é preciso criar as pastas onde ficarão os projetos do sistema e o projeto de testes, iniciando ambos os projetos com seus respectivos comandos. É importante lembrar que nestes exemplos estamos utilizando um projeto do tipo console.

2 - Na pasta do sistema, inicia-se o projeto com o comando 'dotnet new console' e na pasta de testes, inicia-se o projeto de teste com o comando **'dotnet new xunit'**.

3 - Após isso, com a utilização da extensão vccode-solution-explorer, é possível criar uma solução ou executar o comando **'dotnet new sln -n "NomeDaSolucao"'**.

4 - Depois disso, é preciso adicionar os projetos **'.csproj'** com os quais você estiver trabalhando, tanto o projeto do software quanto o de testes. Para isso, por meio da extensão, é mais fácil: abra-a novamente, clique com o botão direito na sua solução e selecione a opção **"adicionar projeto existente"**. Navegue entre as pastas de cada projeto e selecione os arquivos **'Projeto.csproj'** e **'ProjetoTestes.csproj'**.

*(Por padrão, o projeto de teste sempre tem o sufixo Testes)*

5 - Após isso, é preciso adicionar a referência para o projeto de testes saber onde realizar os testes. Para isso, vá novamente até a extensão solution, clique com o botão direito em cima do **'ProjetoTeste'** e selecione a opção **"adicionar referência"**. Neste exemplo, temos apenas dois projetos, o do software e o de teste, então a extensão vai selecionar a outra opção automaticamente.

A partir disso, os testes podem ser montados.

# Criando os cenários de teste

Para criar os cenários de teste, na pasta do **'ProjetoTeste'**, você deve renomear o arquivo gerado automaticamente **'UniteTest1'** para o nome da sua classe a ser testada com o sufixo *'Teste'* e mudar também o nome da classe no arquivo de teste para que fique igual ao do arquivo.

Para cada classe implementada no seu projeto, uma classe de teste correspondente a ela deve ser criada no **'ProjetoTeste'** (separação por contexto).

### Dentro do método que testa o cenário, são utilizados 3 conceitos: Arrange, Act e Assert.

 * O Arrange monta o cenário proposto.
 * O Act executa a ação chamando o método.
 * O Assert guarda o resultado esperado para ser comparado com o resultado obtido.

Deve ser importada a classe a ser testada, declarada dentro do escopo da classe de teste e criado um construtor no qual a classe declarada será instanciada.

### Criando o cenário de teste

 * No Arrange, são definidos os dados necessários para que o teste ocorra.

 * No Act, é chamado o método que se deseja testar, passando os dados criados no Arrange, e seu retorno é armazenado em uma variável.

 * No Assert, é criada uma comparação do resultado do método chamado no Act com o que se espera.

Obs.: Todo método de teste precisa ter a determinação **'[Fact]'** antes de sua implementação, para que o xUnit reconheça esse método como teste.

# Executando os testes

Para executar o teste, deve-se executar o comando **'dotnet test'** na pasta **'ProjetoTeste'** que você criou.

Com o conceito de **'Theory'**, é possível passar uma cadeia de dados para serem testados. Em vez do método ficar determinado como **'[Fact]'**, ele deve ficar determinado como **'[Theory]'** e nas linhas abaixo são passados os valores a serem testados com a determinação **'[InlineData(dadoASerTestado)]'**. Esse padrão segue uma linha abaixo da outra, alterando apenas o valor do dado a ser testado.

O valor que estiver ocupando o espaço de **'dadoASerTestado'** será transferido para o argumento que o método de teste espera e realizará as operações para cada valor.

Também é possível passar um array de dados a serem testados no lugar do **'dadoASerTestado'**. Assim, o Theory executará um teste com cada valor do array.
