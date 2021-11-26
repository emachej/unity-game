using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    private Animator animator;
    private bool attacked;
    private bool axe; 
    bool onGround;
    float speedy;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        attacked = playerAttack.attacked;
        axe = WeaponSwitch.weaponToggle;
        onGround = playerController.onGround;
        speedy = Mathf.Abs(playerController.horizontalInput);

        animator.SetBool("Attack", attacked);
        animator.SetBool("Axe", axe);
        animator.SetBool("OnGround", onGround);
        animator.SetFloat("Speed", speedy);
    }
   
}
