using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class dotscript : MonoBehaviour
{
   // private LineRenderer lineRend;
    private float Dot2X = 0;
    private float Dot2Y = 0;
    private bool held;
    public static bool over = false;
    public static Vector2 dotspos;
    public static GameObject line;
    private bool point = true;
    private Vector2 mousePos;
    private bool isover;


    public void setHeld(bool held) {
        
        this.held = held;
    }
    public bool getHeld() {
        return this.held;
    }

    public float getDot2X() {
        return this.Dot2X;
    }

    public float getDotY2()
    {
       return this.Dot2Y;
    }
    public void setDot2X(float x)
    {
        this.Dot2X = x;
    }
    public void setDot2Y(float y)
    {
        this.Dot2Y = y;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.held = true;
        GetComponent<LineRenderer>().enabled = false;

    }
    void OnMouseEnter()
    {
        dotspos = transform.localPosition;
        transform.localScale = new Vector2(1.2f, 1.2f);
        over = true;
       /* if (Input.GetMouseButtonDown(0))
        {
            

        }*/
    }
    void OnMouseExit()
    {
        transform.localScale = new Vector2(1, 1);
        over = false;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
