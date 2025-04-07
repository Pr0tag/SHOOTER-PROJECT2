using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Enemy prefabs
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject enemyThreePrefab;

    // Lives UI
    public TextMeshProUGUI LivesText;
    // public Player Player;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn  Conitions For Enemies (name, sec till 1st spawn, sec between spawn)
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2, 3);
        InvokeRepeating("CreateEnemyThree", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
                      
    }


    // Spawn Enemies in set position at random 
    void CreateEnemyOne() 
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    void CreateEnemyThree()
    {
        Instantiate(enemyThreePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    // Change lives UI
    public void ChangeLivesText (int currentlives)
    {
        LivesText.text = "Lives: " + currentlives;
    }


}
