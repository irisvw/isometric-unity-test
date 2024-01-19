using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofTrigger : MonoBehaviour
{
    public GameObject roof1;
    public GameObject roof2;
    public GameObject roof3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        roof1.SetActive(false);
        roof2.SetActive(false);
        roof3.SetActive(false);
    }

    void OnTriggerExit()
    {
        roof1.SetActive(true);
        roof2.SetActive(true);
        roof3.SetActive(true);
    }
}
