using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodPIckup : MonoBehaviour
{
    //public GameObject ImageToEnable;
    public int IDToEnable;
    public AudioSource _Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.EnableFood(IDToEnable);
        _Sound.Play();
        //ImageToEnable.SetActive(true);
        Destroy(gameObject);
     //Debug.Log("Collision");
    }
}
