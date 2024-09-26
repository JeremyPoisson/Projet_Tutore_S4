using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.Rendering;

public class points : MonoBehaviour
{
    public bool Runtime = true;
    public Vector2 PointID;
    public List<Bar> ConnectedBars;
    public Rigidbody2D rbd;
    public static bool First= true;

    public void ReverseGravity() {
        rbd.gravityScale = -rbd.gravityScale;
        for (int i = 0; i < ConnectedBars.Count; i++) {
            ConnectedBars[i].GetComponent<Rigidbody2D>().gravityScale = -ConnectedBars[i].GetComponent<Rigidbody2D>().gravityScale;
        }
    }
    private void Start()
    {
        PointID = transform.position;
        if (First)
        {
            Debug.Log("First point");
            PointID = transform.position;
            First = false;
        }
        if (Runtime == false)
        {
            Debug.Log("run time");
            rbd.bodyType = RigidbodyType2D.Static;
            PointID = transform.position;
            if (GameManager.allPoints.ContainsKey(PointID) == false) GameManager.allPoints.Add(PointID, this);

        }

    }
    private void Update()
    {
        if(Runtime == false)
        {
            if (transform.hasChanged == true) {
                transform.hasChanged = false;
                transform.position = Vector3Int.RoundToInt(transform.position);
            }
            
        }
    }


}
