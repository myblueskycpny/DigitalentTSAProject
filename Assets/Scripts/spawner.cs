using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Prefab objek yang ingin di-spawn
    public float minY = 0f; // Posisi Y minimum untuk spawning
    public float maxY = 10f; // Posisi Y maksimum untuk spawning

    public float minSpawnRate = 1f; // Tingkat spawn minimum (detik per objek)
    public float maxSpawnRate = 3f; // Tingkat spawn maksimum (detik per objek)

    private float nextSpawnTime = 0f;

    void Start()
    {
        CalculateNextSpawnTime();
    }

    void Update()
    {
        // Memeriksa poin pemain
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();

            // Memperbarui tingkat spawn berdasarkan poin pemain
            if (ScoreText.score >= 20)
            {
                // Jika pemain telah mencapai 10 poin, tingkat spawn akan semakin cepat
                minSpawnRate = 0.5f;
                maxSpawnRate = 2.0f;
            }
            else if (ScoreText.score >= 100)
            {
                // Jika pemain telah mencapai 20 poin, tingkat spawn akan semakin cepat lagi
                minSpawnRate = 0.2f;
                maxSpawnRate = 1.0f;
            }

            CalculateNextSpawnTime();
        }
    }


    void CalculateNextSpawnTime()
    {
        // Menghitung waktu spawn berikutnya dengan jarak waktu spawn acak antara minSpawnRate dan maxSpawnRate
        nextSpawnTime = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
    }

    void SpawnObject()
    {
        // Mendapatkan posisi acak untuk Y
        float randomY = Random.Range(minY, maxY);

        // Membuat posisi baru dengan Y acak dan X dari posisi spawner
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        // Men-spawn objek pada posisi yang sudah dihitung
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
