using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProfessionalCustomer : Customer
{
public string companyName;

public ProfessionalCustomer(string company){
    this.companyName = company;
}

public override void BuyThings(){
    Debug.Log("professionnal buys");

}
}
