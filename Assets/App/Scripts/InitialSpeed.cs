using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSpeed : MonoBehaviour
{
    [SerializeField]
    private Vector3 _speed;
    void Start()
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = _speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
