using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  public Transform shootingOffset;
    public TextMeshProUGUI scoreText;


    private Transform player;
    public float speed = 5f;
    public float maxBound, minBound;

    void Start()
    {
        player = GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shootingOffset.transform.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 1f);

      }

        float h = Input.GetAxis("Horizontal");
        if (player.position.x < minBound && h < 0)
        {
            h = 0;
        } else if (player.position.x > maxBound && h > 0)
        {
            h = 0;
        }

        player.position += Vector3.right * h * speed;
    }

    public void ScoreCount(int score)
    {
        scoreText.text = score.ToString();
    }
}
