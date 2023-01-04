using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameStates  {Invalid,FrontEnd,Intro,InGame,FinishGame};
    public GameStates _CurrentState=GameStates.Intro;
    GameStates _PrevState = GameStates.Invalid;
    public GameObject MainCanvas;

    public GameObject TomatoButton;
    public GameObject CabageButton;
    public GameObject CarrotButton;

public GameObject _FinishButton;
public bool TomatoPressed=false;     
public bool CabagePressed=false;     
public bool CarrotPressed=false;     
    // Start is called before the first frame update
    static public GameManager Instance=null;
    void OnEnable()
    {
        Debug.Log("called!!");
        if (Instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        Instance= this;
        DontDestroyOnLoad(gameObject);
    }
    public void EnableFood(int ID)
    {
switch (ID)
{
    case 0:
    TomatoButton.SetActive(true);
    break;
    case 1:
    CabageButton.SetActive(true);
    break;
    case 2:
    CarrotButton.SetActive(true);
    break;
    default:
    break;
}
    }
    void Start()
    {
      // _CurrentState=GameStates.Intro; 
    }
    public bool FinishPressed = false;
    // Update is called once per frame
    void Update()
    {
        //other game logic...
        Debug.Log("tomatopressed? " + TomatoPressed);
        Debug.Log("CabagePressed? " + CabagePressed);
        Debug.Log("CarrotPressed? " + CarrotPressed);
if (TomatoPressed && CabagePressed && CarrotPressed && !FinishPressed)
{
    
    //make finish buttoin visible
    _FinishButton.SetActive(true);
}

        if (_CurrentState!=_PrevState)
        {
            switch (_CurrentState)
            {
                case GameStates.Intro:
                {
                    MainCanvas.SetActive(false);
                }
                break;
                case GameStates.InGame:
                {
                    MainCanvas.SetActive(true);
                }
                break;
                case GameStates.FinishGame:
                {
                 MainCanvas.SetActive(false);
                }
                break;
                default:
                break;
            }
        }
        _CurrentState = _PrevState;
    }
}
