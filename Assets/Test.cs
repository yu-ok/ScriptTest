using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
        private int mp = 53; // 体力
        

        public void Magic()
        {
                mp -= 5;    
        
                Debug.Log( "魔法攻撃をした。残りMPは"+ mp + "。" );
                
                if(mp < 5)
                {

                Debug.Log("MPが足りないため魔法が使えない。");

                }
        }

}

public class Test : MonoBehaviour
{

        void Start ()
        {
            int[] array = {1,5,7,6,8};



            for(var i = 0; i < array.Length; i++)
            {

                Debug.Log(array [i]);
            }

             for(var i = array.Length-1; i >= 0; i--)
            {

                Debug.Log(array [i]);
            }


                // Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();

                for(var i = 0; i <= 10; i++)
                {
                lastboss.Magic();
                }
        }

        // Update is called once per frame
        void Update ()
        {

        }
}