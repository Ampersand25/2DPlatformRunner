using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public GameObject Sound;
    public GameObject NoSound;
    public Rigidbody2D rb;
    public Transform groundCheck;
    public Transform startPosition;
    public GameObject Music;
    public LayerMask whatIsGround;
    public Animator animator;
    private GameMaster gm;
    public float groundCheckRadius;
    public float speed = 4f;
    public float jump = 7f;
    public float fall = -8f;
    public float endDistance;
    public static int ad = 0;
    public static int deathCount = 0;
    public static int deathCount1 = 0;
    public static int deathCount2 = 0;
    public static int deathCount3 = 0;
    public static int deathCount4 = 0;
    public static int deathCount5 = 0;
    public static int deathCount6 = 0;
    public static int deathCount7 = 0;
    public static int sceneIndex;
    private bool onGround;
    private bool jumping = false;
    private bool doubleJump = false;

    // Use this for initialization
    void Start () {
        if (AudioListener.pause == false)
            Sound.SetActive(true);
        else NoSound.SetActive(true);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        if (sceneIndex == 1)
            transform.position = gm.lastCheckPointPos;
        else if (sceneIndex == 2)
            transform.position = gm.lastCheckPointPos1;
        else if (sceneIndex == 3)
            transform.position = gm.lastCheckPointPos2;
        else if (sceneIndex == 4)
            transform.position = gm.lastCheckPointPos3;
        else if (sceneIndex == 5)
            transform.position = gm.lastCheckPointPos4;
        else if (sceneIndex == 6)
            transform.position = gm.lastCheckPointPos5;
        else if (sceneIndex == 7)
            transform.position = gm.lastCheckPointPos6;
        else transform.position = gm.lastCheckPointPos7;
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (onGround)
        {
            animator.SetBool("OnGround", true);
            doubleJump = true;
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(Input.GetMouseButtonUp(0) && onGround && !PauseMenu.GameIsPaused)
        {
            jumping = true;
            animator.SetBool("Jump", true);
            animator.SetBool("OnGround", false);
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        if(Input.GetMouseButtonUp(0) && !onGround && doubleJump && !PauseMenu.GameIsPaused)
        {
            jumping = true;
            animator.SetBool("Jump", true);
            animator.SetBool("OnGround", false);
            rb.velocity = new Vector2(rb.velocity.x, jump);
            doubleJump = false;
        }
        if(!onGround)
        {
            animator.SetBool("OnGround", false);
            if(jumping)
            {
                animator.SetBool("Jump", true);
                jumping = false;
            }
            else
            {
                animator.SetBool("Jump", false);
            }
        }
        if(rb.position.x >= endDistance)
        {
            ad = 0;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                gm.lastCheckPointPos.x = -4.366f;
                gm.lastCheckPointPos.y = 4.28f;
                deathCount = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                gm.lastCheckPointPos1.x = -4.366f;
                gm.lastCheckPointPos1.y = 4.28f;
                deathCount1 = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                gm.lastCheckPointPos2.x = -4.366f;
                gm.lastCheckPointPos2.y = 4.28f;
                deathCount2 = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                gm.lastCheckPointPos3.x = -4.366f;
                gm.lastCheckPointPos3.y = 4.28f;
                deathCount3 = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                gm.lastCheckPointPos4.x = -4.366f;
                gm.lastCheckPointPos4.y = 4.28f;
                deathCount4 = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                gm.lastCheckPointPos5.x = -4.366f;
                gm.lastCheckPointPos5.y = 4.28f;
                deathCount5 = 0;
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                gm.lastCheckPointPos6.x = -4.366f;
                gm.lastCheckPointPos6.y = 4.28f;
                deathCount6 = 0;
            }
            else
            {
                gm.lastCheckPointPos7.x = -4.366f;
                gm.lastCheckPointPos7.y = 4.28f;
                deathCount7 = 0;
            }
            Music.SetActive(false);
            FindObjectOfType<GameManager>().CompleteLevel();
        }
        if(rb.position.y <= fall)
        {
            if (SettingsMenu.adsActivated == true)
                ++ad;
            if (SceneManager.GetActiveScene().buildIndex == 1)
                ++deathCount;
            else if (SceneManager.GetActiveScene().buildIndex == 2)
                ++deathCount1;
            else if (SceneManager.GetActiveScene().buildIndex == 3)
                ++deathCount2;
            else if (SceneManager.GetActiveScene().buildIndex == 4)
                ++deathCount3;
            else if (SceneManager.GetActiveScene().buildIndex == 5)
                ++deathCount4;
            else if (SceneManager.GetActiveScene().buildIndex == 6)
                ++deathCount5;
            else if (SceneManager.GetActiveScene().buildIndex == 7)
                ++deathCount6;
            else ++deathCount7;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
