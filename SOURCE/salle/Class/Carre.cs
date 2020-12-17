
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Carre {

    public Carre(Rang RangUn, Rang RangDeux) {
        this.RangUn = RangUn;
        this.RangDeux = RangDeux;
        this.nbClients = 8;
        //initialisations par defauts
    }

    private Rang RangUn;

    private Rang RangDeux;

    private int nbClients;


    /// <summary>
    /// Renvoie l'attribut RangUn de type Rang
    /// </summary>

    public Rang GetRangUn() {
        return this.RangUn;
    }

    /// <summary>
    /// Renvoie l'attribut RangDeux de type Rang
    /// </summary>

    public Rang GetRangDeux() {
        return this.RangDeux;
    }

    /// <summary>
    /// Renvoie le nbre de clients
    /// </summary>

    public int GetnbClients()
    {
        return this.nbClients;
    }



}