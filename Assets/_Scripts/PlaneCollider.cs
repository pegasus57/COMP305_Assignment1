using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
    // PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _coinSound;
    private AudioSource _enemySound;


    //public instance variable
    public GameController gameController;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._enemySound = this._audioSources[1];
        this._coinSound = this._audioSources[2];
	}


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin Collision");
            this._coinSound.Play();
            this.gameController.ScoreValue += 100;
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Collision");
            this._enemySound.Play();
            this.gameController.LivesValue -= 1;
           
        }
    }
}
