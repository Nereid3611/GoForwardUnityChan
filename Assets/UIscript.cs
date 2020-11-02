using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{
    private GameObject GameOverText;
    private GameObject RunLengthText;

    private float length = 0;
    private float speed = 5f;

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.GameOverText = GameObject.Find("GameOver");
        this.RunLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isGameOver == false )
        {
            this.length += this.speed * Time.deltaTime;                          
            this.RunLengthText.GetComponent<Text>().text = "Score:  " + length.ToString ("F2") + "ｍ";
        }
        if(isGameOver == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");

            }
        }
    }
    public void GameOver()
    {
        this.GameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
        
    }
}
