using UnityEngine;

public class CGuyRunController : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float runSpeed;

    private void FixedUpdate()
    {
        rb.velocity = CGuyInput.instance.runningDirection * runSpeed;
    }
}
