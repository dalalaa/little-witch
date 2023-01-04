using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speak : MonoBehaviour{






    public GameObject mytext;



    void OnTriggerEnter(Collider Other)
    {

    mytext.GetComponent<Text>().text = "OW!";


    }
}



