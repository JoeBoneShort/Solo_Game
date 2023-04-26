using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Player")]
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float padding = 0.2f;
    [SerializeField] GameObject lazerPrefab;
    [SerializeField] AudioClip deathSFX;
    [SerializeField][Range(0, 1)] float deathSFXVolume = 0.75f;
    [SerializeField] Sprite[] mouseSprites;
    bool isMouseDead = false;

    [Header("Laser")]
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileCoolDown = 0.1f;
    [SerializeField] int health = 100;

    [SerializeField] AudioClip shootSFX;
    [SerializeField][Range(0, 1)] float shootSFXVolume = 0.4f;

    Coroutine firingCoroutine;



    float xMin;
    float xMax;
    float yMin;
    float yMax;


    // Start is called before the first frame update
    void Start()
    {
        SetUpMoveBoundaries();
    }







    private void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;

        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
 
    }



    private void Move()
    {
        if (isMouseDead == false)
        {
            float changeX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float newXPosition = Mathf.Clamp(transform.position.x + changeX, xMin, xMax);


            float changeY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float newYPosition = Mathf.Clamp(transform.position.y + changeY, yMin, yMax);
            transform.position = new Vector2(newXPosition, newYPosition);
        }
        else
        {


        }
    }

  



}
