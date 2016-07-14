using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    public static bool up;
    public static bool down;
    public static bool left;
    public static bool right;

    bool tiro;
    public static bool espada = true;

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveY * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * moveSpeed, GetComponent<Rigidbody2D>().velocity.x);

        if (moveX > 0)
        {
            right = true;

            up = false;
            down = false;
            left = false;
        }

        if (moveX < 0)
        {
            left = true;

            up = false;
            down = false;
            right = false;
        }

        if (moveY > 0)
        {
            up = true;

            down = false;
            right = false;
            left = false;
        }

        if (moveY < 0)
        {
            down = true;

            up = false;
            right = false;
            left = false;
        }

        if (tiro)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                print("tiro");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "TrocaTela001A")
        {
            if (tela01A.isTela01A)
            {
                Application.LoadLevel(2);

                tela01A.from1A = true;

                tela01B.from1B = false;
                tela03.from3 = false;
            }
        }

        if (col.gameObject.tag == "TrocaTela001B")
        {
            if (tela01B.isTela01B)
            {
                Application.LoadLevel(2);

                tela01B.from1B = true;

                tela01A.from1A = false;
                tela03.from3 = false;
            }
        }

        if (col.gameObject.tag == "TrocaTela002")
        {
            if (tela02.isTela02)
            {
                Application.LoadLevel(0);
                tela02.from2 = true;
            }
        }

        if (col.gameObject.tag == "TrocaTela003")
        {
            if (tela03.isTela03)
            {
                Application.LoadLevel(2);

                tela03.from3 = true;

                tela01A.from1A = false;
                tela01B.from1B = false;
            }
        }

        if (col.gameObject.tag == "TrocaTela004")
        {
            if (tela04.isTela04)
            {
                Application.LoadLevel(3);
            }
        }

        if (col.gameObject.tag == "TrocaTela005")
        {
            if (tela05.isTela05)
            {
                Application.LoadLevel(4);
            }
        }

        if (col.gameObject.tag == "TrocaTela006")
        {
            if (tela06.isTela06)
            {
                Application.LoadLevel(5);
            }
        }

        if (col.gameObject.tag == "TrocaTela0102")
        {
            if (tela02.isTela02)
            {
                Application.LoadLevel(1);
            }
        }

        if (col.gameObject.tag == "TrocaTela0104")
        {
            if (tela04.isTela04)
            {
                Application.LoadLevel(5);
            }
        }

        if (col.gameObject.tag == "TrocaTela0105")
        {
            if (tela05.isTela05)
            {
                Application.LoadLevel(6);
            }
        }

        if (col.gameObject.tag == "TrocaTela02")
        {
            if (tela02.isTela02)
            {
                Application.LoadLevel(3);
            }
        }

        if (col.gameObject.tag == "TrocaTela03")
        {
            if (tela02.isTela02)
            {
                Application.LoadLevel(4);
            }
        }
    }
}