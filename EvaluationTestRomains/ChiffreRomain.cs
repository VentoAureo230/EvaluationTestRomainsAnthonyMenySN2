namespace ConvertisseurRomain
{
    public class NombreRomain
    {
        private readonly string _lettre;
        private readonly int _valeur;

        public static readonly NombreRomain LettreI = new("I", 1);

        private NombreRomain(string lettre, int valeur)
        {
            _lettre = lettre;
            _valeur = valeur;
        }

        public string Prédécesseur
        {
            get
            {
                var avant = _lettre[..^1];
                var apres = _lettre.Last();
                return avant + LettreI + apres;
            }
        }

        public string Affichage(int nombre)
        {
            return _lettre + new string('I', nombre - _valeur);
        }

        /// <inheritdoc />
        public override string ToString() => _lettre;
    }
}