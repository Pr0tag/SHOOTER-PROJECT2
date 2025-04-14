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
    public TextMeshProUGUI powerupText;
    public GameObject powerupPrefab;

    public float horizontalScreenSize;
    public float verticalScreenSize;
    // public Player Player;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn  Conitions For Enemies (name, sec till 1st spawn, sec between spawn)
        horizontalScreenSize = 10f;
        verticalScreenSize = 6.5f;
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2, 3);
        InvokeRepeating("CreateEnemyThree", 3, 4);
        StartCoroutine(SpawnPowerups());
     
        powerupText.text = "No Powerups";

    }

    // Update is called once per frame
    void Update()
    {

    }
  

   public IEnumerator SpawnPowerups()
    {
        float spawnTime = Random.Range(1, 5);
        yield return new WaitForSeconds(spawnTime);
        CreatePowerup();
        StartCoroutine(SpawnPowerups());
    }
        
    
    public void ManagePowerUpText(int powerupType)
    {
        switch (powerupType) {
            //picked up shield
            case 1: powerupText.text = "Shield!";
                    break;
            case 2: powerupText.text = "Speed Boost!";
            
                    break;
                //default text setting when no powerups are held
                    default: powerupText.text = " No Powerups ";
             
                    break; }
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
    void CreatePowerup()
    {
        Instantiate(powerupPrefab, new Vector3(Random.Range(-horizontalScreenSize * 0.9f, horizontalScreenSize * 0.9f), Random.Range(-verticalScreenSize * 0.9f, verticalScreenSize * 0.9f), 0), Quaternion.identity);
    }
    // Change lives UI
    public void ChangeLivesText (int currentlives)
    {
        LivesText.text = "Lives: " + currentlives;
    }


}
