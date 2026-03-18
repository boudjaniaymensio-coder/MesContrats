namespace MesContrats
{
    public class Categorie
    {
        private string _categLoc;
        private string description;
        private double _mtnCaution;
        private double _tarifjour;

        public Categorie(string categLoc, string description, double mtnCaution, double tarifjour)
        {
            _categLoc = categLoc;
            this.description = description;
            _mtnCaution = mtnCaution;
            _tarifjour = tarifjour;
        }
        public string CategLoc()
        {
            return _categLoc; 
        }
        public string Description()
        {
            return description;
        }
        public double MtnCaution()
        {
            return _mtnCaution;
        }
        public double Tarifjour()
        {
            return _tarifjour;
        }
        public override string ToString()
        {
            return $"Catégorie de location: {CategLoc()}, Description: {Description()}, Montant de caution: {MtnCaution()}, Tarif journalier: {Tarifjour()}";
        }
    }
}
