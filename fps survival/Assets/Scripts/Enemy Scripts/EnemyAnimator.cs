using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    private Animator anim;
    
    void Awake()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
     public void Walk(bool Walk)
    {
        anim.SetBool(AnimationTags.WALK_PARAMETER, Walk);
    }
    public void Run(bool Run)
    {
        anim.SetBool(AnimationTags.RUN_PARAMETER, Run);
    }
    public void Attack()
    {
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER);
    }
    /*public void Dead()
    {
        anim.SetTrigger(AnimationTags.DEAD_TRIGGER);
    }
   */
   
    
   

   
}
