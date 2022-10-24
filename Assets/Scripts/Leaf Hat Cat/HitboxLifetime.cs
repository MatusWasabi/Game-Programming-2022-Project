using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxLifetime : MonoBehaviour
{
    public static float lifeTime = 0.1f;
    [SerializeField] private float counter;
    private void OnEnable()
    {
        counter = lifeTime;
    }
    private void Update()
    {
        counter -= Time.deltaTime;
        if(counter <= 0) { gameObject.SetActive(false); }
    }
}
