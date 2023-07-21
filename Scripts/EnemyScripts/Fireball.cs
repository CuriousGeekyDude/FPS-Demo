using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float valueOfDisplacement = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider hitObject)
    {
        PlayerChar scriptOfPlayer = hitObject.GetComponent<PlayerChar>();

        if(scriptOfPlayer != null) {
            Debug.Log("Player is hit!");
        }
        GameObject.Destroy(this.transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, valueOfDisplacement);
    }
}
