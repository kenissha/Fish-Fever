using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalukTutma : MonoBehaviour
{
    public List<GameObject> baliklist = new List<GameObject>();
    public GameObject[] balikPrefab;
    private Transform exitBalik;
    bool isWorking;
   


    void Start()
    {
        StartCoroutine(PrintFish());
    }

    public void RemoveLast()
    {
        if (baliklist.Count > 0)
        {
            Destroy(baliklist[baliklist.Count - 1]);
            baliklist.RemoveAt(baliklist.Count - 1);
        }
    }
    IEnumerator PrintFish()
    {
        while (true)
        {
            float balikCount = baliklist.Count;
           

            if (isWorking==true)
            {

                foreach (var afish in balikPrefab) 
                { 
                    int xrandom = Random.Range(-250, 340);
                    int zrandom = Random.Range(-450, 290);
                    //  exitBalik.position = new Vector3(xrandom, exitBalik.position.y, zrandom);

                    GameObject temp = Instantiate(afish);
                    temp.transform.position = new Vector3(xrandom, transform.position.y, zrandom);
                    baliklist.Add(temp);
                    if (baliklist.Count >= 250)
                    {
                        isWorking = false;
                    }

                 }

            }
            else if (baliklist.Count<250)

            {
                isWorking = true;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
