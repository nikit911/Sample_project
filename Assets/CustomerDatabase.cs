using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    private Customer[] client;
    // Start is called before the first frame update
    void Start()
    {
        client = new Customer[5];
        client[0] = CustomerDescription("bob", "singer", 60, "male", "producer");
        Debug.Log(client[0].firstName);
        client[1] = CustomerDescription("max", "payne", 40, "male", "game character");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Customer CustomerDescription(string firstName, string lastName, int age, string gender, string occupation){
        return new Customer(firstName, lastName, age, gender, occupation);
    }
}
