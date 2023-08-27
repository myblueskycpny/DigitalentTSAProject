using UnityEngine;

public class DestroyAndSpawnParticles : MonoBehaviour
{
    public ParticleSystem particleSystemPrefab; // Seret Prefab Particle System ke sini melalui Inspector

    private void OnDestroy()
    {
        if (particleSystemPrefab != null)
        {
            // Membuat instance baru dari Particle System Prefab
            ParticleSystem newParticleSystem = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);

            // Memainkan Particle System yang baru dibuat
            newParticleSystem.Play();
        }
    }
}
