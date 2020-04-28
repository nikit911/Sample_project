using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabaseInspector : MonoBehaviour
{
    public Customer clientsDb;
   
    void Start()
    {
        clientsDb = new Customer("bob", "marley", 123, "male", "singer");
        clientsDb.BuyThings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
