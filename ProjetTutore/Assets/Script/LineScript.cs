using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    private float x1, y1,x2,y2;
    // Start is called before the first frame update
    void Start()
    {
        x1 = GetComponent<LineRenderer>().GetPosition(0).x;
        y1 = GetComponent<LineRenderer>().GetPosition(0).y;
        x2 = GetComponent<LineRenderer>().GetPosition(1).x;
        x2 = GetComponent<LineRenderer>().GetPosition(1).y;
        GetComponent<LineRenderer>().useWorldSpace = true;
        GetComponent<LineRenderer>().alignment = LineAlignment.TransformZ;
        GetComponent<LineRenderer>().sortingOrder = 1;
         
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
