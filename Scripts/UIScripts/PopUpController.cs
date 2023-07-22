using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{

    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Messenger<float>.Broadcast(GameEvents.SPEED_CHANGED, slider.value);
        Messenger<float>.Broadcast(GameEvents.SPAWNED_SPEED, slider.value);
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
