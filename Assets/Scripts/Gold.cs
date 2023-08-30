using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    
    
    private float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {
            GoldRotation();
        }
        
    }
    private void GoldRotation()
    {
            if(true)
            {
                angle++;
                transform.rotation = Quaternion.Euler(0, angle, 0);
            }
            
        
    }
}
