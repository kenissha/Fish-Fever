using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGame : MonoBehaviour
{

    public GameObject upgradeButton;
    public GameObject Sell;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (gameObject.name == "Upgrade")
            {
                upgradeButton.SetActive(true);
            }
                else if (gameObject.name == "Sell")
            {
                Sell.SetActive(true);

            }
                



        }


        


    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (gameObject.name =="Upgrade")
            {
                upgradeButton.SetActive(false);
            }
            else if (gameObject.name=="Sell")

            {
                Sell.SetActive(false);

            }




        }





    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
