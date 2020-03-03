using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Set Variables
    public GameObject[] enemyPool;
    public float delay = 2.0f;
    public bool isActive = true;

    public Vector2 direction = new Vector2(1, 1);
    private List<GameObject> targets;
    private Gizmo parentGizmo;

    void Start()
    {
        // Make a parent gizmo for the targets
        parentGizmo = gameObject.GetComponent<Gizmo>();
        targets = parentGizmo.targets;
        // Delay the enemy spawns
        StartCoroutine(EnemyGenerator());
    }

    IEnumerator EnemyGenerator()
    {
        // If the enemies can spawn, delay their spawn, and then place them
        if (isActive)
        {
            Transform newTransform = transform;

            yield return new WaitForSeconds(delay);

            // If the target count is more than 0, spawn the enemy at a random range between 0 and the target count
            if (targets.Count > 0)
            {
                GameObject spawnTarget = targets[Random.Range(0, targets.Count)];
                newTransform = spawnTarget.transform;
                direction = spawnTarget.transform.localScale;
            }

            // Instantiate the enemy prefab as a game object when they spawn
            GameObject clone = Instantiate(enemyPool[Random.Range(0, enemyPool.Length)], newTransform.position, Quaternion.identity) as GameObject;
            clone.transform.localScale = direction;
            StartCoroutine(EnemyGenerator());
        }
    }
}
