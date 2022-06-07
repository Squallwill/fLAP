using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5f;
    [SerializeField]
    private float flapforce = 20f;
    bool isDead;
    public GameObject ReplayButton;
    public int score;
    public static int bScore;
    public Text scoretxt;
    public Text bestScore;
    public GameObject notif;
    private void Start()
    {
        Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed;
        score = 0;
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        { 
            //reset velocity
            Debug.Log("Fly Fu****g Bird !!!.");
            rb2d.AddForce(Vector2.up * flapforce);
            rb2d.velocity = Vector2.right * speed;
            //add up force
            
        }
        
        if (score > bScore)
        {
            bScore = score;
            bestScore.text = bScore.ToString();
            notif.SetActive(true);
        }
        bestScore.text = bScore.ToString();
        
    }
    public void save()
    {
       
        PlayerPrefs.SetInt("HighScore", bScore);
    }
    public void load ()
    {
        bScore = PlayerPrefs.GetInt("HighScore");
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        GetComponent<Animator>().SetBool("isDead",true);
        ReplayButton.SetActive(true);
        save();
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void UnFreeze()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter2D(Collider2D sc)
    {
        if (sc.gameObject.tag == "Score")
        {
            score++;
            
            scoretxt.text = score.ToString();
        }
    }
}
