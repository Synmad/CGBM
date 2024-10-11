using System.Collections;
using UnityEngine;

public class BoostController : MonoBehaviour
{
    [SerializeField] private float _resetDelay;

    [SerializeField] private BoxCollider2D _collider;
    [SerializeField] private SpriteRenderer _sprite;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<CGuyDashController>().ReadyDash();
            StartCoroutine(Reset());
        }
    }

    private IEnumerator Reset()
    {
        _collider.enabled = false;
        _sprite.enabled = false;

        yield return new WaitForSeconds(_resetDelay);

        _collider.enabled = true;
        _sprite.enabled = true;
    }
}
