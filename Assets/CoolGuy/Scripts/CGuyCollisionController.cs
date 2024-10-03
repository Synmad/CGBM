using UnityEngine;

public class CGuyCollisionController : MonoBehaviour
{
    public static CGuyCollisionController instance { get; private set; }

    [field:SerializeField] public bool isOnFlat { get; private set; }

    Vector2 _normal;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(this); }
    }

    void EvaluateCollision(Collision2D collision)
    {
        for(int i = 0; i < collision.contactCount; i++) 
        {
            _normal = collision.GetContact(i).normal;

            if(_normal.y >= 0.9f) { isOnFlat = true; }
        }
    }
}
