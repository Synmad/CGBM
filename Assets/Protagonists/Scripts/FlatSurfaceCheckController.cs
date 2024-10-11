using System;
using UnityEngine;

public class FlatSurfaceCheckController : MonoBehaviour
{
    [field:SerializeField] public bool IsOnFlat { get; private set; }

    Vector2 _normal;

    public static Action OnLanded;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EvaluateCollision(collision);
        if (IsOnFlat) OnLanded?.Invoke();
    }

    void EvaluateCollision(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++) 
        {
            _normal = collision.GetContact(i).normal;

            if (_normal.y >= 0.9f) IsOnFlat = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) => IsOnFlat = false;
}
