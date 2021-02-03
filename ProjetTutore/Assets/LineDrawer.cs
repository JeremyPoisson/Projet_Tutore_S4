using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector2 mousePos;
    private Vector2 startMousePos;
    private bool firstpoint = false;
    public static bool allowBuild = true;
    public GameObject dots;
    public GameObject Line;
    public GameObject Creature;
    private GameObject currentdots;
    private GameObject currentLine;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        //this.currentdots = Instantiate(dots, new Vector2(startMousePos.x, startMousePos.y), Quaternion.identity);
        //this.currentdots.GetComponent<dotscript>().setHeld(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (allowBuild)
        {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            /**
             * 
             * 
             * 
             * **/ 
            if (firstpoint)
            {
                this.currentLine.GetComponent<LineRenderer>().SetPosition(0, this.mousePos);

            }

            if (Input.GetMouseButtonDown(0))
            {
                startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
                if (!dotscript.over)
                {
                    Instantiate(dots, new Vector2(startMousePos.x, startMousePos.y), Quaternion.identity,Creature.transform);
                }

                this.currentLine = Instantiate(Line, Input.mousePosition, Quaternion.identity, Creature.transform);
                this.currentLine.GetComponent<LineRenderer>().SetPosition(1, new Vector2(startMousePos.x, startMousePos.y));
                this.currentLine.GetComponent<LineRenderer>().enabled = true;
                
                firstpoint = true;

            }
        }



    }

}

