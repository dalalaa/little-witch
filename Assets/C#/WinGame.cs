using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {


    public Button GameAgainButton;
    public Button GameOverButton;

   

    void GameAgainButtonClickListener()
    {
        SceneManager.LoadScene(1);
    }


    void GameOverClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
