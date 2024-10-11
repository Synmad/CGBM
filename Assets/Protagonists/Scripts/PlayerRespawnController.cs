using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnController : MonoBehaviour
{
    [Header("Characteristics")]
    [SerializeField] private float _respawnDelay;
    [SerializeField] private Transform _respawnLocation;

    [Header("Component variables")]
    [SerializeField] private CGuyStateManager _state;
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private BoxCollider2D _collider;

    public static Action OnPlayerRespawn;

    private void OnEnable() => HurtController.OnPlayerDeath += StartRespawn;

    private void StartRespawn() => StartCoroutine(Respawn());

    private IEnumerator Respawn()
    {
        _sprite.enabled = false;
        _state.ChangeState(CGuyStateManager.State.Dead);
        _collider.enabled = false;

        yield return new WaitForSeconds(_respawnDelay);

        OnPlayerRespawn?.Invoke();
        transform.position = _respawnLocation.position;
        _sprite.enabled = true;
        _state.ChangeState(CGuyStateManager.State.Default);
        _collider.enabled = true;
    }

    private void OnDisable() => HurtController.OnPlayerDeath -= StartRespawn;
}
