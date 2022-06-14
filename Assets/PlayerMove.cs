using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;

        //右矢印キーが入力されたとき
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //右方向に0.01動く
            pos.x += 0.05f;
        }

        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左方向に0.01動く
            pos.x -= 0.05f;
        }

        //上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //上方向に0.01動く
            pos.z += 0.05f;
        }

        //下矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //下方向に0.01動く
            pos.z -= 0.05f;
        }

        transform.position = new Vector3(pos.x, pos.y, pos.z);

    }
}
