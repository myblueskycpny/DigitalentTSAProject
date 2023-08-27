using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private float moveSpeed; // Kecepatan pergerakan
    private Camera mainCamera;

    private void Start()
    {
        moveSpeed = Random.Range(5f, 10f);
        mainCamera = Camera.main;
    }
    void Update()
    {
        // Menghitung pergerakan berdasarkan waktu dan kecepatan
        float movement = moveSpeed * Time.deltaTime;

        // Menggerakkan objek ke arah kiri
        transform.Translate(Vector3.left * movement);
        Vector2 screenPosition = mainCamera.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0)
        {
            Destroy(gameObject, 1f);
        }
    }

}
