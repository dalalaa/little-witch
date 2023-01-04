using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{

    public void Open()
    {
        GameManager.Instance.FinishPressed = true;
        gameObject.SetActive(false);
        GameManager.Instance._CurrentState = GameManager.GameStates.FinishGame;
        SceneManager.LoadScene(4);

    }
} 
    