using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHeartScript : MonoBehaviour
{


    public GameObject HeartPrefab;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("CreateHeart", 1, 3);
    }


    // Update is called once per frame
    void Update()
    {
    }
    void CreateHeart()
    {
        Instantiate(HeartPrefab, new Vector3(Random.Range(-8f, 8f), -.10f, 0), Quaternion.Euler(0, 0, 0));
    }

}
