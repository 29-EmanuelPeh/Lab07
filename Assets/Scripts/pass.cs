using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("obstacle"))
        {
            GameManager.thisManager.UpdateScore(1);
        }
    }
}
