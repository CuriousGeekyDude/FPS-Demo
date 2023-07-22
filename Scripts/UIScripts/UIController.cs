using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text numberOfEnemiesKilled;
    [SerializeField] private PopUpController popUpWindow;
    [SerializeField] private TMP_Text numberOfEnemiesInSceneText;
    private int score;
    private int numberOfEnemiesInScene;


    void OnEnable()
    {
        Messenger.AddListener(GameEvents.ENEMY_HIT, DecrementNumberOfEnemies);
        Messenger.AddListener(GameEvents.ENEMY_HIT, ScoreUpdate);
        Messenger.AddListener(GameEvents.ENEMY_SPAWNED, IncrementNumberOfEnemies);
    }

    void OnDisable()
    {
        Messenger.RemoveListener(GameEvents.ENEMY_HIT, DecrementNumberOfEnemies);
        Messenger.RemoveListener(GameEvents.ENEMY_HIT, ScoreUpdate);
        Messenger.RemoveListener(GameEvents.ENEMY_SPAWNED, IncrementNumberOfEnemies);
    }

    // Start is called before the first frame update
    void Start()
    {
        numberOfEnemiesKilled.text = $"Score: {score.ToString()}";
        numberOfEnemiesInSceneText.text = $"{numberOfEnemiesInScene.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        numberOfEnemiesKilled.text = $"Score: {score.ToString()}";
        numberOfEnemiesInSceneText.text = $"{numberOfEnemiesInScene.ToString()}";
    }
    public void OnOpenSettings() {
        popUpWindow.PopUpActivate();
    }

    public void closePopUp()
    {
        popUpWindow.PopUpDeactivate();
    }

    private void ScoreUpdate()
    {
        ++score;
    }

    private void DecrementNumberOfEnemies()
    {
        --numberOfEnemiesInScene;
    }
    private void IncrementNumberOfEnemies()
    {
        ++numberOfEnemiesInScene;
    }
}
