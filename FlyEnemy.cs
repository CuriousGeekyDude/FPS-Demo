using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    
    private bool IsInInnerCircleFloor(Vector3 point,float planeOfCircle)
    {
        if(point.y != planeOfCircle) {
            return false;
        }

        var distanceInPlaneOfCircle = Mathf.Sqrt(point.x*point.x + point.y*point.y);

        if(distanceInPlaneOfCircle < 25) {
            return true;
        }
        else {return false;}
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
