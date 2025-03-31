using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int scoreValue = 10;
    public GameObject hitEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            ScoreManager.instance.AddScore(scoreValue);

            if (hitEffect)
                Instantiate(hitEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }

        // Optional: destroy after hitting anything else
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 3f); // Clean up
        }
    }
}
