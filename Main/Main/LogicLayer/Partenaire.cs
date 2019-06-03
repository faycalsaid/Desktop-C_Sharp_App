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
            this.Id = id;
            this.Nom = nom;
            this.Ville = ville;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        #endregion



    }
}
