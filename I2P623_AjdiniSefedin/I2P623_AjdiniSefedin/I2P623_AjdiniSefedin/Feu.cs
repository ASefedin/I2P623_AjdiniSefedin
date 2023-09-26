using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_AjdiniSefedin
{
    internal class Feu
    {
        private string _couleur;
        private string _identifiant;
        private string _couleur1 = " Orange";
        private string _couleur2 = " Vert";
        
        public string Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }


        public Feu(string identifiant, string couleur)
    {
        _identifiant = identifiant;
        _couleur = couleur;
    }

    public string AfficheEtat()
    {
        string liste = "Le feu de signalisation " + _identifiant + " est" + _couleur ;
        return liste;
    }

    public string AfficheChangementEtatOrange()
        {
            string liste = "Le feu de signalisation " + _identifiant + " est " + _couleur1 ;
            return liste;
            
        }
        public string AfficheChangementEtatVert()
        {
            string liste = "Le feu de signalisation " + _identifiant + " est " + _couleur2 ;
            return liste;
        }

        public string AfficheChangementEtat()
        {
            string liste = "Faire passer le " + _identifiant + " est " + _couleur1 ;
            return liste;
        }
        public string ClignotantEteint()
        {
            string liste =_identifiant + " est éteint" ;
            return liste;
        }
        
        public string ClignotantAllume()
        {
            string liste =_identifiant + " est allumé" ;
            return liste;
        }
    }
    
}
