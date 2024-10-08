using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMetalBulletPoolController : MonoBehaviour
{
    public static BMetalBulletPoolController Instance { get; private set; }

    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _poolSize;
    
    List<GameObject> _pooledBullets;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }

        _pooledBullets = new List<GameObject>();
        GameObject bulletInstance;

        for (int i = 0; i < _poolSize; i++)
        {
            bulletInstance = Instantiate(_bulletPrefab);
            bulletInstance.SetActive(false);
            _pooledBullets.Add(bulletInstance);
        }
    }

    public GameObject GetPooledBullets()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            if (!_pooledBullets[i].activeInHierarchy)
            {
                return _pooledBullets[i];
            }
        }
        return null;
    }

    //public GameObject GetPooledObjects()
    //{
    //    for (int i = 0; i < poolSize; i++) { if (!pooledObjects[i].activeInHierarchy) { return pooledObjects[i]; } }
    //    return null;
    //}
}
