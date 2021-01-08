using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class descsampah : MonoBehaviour
{
    public static int scoreValue = 0;
    //public Text scoreText;
    public AudioSource koin;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        //scoreText.text = score.ToString();

        float inputan = Input.GetAxis ("Horizontal");
        transform.Translate (new Vector2 (inputan, 0) * 200 * Time.deltaTime);
    }
     
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Sampah"){
            scoreValue++;
            koin.Play();
        } else if (other.tag == "Bomb"){
            scoreValue = 0;
        SceneManager.LoadScene(3);
            
        }
        Destroy (other.gameObject);
    }

}