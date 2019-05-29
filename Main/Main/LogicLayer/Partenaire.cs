namespace Main.LogicLayer
{
    class Partenaire
    {
        #region Propriétés privées

        // Propriétés privées
        private int id;
        private string nom;
        private string ville;

        public Partenaire(int id, string nom, string ville)
        {
            this.id = id;
            this.nom = nom;
            this.ville = ville;
        }

        #endregion

        public int Id { get => id; }
        public string Nom { get => nom; }
        public string Ville { get => ville; }

    }
}
