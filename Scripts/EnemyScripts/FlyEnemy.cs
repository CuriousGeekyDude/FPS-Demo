using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    
    [SerializeField] private float valueOfDisplacementZ = 0.1f;
    [SerializeField] private GameObject fireballPrefab = null;
    private GameObject fireball;
    
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

            Ray ray = new Ray(this.transform.position, this.transform.forward);
            RaycastHit hit;

            if(Physics.SphereCast(ray, 1f ,out hit)) {
                    
                if(hit.transform.GetComponent<PlayerChar>() != null) {
                    if(fireball == null) {
                        Vector3 fireballPosition = this.transform.TransformPoint(Vector3.forward*1.5f);
                        fireball = Instantiate(fireballPrefab) as GameObject;
                        fireball.transform.position = fireballPosition;
                        fireball.transform.rotation = this.transform.rotation;
                    }
                }
            }

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
            this.transform.Translate(new Vector3(0, 0, 0.04f));
        }
    }


    private IEnumerator die()
    {
        isAlive = false;
        yield return new WaitForSeconds(2f);
        Object.Destroy(this.transform.gameObject);
        Messenger.Broadcast(GameEvents.ENEMY_HIT);
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
