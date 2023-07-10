using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    
    [SerializeField] private float valueOfDisplacementZ = 0.1f;
    [SerializeField] private bool isAlive = true;

    private bool IsInInnerCircleFloor(Vector3 point, float planeOfCircle)
    {
        if(point.y != planeOfCircle) {
            return false;
        }

        var distanceInPlaneOfCircle = Mathf.Sqrt(point.x*point.x + point.z*point.z);

        if(distanceInPlaneOfCircle < 25) {
            return true;
        }
        else {return false;}
    }


    private void AIMovement(float planeOfFlight)
    {
        if(isAlive == true) {
            var pos = this.transform.TransformPoint(new Vector3(0, 1f, 0)*2f);

            if(IsInInnerCircleFloor(pos, planeOfFlight)) {
                this.transform.Translate(new Vector3(0, valueOfDisplacementZ, 0));
                return;
            }
            else {
                var valueOfRotationZ = Random.Range(0, 360);
                this.transform.Rotate(new Vector3(0, 0, valueOfRotationZ));
            }
        }

        else {
            this.transform.Translate(new Vector3(0, 0, 0.05f));
        }
    }


    private IEnumerator die()
    {
        isAlive = false;
        yield return new WaitForSeconds(2f);

        Object.Destroy(this.transform.gameObject);
    }


    public void Die()
    {
        StartCoroutine(die());
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        AIMovement(14f);
    }
}
