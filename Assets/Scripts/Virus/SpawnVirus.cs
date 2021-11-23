using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirus : MonoBehaviour
{
    public GameObject VirusObstacle;

    [Header("Spawn Obstacle Position")]
    [SerializeField]
    private float _maxX;

    [SerializeField]
    private float _minX;

    [SerializeField]
    private float _maxY;

    [SerializeField]
    private float _minY;

    [SerializeField]
    private float _timeBetweenSpawn;

    private float _spawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this._spawnTime)
        {
            Spawn();

            this._spawnTime = Time.time + this._timeBetweenSpawn;
        }
    }

    private void Spawn()
    {
        float spawnRandomX = Random.Range(this._minX, this._maxX);

        float spawnRandomY = Random.Range(this._minY, _maxY);

        // Spawn virus obstacle
        Instantiate(this.VirusObstacle, transform.position + new Vector3(spawnRandomX, spawnRandomY, 0), transform.rotation);
    }
}
