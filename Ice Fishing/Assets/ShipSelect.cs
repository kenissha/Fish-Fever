using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSelect : MonoBehaviour
{
    public GameObject BaslangicGemisi;
    public GameObject AktifGemi;

    public Kamera kamera;

    public void Upgrade()
    {

        BaslangicGemisi.SetActive(true);
        AktifGemi.SetActive(false);

        kamera.target = BaslangicGemisi.transform;

        

    }

    
  




}
