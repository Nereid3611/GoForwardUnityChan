using System.Collections;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    private float Speed = -12;
    private float Repop = -10;
    public bool Hit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.Speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.Repop)
        {
            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("取得");
        AudioSource audio = gameObject.GetComponent<AudioSource>();


        if (collision.gameObject.tag == "Block" && this.Hit == false)
        {
            audio.Play();
        }
        if(collision.gameObject.tag == "Ground")
        {
            audio.Play();
        }
        this.Hit = true;
    }
}
