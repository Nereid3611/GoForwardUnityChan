using System.Collections;
using UnityEngine;

public class UnityController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid2D;


    private float Groundlevel = -3.0f;
    private float JumpDec = 0.8f;
    float JumpUp = 20;

    bool isGround;

    private float DeadLine = -9;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rigid2D = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        this.animator.SetFloat("Horizontal", 1);
        isGround = (transform.position.y > this.Groundlevel) ? false :   true;
        this.animator.SetBool("isGround", isGround);    //T : F
        GetComponent<AudioSource>().volume = (isGround) ? 0.5f : 0;


        if (Input.GetMouseButtonDown (0) && isGround)
        {
            this.rigid2D.velocity = new Vector2 (0, this.JumpUp);

        }

        if (Input.GetMouseButton (0) == false)
        {
            if (this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity *= this.JumpDec;

            }
           
 
        }
        if(transform.position.x  <this.DeadLine)
        {
            GameObject.Find("Canvas").GetComponent<UIscript>().GameOver();
            Destroy(gameObject);

        }
    }   
}
