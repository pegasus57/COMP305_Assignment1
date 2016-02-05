using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    
    public float minVerticalSpeed = 5f;
    public float maxVerticalSpeed = 10f;
    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalSpeed;
    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Island Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(0, this._verticalSpeed);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -270)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._verticalSpeed = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float xPosition = Random.Range(-240f, 240f);
        this._transform.position = new Vector2(xPosition, 270f);
    }
}
