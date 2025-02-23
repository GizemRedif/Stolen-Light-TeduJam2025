using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingstar: MonoBehaviour
{
    public Transform circle; 
    private float distanceFromCenter; 

    void Update()
    {
        float circleRadius = circle.localScale.x / 2f;
        distanceFromCenter = circleRadius * 0.9f;

        transform.position = circle.position + new Vector3(
            Mathf.Cos(Time.time) * distanceFromCenter, 
            Mathf.Sin(Time.time) * distanceFromCenter,0);
    }
}
