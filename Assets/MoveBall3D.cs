using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall3D : MonoBehaviour
{


    float moveSpeed = 5;
    float moveDistance = 5;

    Vector3 _startPosition;


    private void Start()
    {
        _startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, _startPosition) >= moveDistance)
        {
            moveSpeed = -moveSpeed;
            _startPosition = transform.position;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(moveSpeed, 0, 0);
    }
}
