using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Controller : MonoBehaviour
{
    private Vector2 targetpos;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * 4.5f + targetpos.x, targetpos.y);
    }
}
