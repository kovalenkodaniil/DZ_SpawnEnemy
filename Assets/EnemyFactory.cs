using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private bool _isSpawn;

    private void Start()
    {
        StartCoroutine(Spawn(_spawnDelay));
    }

    private IEnumerator Spawn (float delay) 
    {
        var delayTime = new WaitForSeconds(delay);

        while (_isSpawn)
        {
            Instantiate(_enemy, transform);

            yield return delayTime;
        }
    }
}
