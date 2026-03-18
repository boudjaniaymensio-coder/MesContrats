using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Contrat
{
    private string _numContrat;
    private DateTime _dateContrat;
    private DateTime _dateDebut;
    private DateTime _dateRetour;
    private double _montant;
    private Vehicule _vehicule;
    public Contrat(string numContrat, DateTime dateContrat, DateTime dateDebut, DateTime dateRetour, double montant, Vehicule vehicule)
    {
        _numContrat = numContrat;
        _dateContrat = dateContrat;
        _dateDebut = dateDebut;
        _dateRetour = dateRetour;
        _montant = montant;
        _vehicule = vehicule;
    }
    public string ToString()
    {
        return $"Numéro de contrat: {_numContrat}, Date du contrat: {_dateContrat}, Date de début: {_dateDebut}, Date de retour: {_dateRetour}, Montant: {_montant}, Véhicule: {_vehicule}";
    }
}