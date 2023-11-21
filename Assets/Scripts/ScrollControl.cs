using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollControl : MonoBehaviour
{
    public Transform transform;
    public float scrollSpeed = 0f;
    public float scrollSpeedDelta;
    public Text scrollText;
    int scrollIndex;

    private Vector3 transformNow;

    private void Start()
    {
        transform = GetComponent<Transform>();
        transformNow = transform.position;
    }

    private void FixedUpdate()
    {
        transformNow = new Vector3(transform.position.x, transform.position.y + scrollSpeed * Time.deltaTime, transform.position.z);
        transform.position = transformNow;
    }

    public void ChangeSpeedScroll(bool isUpSpeed)
    {
        if (isUpSpeed)
        {
            scrollSpeed += scrollSpeedDelta;
            scrollIndex += 1;
        }
        else
        {
            scrollSpeed -= scrollSpeedDelta;
            scrollIndex -= 1;
            if(scrollSpeed < 0f)
            {
                scrollSpeed = 0f;
                scrollIndex = 0;
            }
        }
        scrollText.text = scrollIndex + "";
    }
}
