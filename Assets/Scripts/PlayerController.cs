using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    private bool isWin = false;
    private Rigidbody rb;
    private int count;

    void Start ()
    {
        isWin = false;
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate ()
    {
        if(transform.position.y<=-3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(isWin==false)
        {
            float moveHorizontal = Input.GetAxis ("Horizontal");
            float moveVertical = Input.GetAxis ("Vertical");

            Vector3 movement = new Vector3 (-1 * moveVertical, 0.0f, moveHorizontal);

            rb.AddForce (movement * speed);
        }
       
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive (false);
            count++;
            SetCountText ();
        }
        if(other.gameObject.tag == "Enemy"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 22)
        {
            winText.text = "You Win!";
            isWin = true;
        }

    }
}