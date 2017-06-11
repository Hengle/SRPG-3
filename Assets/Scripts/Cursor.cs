using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor : MonoBehaviour {
    public static Cursor cursor;
    public SpriteRenderer s;
    public int mvtCD;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveCursor();
	}

    void Awake()
    {
        if (cursor == null)
        {
            DontDestroyOnLoad(gameObject);
            cursor = this;
        }
        else if (cursor != this)
        {
            Destroy(gameObject);
        }
    }

    void MoveCursor()
    {
        if (mvtCD < 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 1, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0, -1, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-1, 0, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(1, 0, 0);
            }
            mvtCD = 5;
        }
        mvtCD--;
    }
}
