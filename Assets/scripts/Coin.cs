using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public float speed = 5f;
    public TMP_Text scoreText;

    static int score = 0;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // missed the basket: reset
        if (transform.position.y < -6f)
            ResetCoin();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))   // the catcher
        {
            score++;
            UpdateScore();
            ResetCoin();
        }
    }

    void ResetCoin()
    {
        transform.position = new Vector2(Random.Range(-4f, 4f), 4f);
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}