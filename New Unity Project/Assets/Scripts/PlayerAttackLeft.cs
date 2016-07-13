using UnityEngine;
using System.Collections;

public class PlayerAttackLeft : MonoBehaviour
{
    private bool attacking;

    private float attackTimer;
    private float attackCoolDown = 0.3f;

    public Collider2D AttackTrigger;

    private Animator anim;

	// Use this for initialization
	void Awake ()
    {
        anim = gameObject.GetComponent<Animator>();
        AttackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Player.espada && Player.left && Input.GetKey(KeyCode.Space) && !attacking)
        {
            attacking = true;
            attackTimer = attackCoolDown;

            AttackTrigger.enabled = true;
        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                AttackTrigger.enabled = false;
            }
        }
	}
}
