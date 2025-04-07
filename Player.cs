using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //how to define a variable
    //1. access modifier: public or private
    //2. data type: int, float, bool, string
    //3. variable name: camelCase
    //4. value: optional

    private GameManager gameManager;

    // Player Movement
    private float playerSpeed;
    private float horizontalInput;
    private float verticalInput;

    // Player Livesp
    public int lives;

    // Weapons
    public GameObject bulletPrefab;

    // Screen Size
    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimit = 6.5f;

    //This function is called at the start of the game
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerSpeed = 5f;
        lives = 3;
        gameManager.ChangeLivesText(lives); // Tell player lives remaining 
    }

    //This function is called every frame; 60 frames/second
    void Update()
    {
        Movement();
        Shooting();
        gameManager.ChangeLivesText(lives);
    }





    // Player Health
    public void LoseALife()
    {
        lives -= 1;     // -1 life if player hits enemy
        gameManager.ChangeLivesText(lives); // Tell player lives remaining 
        if (lives == 0) // lives = zero then player deleted
        {
            Destroy(this.gameObject);
        }
    }
    public void GainALife()
    {
        lives += 1;
        gameManager.ChangeLivesText(lives);



    }

    public void MaxLife()
    {
        if (lives > 3)
        {
            lives = 3;
        }

        
        gameManager.ChangeLivesText(lives);



    }



    // Player Weponds
    void Shooting()
    {
        //if the player presses the SPACE key, create a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

    // Player Movement
    void Movement()
    {
        //Read the input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move the player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);
        
        //Player leaves the screen horizontally
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }

        //Player leaves the screen vertically
        if (transform.position.y > verticalScreenLimit || transform.position.y <= -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        }
    }

}