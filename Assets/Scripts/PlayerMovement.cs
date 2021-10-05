using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class PlayerMovement : NetworkBehaviour
{
    private float _speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + _speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - _speed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + _speed, transform.position.y, transform.position.z);
            }
        }
    }
}
