using ConvertisseurRomain;

namespace NombreRomainsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void Convertir1et2et3(int x)
        {
            // ETANT DONNE un nombre x compris entre 1 et 3
            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(x);

            // ALORS on obtient x fois le nombre I
            var result = new String('I', x);
        }

        [Fact]

        public void Convertir4enIV()
        {
            // ETANT DONNE le chiffre 4
            var nombre = 4;

            // QUAND on le convertit en nombre romains
            var attendu = ConvertisseurNombresRomains.Convert(nombre);

            // ALORS on obtient le nombre IV
            Assert.Equal("IV", attendu);
        }
    }
}