using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnCoinScript : MonoBehaviour
    {


        public GameObject CoinPrefab;


        // Start is called before the first frame update
        void Start()
        {

            InvokeRepeating("CreateCoin", 2, 2);
        }


        // Update is called once per frame
        void Update()
        {
        }
        void CreateCoin()
        {
            Instantiate(CoinPrefab, new Vector3(Random.Range(-9f, 9f), -.11f, 0), Quaternion.Euler(-90, 0, 0));
        }

    }
}