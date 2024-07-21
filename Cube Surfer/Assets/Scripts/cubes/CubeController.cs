using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] private HeroStack HeroStack;

    private RaycastHit hit;

    private Vector3 direction = Vector3.back;

    private bool isStack = false;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        HeroStack = GameObject.FindObjectOfType<HeroStack>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetCubeRaycast();
    }



    private void SetCubeRaycast()
    {
        if (Physics.Raycast(transform.position,direction,out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                HeroStack.IncreaseBlockStack(gameObject);
            }

            if (hit.transform.name == "Obstacle")
            {
                HeroStack.DecreaseBlock(gameObject);
            }
        }
    }



    private void  SetDirection ()
    {

    }
}
