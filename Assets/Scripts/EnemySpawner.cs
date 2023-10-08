using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyModel;
    public int xPos;
    //public int yPos;
    public int zPos;
    public int enemyCount;
    public int maxEnemyCount = 4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (enemyCount <= 1)
        {
            xPos = Random.Range(1, 1);
            zPos = Random.Range(1, 1);
            Instantiate(EnemyModel, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCount += 1;
            if (enemyCount == enemyCount - 1)
            {
                xPos = Random.Range(1, 1);
                zPos = Random.Range(1, 1);
                Instantiate(EnemyModel, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                enemyCount += 1;
            }

        }
    }


}
