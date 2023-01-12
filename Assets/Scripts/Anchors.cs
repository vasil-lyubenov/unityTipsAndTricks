using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchors : MonoBehaviour
{
    [SerializeField]
    RectTransform redPanel;

    [SerializeField]
    float moveAmount = 1f;

    [SerializeField]
    float moveSpeed = 0.1f;

    [SerializeField]
    float minOffset = 0f;

    bool doIncrease = true;

    float maxHeigth;

    void Start()
    {
        maxHeigth = transform.parent.GetComponent<RectTransform>().rect.height;
    }

    private void Update()
    {
        // Doing animation with offsetMin 

        //if (doIncrease)
        //{
        //    redPanel.offsetMin = new Vector2(redPanel.offsetMin.x, redPanel.offsetMin.y + moveAmount * moveSpeed * Time.deltaTime);
        //    if (redPanel.offsetMin.y >= maxHeigth)
        //    {
        //        doIncrease = false;
        //    }
        //    return;
        //}

        //redPanel.offsetMin = new Vector2(redPanel.offsetMin.x, redPanel.offsetMin.y + moveAmount * moveSpeed * Time.deltaTime);
        //if (redPanel.offsetMin.y <= minOffset)
        //{
        //    doIncrease = true;
        //}

        // Doing animation with offsetMax

        if (doIncrease)
        {
            redPanel.offsetMax = new Vector2(redPanel.offsetMax.x, redPanel.offsetMax.y - moveSpeed * moveAmount * Time.deltaTime);
            if (-redPanel.offsetMax.y >= maxHeigth) {
                doIncrease = false;
            }

        }
        else
        {
            redPanel.offsetMax = new Vector2(redPanel.offsetMax.x, redPanel.offsetMax.y + moveSpeed * moveAmount * Time.deltaTime);
            if (redPanel.offsetMax.y >= 0)
            {
                doIncrease = true;
            }
        }
    }
}