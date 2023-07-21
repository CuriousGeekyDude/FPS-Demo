using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour
{
    [SerializeField] private PopUpController popUpWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closePopUp()
    {
        popUpWindow.PopUpDeactivate();
    }
}
