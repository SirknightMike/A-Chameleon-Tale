﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Cursor : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        
        
           
        
       
    }
   

}
