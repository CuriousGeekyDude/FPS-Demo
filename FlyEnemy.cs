using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    
    [SerializeField] private float valueOfDisplacementZ = 0.1f;

    private bool IsInInnerCircleFloor(Vector3 point, float planeOfCircle)
    {
        if(point.z != planeOfCircle) {
            return false;
        }

        var distanceInPlaneOfCircle = Mathf.Sqrt(point.x*point.x + point.y*point.y);

        if(distanceInPlaneOfCircle < 25) {
            return true;
        }
        else {return false;}
    }


/*    private void AIMovement(float planeOfFlight)
    {
        var pos = this.transform.TransformPoint(Vector3.forward*2f);

        if(IsInInnerCircleFloor(pos, planeOfFlight)) {
            this.transform.Translate(new Vector3(0, 0, valueOfDisplacementZ));
            return;
        }
        else {
            var valueOfRotationY = Random.Range(0, 360);
            this.transform.Rotate(new Vector3(0, valueOfRotationY, 0));
        }
    }
*/
    void Start()
    {
        
    }

    
    void Update()
    {
        AIMovement(14f);
    }
}
