using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int maxAmount = 5;
    public int random;

    public BoxCollider2D bc;

    Vector2 cubeSize;
    Vector2 cubeCenter;

    [System.Serializable]
    public class enemySpawn
    {
        public GameObject go;
        public int lowNum;
        public int highNum;
    }
    public enemySpawn[] enemies;


    GameManager gm;
    // Start is called before the first frame update

    private void Awake()
    {
        Transform cubeTrans = bc.GetComponent<Transform>();
        cubeCenter = cubeTrans.position;
        maxAmount = Random.Range(1, 10);

        gm = FindObjectOfType<GameManager>();

        // Multiply by scale because it does affect the size of the collider
        cubeSize.x = cubeTrans.localScale.x * bc.size.x;
        cubeSize.y = cubeTrans.localScale.y * bc.size.y;
    }

    public void Start()
    {
        for (int i = 0; i < maxAmount; i++)
        {
            Spawn();
            gm.EnemiesLeft++;
        }
    }
    public void Spawn()
    {
        random = Random.Range(1, 100);

        for (int i = 0; i < enemies.Length; i++)
        {
            if (random >= enemies[i].lowNum && random <= enemies[i].highNum)
            {
                Instantiate(enemies[i].go, GetRandomPosition(), Quaternion.identity, this.transform);
            }
        }
        
    }

   
    private Vector2 GetRandomPosition()
    {
        // You can also take off half the bounds of the thing you want in the box, so it doesn't extend outside.
        // Right now, the center of the prefab could be right on the extents of the box
        Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));

        return cubeCenter + randomPosition;
    }
}
