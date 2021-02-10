using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Dictionary<Vector2, points> allPoints = new Dictionary<Vector2,points>();
    public static List<points> everyPoints = new List<points>();


    public static void AddPoint(Vector2 vec, points p) {
        everyPoints.Add(p);
        allPoints.Add(vec, p);
    
    }
    private void Awake()
    {
        allPoints.Clear();
        Time.timeScale = 0;
    }
    [ContextMenu("Game started !")]
    public void Play() {
        Time.timeScale = 1;
    
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Play();
        }
        if (Input.GetKeyDown(KeyCode.B)) {
            ReverseGravity();
        }

    }
    private void ReverseGravity()
    {
        for (int i = 0; i < everyPoints.Count; i++) {
            everyPoints[i].GetComponent<points>().ReverseGravity();
        }
    }
}
