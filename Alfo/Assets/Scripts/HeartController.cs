using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    void FixedUpdate()
    {
        StartTime += 0.1f * Time.deltaTime;

        if (StartTime >= EndTime)
        {
            Destroy(gameObject);
        }
    }
}
