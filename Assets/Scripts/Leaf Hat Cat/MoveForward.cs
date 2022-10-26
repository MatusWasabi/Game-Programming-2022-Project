using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rb2D;
    [SerializeField] private int bulletSpeed;
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb2D.velocity = transform.right * bulletSpeed;
    }
}
