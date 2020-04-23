using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy3D : MonoBehaviour
{

    public GameObject enemy;
    private Player player;
    public TextMeshProUGUI score;
    public int scoreCount = 0;
    

    void Start()
    {
        //score = GetComponent<TextMeshProUGUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            if (enemy.tag == "Enemy1")
            {
                scoreCount += 10;
                Debug.Log("Hit: " + scoreCount + " points");
                score.text = scoreCount.ToString();
                //player.ScoreCount(scoreCount);
            }
            if (enemy.tag == "Enemy2")
            {
                scoreCount += 20;
                score.text = scoreCount.ToString();
                //player.ScoreCount(scoreCount);
            }
            if (enemy.tag == "Enemy3")
            {
                scoreCount += 50;
                score.text = scoreCount.ToString();
                //player.ScoreCount(scoreCount);
            }
            if (enemy.tag == "Enemy4")
            {
                scoreCount += 100;
                score.text = scoreCount.ToString();
                //player.ScoreCount(scoreCount);
            }
            
            //score.text = scoreCount.ToString();
        }
    }


}
