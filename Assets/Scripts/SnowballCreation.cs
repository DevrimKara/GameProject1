using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballCreation : MonoBehaviour
{
    public bool CloseToSnowPile;
    public float totalAmountSnowPile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SnowpileCountdown()
    {
        totalAmountSnowPile = totalAmountSnowPile - 1f * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider player)
    {
       
            if (player.gameObject.tag == "Player")
            {
            SnowpileCountdown();
                CloseToSnowPile = true;
            }
        
    }
    private void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            CloseToSnowPile = false;
        }
    }
}
