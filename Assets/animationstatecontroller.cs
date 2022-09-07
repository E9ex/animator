using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationstatecontroller : MonoBehaviour
{
    private int iswalkinghash;
     Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        iswalkinghash = Animator.StringToHash("iswalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool("isrunning");
        bool iswalking = animator.GetBool(iswalkinghash);
        bool forwardpressed = Input.GetKey("w");
        bool runpress = Input.GetKey("z");
        if (!iswalking&&forwardpressed) 
            
        {
            animator.SetBool(iswalkinghash,true);
        }

        if (iswalking&&!forwardpressed)
        {
            animator.SetBool(iswalkinghash,false);
        }
        if (!isrunning&&(forwardpressed&&runpress) )
            
        {
            animator.SetBool("isrunning",true);
        }

        if (!iswalking&&(forwardpressed&& runpress))
        {
            animator.SetBool("isrunning",true);
        }
        
    }
}
