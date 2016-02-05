/*Source file name:Assignment1
*Author’s name: Rui Yang
*Last Modified by:Rui Yang
*Date last Modified:2-5-2016
*Program description: Players drive a green car, and should avoid to touch gray cars. there are coins to collect. if player touch coins they will get score
*                       if players touched gray car 5 times, game is over.
*Revision History:   
*                  Players and Enermies
*                  Background 
*                  Move sprite
*                  touch effect
*                  add SoundTrack
*                  
*
*
*
*
*/
using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float speed = 7f;

    // PRIVATE INSTANCE VARIABLES
    private float _playerInput;
    private float _playerInput2;
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");
        this._playerInput2 = Input.GetAxis("Vertical");
        // if player input is positive move right 
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        // if player input is negative move left 
        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        // if player input is positive move up 
        if (this._playerInput2 > 0)
        {
            this._currentPosition += new Vector2(0,this.speed);
        }

        // if player input is negative move down 
        if (this._playerInput2 < 0)
        {
            this._currentPosition -= new Vector2(0,this.speed);
        }










        this._checkBounds();

        this._transform.position = this._currentPosition;
    }


    // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void _checkBounds()
    {
        // check if the plane is going out of bounds and keep it inside window boundary
        if (this._currentPosition.x < -290)
        {
            this._currentPosition.x = -290;
        }

        if (this._currentPosition.x > 290)
        {
            this._currentPosition.x = 290;
        }
        if (this._currentPosition.y < -200)
        {
            this._currentPosition.y = -200;
        }

        if (this._currentPosition.y > 200)
        {
            this._currentPosition.y = 200;
        }
    }
}
