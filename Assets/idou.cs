using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class idou : MonoBehaviour
{
    public GameObject Canvas;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //‚±‚±‚©‚çƒWƒ‡[ƒWˆÚ“®
        if (count <= 300)
        { transform.Translate(2.1f, 0, 0);
            count += 1;
        }
       
    }
}
