using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float destroyDelay = 2.0f; // Waktu delay sebelum menghancurkan objek

    private void Start()
    {
        // Memulai countdown untuk menghancurkan objek
        Destroy(gameObject, destroyDelay);
    }
}
