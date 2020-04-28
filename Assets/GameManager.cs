using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    GameManager gm = new GameManager();
    
    public Test(){
    //gm.Speed = 50;
    gm.Name = "void";
    //gm.OtherSpeed = 7;
}
    }
    
public class GameManager : MonoBehaviour
{
    public int OtherSpeed { get; private set;}
    private string namePlayer;
    private int _speed;
    public int Speed
    {
        get {
            return _speed;
        }
        private set{
            _speed = value;
        }

    }
    public string Name{
        get{
            return namePlayer;
        }
        set{
            namePlayer = value;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Speed = 50;
        Debug.Log("the speed is "+ Speed);
        namePlayer = "Nikita";
        Debug.Log("the name is "+ Name);
        Name = "joch";
        Debug.Log("the name is "+ Name);
        OtherSpeed = 60;
        Debug.Log("the other speed is "+OtherSpeed);
        otherSpeed(100);
        //Debug.Log("the other speed is "+OtherSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 public void otherSpeed(int speed){
     OtherSpeed = speed;
     Debug.Log("the other speed is "+OtherSpeed);
 }
}
