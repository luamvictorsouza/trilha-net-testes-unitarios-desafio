using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "a";
        var resultadoEsperado = 0;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(true);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(true);
    }

    //TODO: Corrigir a anotação [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}

using TestesUnitarios.Desafio.Console.Services;
using Xunit;
using System.Collections.Generic;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

            // Act
            var resultado = _validacoes.MultiplicarElementosPorDois(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado);
        }
    }
}
