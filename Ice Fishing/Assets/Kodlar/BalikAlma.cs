using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalikAlma : MonoBehaviour
{
    public List<GameObject> baliklist = new List<GameObject>();
    public GameObject balikprefab;
    public Transform collectbalik;

    int baliklimit = 10;


    //private void OnEnable()
    //{
    //    TrigerManager.OnBalikCollect += Getbalik;
    //}

    //private void OnDisable()  
    //{
    //    TrigerManager.OnBalikCollect -= Getbalik;
    //}

    //void Getbalik()
    //{
    //   int xrandom = Random.Range(-100, 50);
    //    int zrandom = Random.Range(-100, 50);
        
    //    if (baliklist.Count <= baliklimit)
    //    {
    //        GameObject temp = Instantiate(balikprefab, collectbalik);
    //        temp.transform.position = new Vector3(xrandom, collectbalik.position.y, zrandom);
    //        baliklist.Add(temp);
    //    }
    //}



    
}
