using UnityEngine;
using System.Collections;

public class tela01B : MonoBehaviour
{
    public static bool isTela01B = true;
    public static bool from1B;

    public static bool playerInstantiate;

    public GameObject player;
    public Vector2 playerFrom2;

    bool startGame = true;
    public Vector2 spawnPosition;

    // Use this for initialization
    void Start ()
    {
        if (startGame)
        {
            Instantiate(player, spawnPosition, Quaternion.identity);
            startGame = false;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (tela02.from2 && !playerInstantiate)
        {
            Instantiate(player, playerFrom2, Quaternion.identity);
            playerInstantiate = true;
        }
	}
}
