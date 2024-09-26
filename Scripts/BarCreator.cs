using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class BarCreator : MonoBehaviour, IPointerDownHandler
{
    bool BarCreationStarted = false;

    public Bar CurrentBar;
    public GameObject BarToInstantiate;
    public Transform barParent;
    public points CurrentStartPoint;
    public points CurrentEndPoint;
    public GameObject PointToInstantiate;
    public Transform PointParent;


    public void OnPointerDown(PointerEventData eventData)
    {

        if (BarCreationStarted == false)
        {
            BarCreationStarted = true;
            StarterBarCreation(Vector2Int.RoundToInt((Camera.main.ScreenToWorldPoint(eventData.position))));

        }
        else
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                FinishBarCreation();
            }
            else if (eventData.button == PointerEventData.InputButton.Right)
            {
                BarCreationStarted = false;
                DeleteCurrentBar();
            }
        }
        
    }

    void StarterBarCreation(Vector2 StartPosition)
    {

        CurrentBar = Instantiate(BarToInstantiate, barParent).GetComponent<Bar>();
        CurrentBar.startPosition = StartPosition;
        

        if (GameManager.allPoints.ContainsKey(StartPosition))
        {
           
            CurrentStartPoint = GameManager.allPoints[StartPosition];

        }
        else
        {
            CurrentStartPoint = Instantiate(PointToInstantiate, StartPosition, Quaternion.identity, PointParent).GetComponent<points>();
            GameManager.AddPoint(StartPosition, CurrentStartPoint);
        }
        
        CurrentEndPoint = Instantiate(PointToInstantiate, StartPosition, Quaternion.identity, PointParent).GetComponent<points>();


    }

    void FinishBarCreation() {

        /*if (GameManager.allPoints.ContainsKey(CurrentEndPoint.transform.position))
        {
            Debug.Log("contains");
            Destroy(CurrentEndPoint.gameObject);
            CurrentEndPoint = GameManager.allPoints[CurrentEndPoint.transform.position];

        }
        else {
            Debug.Log("Current start point : " + CurrentEndPoint.transform.position);

            GameManager.AddPoint(CurrentEndPoint.transform.position, CurrentEndPoint);
        }*/

        bool found = false;
        for (int i = 0; i < GameManager.everyPoints.Count; i++)
        {
            if (GameManager.everyPoints[i] != null)
            {
                if (GameManager.everyPoints[i].transform.position == CurrentEndPoint.transform.position)
                {
                    Debug.Log("Same position");
                    Destroy(CurrentEndPoint.gameObject);
                    CurrentEndPoint = GameManager.everyPoints[i];//GameManager.allPoints[CurrentEndPoint.transform.position];
                    found = true;
                    break;
                }
            }
        }

        if (!found)
        {

            GameManager.AddPoint(CurrentEndPoint.transform.position, CurrentEndPoint);
        }

        CurrentStartPoint.ConnectedBars.Add(CurrentBar);
        CurrentEndPoint.ConnectedBars.Add(CurrentBar);

        CurrentBar.startJoint.connectedBody = CurrentStartPoint.rbd;
        CurrentBar.startJoint.anchor = CurrentBar.transform.InverseTransformPoint(CurrentBar.startPosition);


        CurrentBar.endJoint.connectedBody = CurrentEndPoint.rbd;
        CurrentBar.endJoint.anchor = CurrentBar.transform.InverseTransformPoint(CurrentEndPoint.transform.position);



        StarterBarCreation(CurrentEndPoint.transform.position);


    }

    void DeleteCurrentBar()
    {

        Destroy(CurrentBar.gameObject);
        if (CurrentStartPoint.ConnectedBars.Count == 0 && CurrentStartPoint.Runtime == true) Destroy(CurrentStartPoint.gameObject);
        if (CurrentEndPoint.ConnectedBars.Count == 0 && CurrentEndPoint.Runtime == true) Destroy(CurrentEndPoint.gameObject);
    }

    private void Update()
    {
        if(BarCreationStarted == true)
        {
            if (CurrentEndPoint != null)
            {
                CurrentEndPoint.transform.position = (Vector2)Vector2Int.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                CurrentEndPoint.PointID = CurrentEndPoint.transform.position;
                CurrentBar.UpdateCreatingBar(CurrentEndPoint.transform.position);
            }
        }
    }


}
