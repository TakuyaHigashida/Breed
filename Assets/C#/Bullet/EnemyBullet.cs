using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y > 5 || transform.position.y < -5 || transform.position.x > 9 || transform.position.x < -9) 
        {
            Destroy(gameObject);
        }
    }
}
