using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script moves the attached object along the Y-axis with the defined speed
/// </summary>
public class DirectMoving : MonoBehaviour {

    [Tooltip("Moving speed on Y axis in local space")]
    public float speed;

    //moving the object with the defined speed
    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 5 || transform.position.y < -5 || transform.position.x > 9 || transform.position.x < -9)
        {
            Destroy(gameObject);
        }

    }
}
