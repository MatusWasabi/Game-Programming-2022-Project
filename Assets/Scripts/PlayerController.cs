using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private GameObject attackBox;
    [SerializeField] private GameObject deflectBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAttack(InputValue value)
    {
        if (value.isPressed && !deflectBox.activeSelf) 
        {
            attackBox.SetActive(true);
        }
    }

    private void OnDeflect(InputValue value)
    {
        if (value.isPressed && !attackBox.activeSelf)
        {
            deflectBox.SetActive(true);
        }
    }
}
