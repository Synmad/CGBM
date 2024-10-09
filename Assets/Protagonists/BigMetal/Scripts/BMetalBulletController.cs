using UnityEngine;

public class BMetalBulletController : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
