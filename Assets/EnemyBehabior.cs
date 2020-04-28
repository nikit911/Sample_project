using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehabior : MonoBehaviour
{
private UIManager _ui;
public void OnEnable() {
    SpawnManager.enemiesCount ++;
    _ui = GameObject.Find("UI_Manager").GetComponent<UIManager>();
    _ui.UpdateEnemyCount();
    Die();
}

public void OnDisable() {
    SpawnManager.enemiesCount --;
    _ui.UpdateEnemyCount();
}
void Die(){
    Destroy(this.gameObject, Random.Range(0,6));
}
}
