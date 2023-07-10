using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera cam;
    [SerializeField]private float cameraWidth = 0;
    [SerializeField]private float cameraHeight = 0;

    private IEnumerator sphereShooter(Vector3 positionHit) {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = positionHit;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }

   


    void Start()
    {
        cam = GetComponent<Camera>();
        cameraWidth = cam.pixelWidth;
        cameraHeight = cam.pixelHeight;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 point = new Vector3(cameraWidth/2, cameraHeight/2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) {
                GameObject hitObject = hit.transform.gameObject;
                AITarget target = hitObject.GetComponent<AITarget>();
                FlyEnemy Target = hitObject.GetComponent<FlyEnemy>();

                if(target != null) {
                    target.Die();
                }
                else {
                    if(Target != null) {
                        Target.Die();
                    }
                    
                    else {
                        StartCoroutine(sphereShooter(hit.point));
                    }
                }
            }


        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(cameraWidth/2 - 4 ,cameraHeight/2 - 4, 12f, 12f), "*");
    }
}
