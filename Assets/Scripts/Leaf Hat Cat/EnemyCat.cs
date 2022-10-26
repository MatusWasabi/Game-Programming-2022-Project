using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCat : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform gunPoint;

    private void Start()
    {
        InvokeRepeating("Shoot", 2, 2);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);
    }
}
