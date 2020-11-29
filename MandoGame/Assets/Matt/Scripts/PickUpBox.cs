using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{
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
        //Gives the item to the player
        /*
        GameObject thePlayer = GameObject.Find("Player");
        PlayerScript playerScript = thePlayer.GetComponent<Player>();
        playerScript.Item = true;
        */
    }
}
