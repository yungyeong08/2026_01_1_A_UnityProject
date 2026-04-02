
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject coinPrefabs;
    public GameObject MissilePrefabs;

    [Header("스폰 타이밍 설정 ")]
    public float minSpawnInterval = 0.5f;
    public float maxspawnInterval = 2.0f;

    
    [Header("동전 스폰 확률 설정")]
    [Range(0, 100)]
    public int coinSpawnChance = 50;

    public float nextSpawnTime;
    public float timer = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >  nextSpawnTime)
        {
            SpawnObject();
            timer = 0.0f;
            SetNextSpawnTime();
        }
    }
    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnInterval, maxspawnInterval);
    }

    void SpawnObject()
    {
        Transform spawnTransform = transform;

        int randomVlaue = Random.Range(0, 100);

        if (randomVlaue < coinSpawnChance)
        { 
            Instantiate(coinPrefabs, spawnTransform.position, spawnTransform.rotation);
        }

        else
        {
            Instantiate(MissilePrefabs, spawnTransform.position, spawnTransform.rotation);
        }


          
    }

        
}
