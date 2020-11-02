using System.Collections;
using UnityEngine;

public class BlockCreate : MonoBehaviour
{
    //オブジェクトのプレハブ設定忘れず
    public GameObject BlockPurehub;

    private float delta = 0;
    private float Spawnrate = 1.0f;
    
    //生成X位置・XY位置オフセット・ブロック間隔
    private float PopX = 12;
    private float offsetY = 0.3f;
    private float offsetX = 0.5f;
    private float SpaceY = 6.9f;
    private float SpaceX = 0.4f;

    private int MaxPop = 4;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間
        this.delta += Time.deltaTime;

        if(this.delta > this.Spawnrate)
        {
            //経過時間初期化
            this.delta = 0;

                int n = Random.Range(1, MaxPop + 1);
            for(int i = 0; i<n ; i++)
            {
                GameObject go = Instantiate(BlockPurehub) as GameObject;
                go.transform.position = new Vector2(this.PopX, this.offsetY + i * this.SpaceY);

            }
            this.Spawnrate = this.offsetX + this.SpaceX * n;

        }


    }
    
}

