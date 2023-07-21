using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUpActivate()
    {
        this.transform.gameObject.SetActive(true);
    }

    public void PopUpDeactivate()
    {
        this.transform.gameObject.SetActive(false);
    }
}
