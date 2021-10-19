using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody rb;
    public float velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
            thisAnimation.Play();
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("death") || other.gameObject.tag.Equals("obstacle"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
