using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask layerMask;
    public LayerMask layerMask2;
    public Vector3 direction;
    public LineRenderer lineRenderer;
    public float maxDistance = 10f;

    void Start()
    {
        if (lineRenderer == null)
            lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.positionCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, transform.right, 20f, layerMask);
        if (hit2D.collider != null)
        {
            Debug.DrawLine(transform.position, hit2D.point, Color.yellow, 0.1f);
            direction = Vector3.Reflect(transform.right, hit2D.normal);
            RaycastHit2D hit2D2 = Physics2D.Raycast(hit2D.point, direction, 20f, layerMask2);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, hit2D.point);
            lineRenderer.SetPosition(2, hit2D.point);
            if (hit2D2.collider != null)
            {
                Debug.DrawLine(hit2D.point, hit2D2.point, Color.yellow, 0.1f);
                lineRenderer.SetPosition(2, hit2D2.point);
            }
        }



    }
}
