using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab = null;
    [SerializeField] private GameObject fireballPrefab = null;
    private GameObject enemy;
    private GameObject fireball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy == null) {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1.5f, 0);
        }
        if(fireball == null) {
            Vector3 fireballPosition = enemy.transform.position;
            fireballPosition.z += 1f;
            fireball = Instantiate(fireballPrefab) as GameObject;
            fireball.transform.position = fireballPosition;
        }
    }
}
