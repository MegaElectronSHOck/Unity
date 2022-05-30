using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");
        int level = 5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;
        
        //// 2. 그룹형 변수
        string[] mosters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        
        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약10");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        
        items.RemoveAt(0); // 삭제 

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 : mana <= 20;
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        // 반복문
        for (int count = 0; count < 10; count++)
        {

        }
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터" + monster)
        }

        //함수

        // 반환값이 있을때 int는 반환값의 타입에 필요
        int Heal(int health)
        {
            health += 10;
            return health;
        }

        // 반환값이 없을때 void
        void Heal()
        {
            health += 10;
            //반환값이 없으므로 void
        }

        // 클래스

    }

    
}
