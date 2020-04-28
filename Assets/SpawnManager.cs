using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    public static int enemiesCount;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // Instantiate(enemyPrefab, new Vector3(2,2,2), Quaternion.identity);
            Instantiate(enemyPrefab);
        }
    }
}
