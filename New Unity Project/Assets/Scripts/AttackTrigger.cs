using UnityEngine;
using System.Collections;

public class AttackTrigger : MonoBehaviour
{
    //private Inimigo inim;

    public int dmg = 20;

    void Start()
    {
        //inim = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Inimigo>() as Inimigo;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //inim.Damage(20);
        }
    }
}
