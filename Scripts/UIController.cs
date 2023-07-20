using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text timePastSinceStart;

    // Start is called before the first frame update
    void Start()
    {
        timePastSinceStart.text = $"Seconds: {Time.realtimeSinceStartup.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        timePastSinceStart.text = $"Seconds: {Time.realtimeSinceStartup.ToString()}";
    }
}
