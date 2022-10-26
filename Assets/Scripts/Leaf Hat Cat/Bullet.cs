using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out AttackBox attackBox))
        {
            Destroy(gameObject);
        }

        if(collision.TryGetComponent(out DeflectBox deflectBox))
        {
            gameObject.transform.localEulerAngles = Vector3.back;
        }
    }
}
