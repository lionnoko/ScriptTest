using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;    // MP初期化

    public void Magic()
    {
        // 魔法攻撃用の関数
        if(mp > 5){
            // MPが5以上の場合、5MP分消費する
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }else
        {
            // MPが5以下の場合、魔法使用不可
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列初期化(要素数5)
        int[] array = {10, 20, 30, 40, 50};

        // 配列要素を順番に表示
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log("順番 : " + array[i]);
        }

        // 配列要素を逆順に表示
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log("逆順 : " + array[i]);
        }

        // Bossクラス初期化
        Boss boss = new Boss();

        // 魔法攻撃用の関数を10回呼び出す
        for(int i = 0; i < 10; i++){
            boss.Magic();
        }

        // 再度、魔法攻撃用の関数を呼び出す
        boss.Magic();
    }
}

