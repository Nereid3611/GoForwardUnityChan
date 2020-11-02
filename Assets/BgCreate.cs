using System.Collections;
using UnityEngine;

public class BgCreate : MonoBehaviour
{
    private float Scrollspeed = -1;
    private float DestroyPos = -16;
    private float PopPos = 15.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.Scrollspeed * Time.deltaTime, 0, 0);

        if(transform.position.x < this.DestroyPos)
        {
            transform.position = new Vector2(this.PopPos, 0);

        }

    }
}
