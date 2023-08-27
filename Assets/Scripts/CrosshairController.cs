using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CrosshairController : MonoBehaviour
{
    public AudioSource gunsound;
    private void Awake()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.visible = false;
            // Membuat ray dari kamera ke arah crosshair
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            gunsound.Play();

            // Jika ray mengenai objek dengan tag "Enemy", hancurkan objek tersebut
            if (hit.collider != null && hit.collider.tag == "Enemy")
            {
                
                Destroy(hit.collider.gameObject);
                ScoreText.score += 10;
            }
        }
    }
}
