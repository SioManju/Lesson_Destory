using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //ぶつかったら
    {
        if (collision.gameObject.CompareTag("Player")) //ぶつかったオブジェクトのタグが「Player」なら消滅する
        {
            //このゲームオブジェクトを消滅させる
            Destroy(gameObject);
        }
    }
}
