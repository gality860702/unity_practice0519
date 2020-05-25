using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRACTICE : MonoBehaviour
{
    
    public SpriteRenderer tran1;

    public Rigidbody ball;
    


    void Start()
    {
        Time.timeScale = 2;
        
        tran1.flipX =true;

        print(Mathf.Floor(123456));

        ball. AddForce(0,500,800);
    }

   
}
