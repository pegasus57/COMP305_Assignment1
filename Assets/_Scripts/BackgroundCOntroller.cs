using UnityEngine;
using System.Collections;

public class BackgroundCOntroller : MonoBehaviour {
    public float speed = 2;
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset ();

	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(0, this.speed);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -480) {
            this.Reset();
        }
	
	}

    public void Reset() {
        this.transform.position = new Vector2(0, 480f);
    }
}
