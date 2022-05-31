using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHero : MonoBehaviour
{

    Animator mob_animator;

    private IEnumerator Start()
    {
        mob_animator = GetComponent<Animator>();
        yield return new WaitForSeconds(3);
        mob_animator.SetTrigger("Walk");
    }
    public void Set_animator_int(int anim_ID)
    {
        mob_animator.SetInteger("Attack_INT", anim_ID);
    }

}
