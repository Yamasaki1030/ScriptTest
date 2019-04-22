using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    
    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        // 残りHPを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした！ 残りMPは" + mp + "。");
        } else
        {
            Debug.Log("MPが足りないため魔法が使えない！");
        }
        
    }
}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Boss midboss = new Boss();
        Boss lastboss = new Boss();
        
        Debug.Log("中ボスとの戦闘！");
        // 防御用の関数
        midboss.Defence(3);
        // 攻撃用の関数
        midboss.Attack();
        
        Debug.Log("ラスボスとの戦闘！");
        // 魔法攻撃用の関数
        for (int i = 0; i < 6; i++)
        {
            lastboss.Magic();
        }
        lastboss.Defence(12);
        lastboss.Attack();
        lastboss.Defence(7);
        for (int i = 0; i < 4; i++)
        {
            lastboss.Magic();
        }
        lastboss.Defence(8);
        lastboss.Magic();
        lastboss.Defence(19);
        lastboss.Attack();
        Debug.Log("ラスボスに勝利した！");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
