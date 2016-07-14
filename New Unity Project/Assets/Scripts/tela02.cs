using UnityEngine;
using System.Collections;

public class tela02 : MonoBehaviour
{
    public static bool isTela02 = true;
    public static bool from2;

    public GameObject player;

    public Vector2 playerFrom1A;
    public Vector2 playerFrom1B;
    public Vector2 playerFrom3;
    public Vector2 playerFrom4;

    bool playerInstantiate;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!playerInstantiate && tela01A.from1A)
        {
            Instantiate(player, playerFrom1A, Quaternion.identity);
            playerInstantiate = true;
        }

        if (!playerInstantiate && tela01B.from1B)
        {
            Instantiate(player, playerFrom1B, Quaternion.identity);
            playerInstantiate = true;
        }

        if (!playerInstantiate && tela03.from3)
        {
            Instantiate(player, playerFrom3, Quaternion.identity);
            playerInstantiate = true;
        }

        if (!playerInstantiate && tela04.from4)
        {
            Instantiate(player, playerFrom4, Quaternion.identity);
            playerInstantiate = true;
        }
    }
}
