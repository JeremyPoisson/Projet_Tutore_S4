using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnMouseEnter() {
        Debug.Log("Mouse enter");
        LineDrawer.allowBuild = false;
        transform.localScale = new Vector2(2.1f, 2.1f);

    }
    private void OnMouseExit()
    {
        if (!trigger)
        {
            LineDrawer.allowBuild = true;
        }
        transform.localScale = new Vector2(2, 2);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) {
            LineDrawer.allowBuild = !LineDrawer.allowBuild;

        }
        this.GetComponent<Renderer>().enabled = true;
        if (!LineDrawer.allowBuild) {
            if (Input.GetMouseButtonDown(0)) {
                trigger = !trigger;
            }
        }
        
    }
}
