using MesContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesContrats
{
    internal class vehicule
    {
    }
}
public class Vehicule
{
    private string _immatriculation;
    private string _marque;
    private string _modele;
    private string _annee;
    private string _detailPrestation;
    private int _Kilometrage;
    private bool _disponibilite;
    private Categorie _categorie;
    public Vehicule(string immatriculation, string marque, string modele, string annee, string detailPrestation, int kilometrage, bool disponibilite, Categorie categorie )
    {
       _immatriculation = immatriculation;
       _marque = marque;
       _modele = modele;
       _annee = annee;
       _detailPrestation = detailPrestation;
       _Kilometrage = kilometrage;
       _disponibilite = disponibilite;
       _categorie = categorie;
    }
    
}