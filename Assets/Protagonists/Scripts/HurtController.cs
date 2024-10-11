using System;
using UnityEngine;

public class HurtController : MonoBehaviour
{
    public static Action OnPlayerDeath;

    public void TakeDamage() => OnPlayerDeath?.Invoke();
}
