using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public Vector2 startPosition;
    public SpriteRenderer barRenderer;
    public BoxCollider2D boxCollider;
   //  public HingeJoint2D startJoint;
   // public HingeJoint2D endJoint;

  
    public SpringJoint2D startJoint;
    public SpringJoint2D endJoint;



    // Start is called before the first frame update
    public void UpdateCreatingBar(Vector2 ToPosition) {
        transform.position = (ToPosition + startPosition) / 2;
        Vector2 dir = ToPosition - startPosition;
        float angle = Vector2.SignedAngle(Vector2.right, dir);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        float lenght = dir.magnitude;
        barRenderer.size = new Vector2(lenght, barRenderer.size.y);
        boxCollider.size = barRenderer.size;
        startJoint.distance = lenght;
        endJoint.distance = lenght;
    }
}
