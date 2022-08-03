using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerManager : MonoBehaviour
{
    
    public delegate void OnCollectArea();
    public static event OnCollectArea OnBalikCollect;
    public Transform BalikPoz;
    bool isCollecting;
    int BalikSayisi = 0;
    public Text BalikSayisiGoster;

    void Start()
    {
       // StartCoroutine(CollectEnum());
    }
   /* IEnumerator CollectEnum()
    {
        while (true)
        {
            if (isCollecting == true)
            {
                OnBalikCollect();
            }
            yield return new WaitForSeconds(0.5f);
        }
 
    }
*/
    private void OnTriggerEnter(Collider other)
    {
       
            if (other.gameObject.CompareTag("CollectArea"))
        {
            isCollecting = true;
            float rndmx = Random.Range(-1.3f, 1.8f);
            float rndmz = Random.Range(-1.3f, 1.8f);
            other.gameObject.transform.position = new Vector3(BalikPoz.position.x+ rndmx, BalikPoz.position.y, BalikPoz.position.z+ rndmz);
            other.gameObject.transform.parent = gameObject.transform;

            BalikSayisi++;

            BalikSayisiGoster.text = " " + BalikSayisi;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CollectArea"))
        {
            isCollecting = false;

        }
    }
}
