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
            this._categLoc = categLoc;
            this.description = description;
            this._mtnCaution = mtnCaution;
            this._tarifjour = tarifjour;
        }
        public override string ToString()
        {
            return 

        }



    }
}
