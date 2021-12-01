using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove_state : StateMachineBehaviour
{
    public GameObject LaserPrefab;
    
    public float laserTime;
    private float lastLaserTime;

    private Transform LaserMuzzle;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        lastLaserTime = 0f;
        LaserMuzzle = animator.gameObject.GetComponent<BossControlador>().LaserMuzzle;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (lastLaserTime + laserTime <= Time.timeSinceLevelLoad)
        {
            Instantiate(LaserPrefab, LaserMuzzle.position, animator.transform.rotation);
            lastLaserTime = Time.timeSinceLevelLoad;
        }
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
