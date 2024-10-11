using UnityEngine;

public class EnemyCollisionController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<HurtController>().TakeDamage();
        }
    }
}
