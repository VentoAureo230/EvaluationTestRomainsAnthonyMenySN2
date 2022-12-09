namespace ConvertisseurRomain
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convert(int nombre)
            => nombre switch
               {
                   <= 3 => NombreRomain.LettreI.Affichage(nombre),
                   4 => NombreRomain.LettreV.Prédécesseur,
                   <= 8 => NombreRomain.LettreV.Affichage(nombre),
                   9 => NombreRomain.LettreX.Prédécesseur,
                   <= 13 => NombreRomain.LettreX.Affichage(nombre),
                   14 => NombreRomain.ChiffreXV.Prédécesseur,
                   <= 18 => NombreRomain.ChiffreXV.Affichage(nombre),
                   19 => NombreRomain.ChiffreXX.Prédécesseur,
                   <= 23 => NombreRomain.ChiffreXX.Affichage(nombre),
                   24 => NombreRomain.ChiffreXXV.Prédécesseur,
                   <= 28 => NombreRomain.ChiffreXXV.Affichage(nombre),
                   29 => NombreRomain.ChiffreXXX.Prédécesseur,
                   <= 33 => NombreRomain.ChiffreXXX.Affichage(nombre),
                   34 => NombreRomain.ChiffreXXXV.Prédécesseur,
                   <= 38 => NombreRomain.ChiffreXXXV.Affichage(nombre),
                   _ => null
               };
    }
}