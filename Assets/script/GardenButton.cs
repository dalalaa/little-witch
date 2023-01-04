using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class GardenButton : MonoBehaviour
{

    public void Open()
    {
       GameManager.Instance._CurrentState = GameManager.GameStates.InGame;
        SceneManager.LoadScene(3);

    }
}
        



