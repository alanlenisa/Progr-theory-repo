using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

//namespace Assets.Scripts

public class DaddyShark:Shark
{
      

    public void Start()
    {
        //daddy is bigger
           transform.localScale =new Vector3( 10,10,10);
    }
}

