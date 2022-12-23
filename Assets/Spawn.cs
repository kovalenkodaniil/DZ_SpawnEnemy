using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnDelay;

    private float _lastSrawnTime;
    private Transform _spawnPoint;

    private void Start()
    {
        _spawnPoint= GetComponent<Transform>();
    }

    private void Update()
    {
        _lastSrawnTime+= Time.deltaTime;

        if (_lastSrawnTime > _spawnDelay)
        {
            Instantiate(_enemy,_spawnPoint);
            _lastSrawnTime = 0.0f;
        }
    }
}
