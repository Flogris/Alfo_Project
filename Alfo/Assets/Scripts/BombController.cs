using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombController : MonoBehaviour
{
    public float StartTime;
    public float EndTime;
    public string collisionTag;

    void FixedUpdate()
    {
        StartTime += 0.1f * Time.deltaTime;

        if (StartTime >= EndTime)
        {
            Destroy (gameObject);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            Destroy(gameObject);
        }
    }
}
