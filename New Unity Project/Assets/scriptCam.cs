using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //GameObject.Find("Player").transform.position;

        bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        if (isShiftKeyDown)
        {

            float xAxisValue = Input.GetAxis("Horizontal");
            float zAxisValue = Input.GetAxis("Vertical");
            if (Camera.current != null)
            {
                Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
            }
        }

    }
}
