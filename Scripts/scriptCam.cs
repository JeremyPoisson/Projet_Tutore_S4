using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCam : MonoBehaviour {

    public Transform player;

    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y +2.40f, transform.position.z);
    }

}
