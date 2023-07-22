using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab = null;
    [SerializeField] private GameObject flyEnemyPrefab = null;


    private GameObject enemy;
    private GameObject flyEnemy;
    private float speedOfEnemies = 0.1f;

    void OnEnable()
    {
        Messenger<float>.AddListener(GameEvents.SPAWNED_SPEED, ChangeSpeedOfSpawnedEnemies);
    }

    void OnDisable()
    {
        Messenger<float>.RemoveListener(GameEvents.SPAWNED_SPEED, ChangeSpeedOfSpawnedEnemies);
    }
    private void ChangeSpeedOfSpawnedEnemies(float newDisplacement)
    {
        speedOfEnemies = newDisplacement;
    }
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
            Messenger.Broadcast(GameEvents.ENEMY_SPAWNED);
            Messenger<float>.Broadcast(GameEvents.SPEED_CHANGED, speedOfEnemies);
        }

        if(flyEnemy == null) {
            flyEnemy = Instantiate(flyEnemyPrefab) as GameObject;
            Messenger.Broadcast(GameEvents.ENEMY_SPAWNED);
            Messenger<float>.Broadcast(GameEvents.SPEED_CHANGED, speedOfEnemies);
        }
        
    }
}
