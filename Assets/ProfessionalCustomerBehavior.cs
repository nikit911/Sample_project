using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfessionalCustomerBehavior : MonoBehaviour
{
    public ProfessionalCustomer pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = new ProfessionalCustomer("Microsoft");
        pc.firstName = "bill";
        pc.BuyThings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
