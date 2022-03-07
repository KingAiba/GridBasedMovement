using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdNameUI : MonoBehaviour
{

    GameObject target;

    RectTransform myTransform;

    public Vector3 labelOffset = new Vector3(0, 0, 0);

    public void SetTextAndTarget(string text, GameObject Target, GameObject parent)
    {
        transform.SetParent(parent.transform, false);
        GetComponent<Text>().text = text;

        target = Target;

        myTransform = GetComponent<RectTransform>();
        myTransform.localPosition = Camera.main.WorldToScreenPoint(target.transform.position) + labelOffset;
    }

    private void LateUpdate()
    {
        myTransform.localPosition = Camera.main.WorldToScreenPoint(target.transform.position) + labelOffset;
    }



}
