using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAnimatorBool : StateMachineBehaviour
{
    
    public string targetBool;
    public bool status;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        animator.SetBool(targetBool, status);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       // animator.SetBool("isInteracting", false);
    }

}
