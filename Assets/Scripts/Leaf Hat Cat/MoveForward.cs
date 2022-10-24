using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rb2D;
    [SerializeField] private Vector2 speedVector = new Vector2(1f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 currentPosition = transform.position;
        speedVector = new Vector2(speedVector.x, Rb2D.velocity.y);
        Rb2D.MovePosition(currentPosition + speedVector);
    }
}
