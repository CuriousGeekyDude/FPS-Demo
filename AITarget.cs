using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITarget : MonoBehaviour
{
    
    [SerializeField] private float valueOfDisplacementZ = 0.1f;
    [SerializeField] private GameObject fireballPrefab = null;
    private GameObject fireball;
    [SerializeField] private bool isAlive = true;

    private IEnumerator die()
    {
        isAlive = false;
        this.transform.Rotate(new Vector3(80, 0, 0));
        yield return new WaitForSeconds(1);
        Destroy(this.transform.gameObject);
    }

    public void Die()
    {
        StartCoroutine(die());
    }


    private void AIMovement()
    {
            if(isAlive == true) {

                this.transform.Translate(0, 0, valueOfDisplacementZ);
                Ray ray = new Ray(this.transform.position, this.transform.forward);
                RaycastHit hit;

                if(Physics.SphereCast(ray, 5f ,out hit)) {
                    
                    if(hit.transform.GetComponent<PlayerChar>() != null) {
                        if(fireball == null) {
                            Vector3 fireballPosition = this.transform.TransformPoint(Vector3.forward*1.5f);
                            fireball = Instantiate(fireballPrefab) as GameObject;
                            fireball.transform.position = fireballPosition;
                            fireball.transform.rotation = this.transform.rotation;
                        }
                    }
                
                    else {                    
                        if(hit.distance < 5f) {
                            float rotationAroundY = Random.Range(0, 360);
                            this.transform.Rotate(new Vector3(0, rotationAroundY, 0));
                        }
                    }
                }

            }   
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        AIMovement();
        
    }
}
