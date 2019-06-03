using System;

namespace Main.LogicLayer
{
    class Stands
    {
        #region Propriétés privées

        // Propriétés privées
        private int id;
        private float area;
        private int numAllee;
        private char numOrdre;
        private bool available;
        private Partenaire partenaire;
        #endregion

        public Stands(int id, float area, int numAllee, char numOrdre, bool available)
        {
            this.id = id;
            this.area = area;
            this.numAllee = numAllee;
            this.numOrdre = numOrdre;
            this.available = available;

        }

        public Stands(int id, float area, int numAllee, char numOrdre, bool available, Partenaire partenaire) : this(id, area, numAllee, numOrdre, available)
        {
            this.Partenaire = partenaire;
        }

        public void test()
        {
            Console.WriteLine("Test");
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public float Area
        {
            get
            {
                return area;
            }
        }

        public int NumAllee
        {
            get
            {
                return numAllee;
            }
        }

        public char NumOrdre
        {
            get
            {
                return numOrdre;
            }
        }

        public bool Available
        {
            get
            {
                return available;
            }

            set
            {
                available = value;
            }
        }

        internal Partenaire Partenaire { get => partenaire; set => partenaire = value; }

    }
}
