using UnityEngine;


public class Collectibles : MonoBehaviour
{
    // Funktion som körs när spelaren kolliderar med objektet
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kontrollera om det är spelaren som kolliderar
        if (other.CompareTag("Player"))
        {
            // Dölj eller förstör objektet
            Destroy(gameObject);
        }
    }
}
