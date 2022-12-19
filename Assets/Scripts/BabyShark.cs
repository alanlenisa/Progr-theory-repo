using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

//namespace Assets.Scripts

    public class BabyShark:Shark
    {
        public BabyShark()
        {
            force = 100;
        }
        protected override void  GoForward()
        {

            //he run away
            
            transform.Rotate(new Vector3(0,180,0));
            base.GoForward();
            
        }
    }

