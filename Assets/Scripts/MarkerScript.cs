using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerScript : MonoBehaviour
{
    private RectTransform parentTransform;
    private RectTransform currentTransform;
    public RectTransform successZone;
    public RectTransform failureZone;
    public float successWidth;
    public float failureWidth;
    private Vector3 originalPosition;
    private Vector3 endingPosition;
    // Start is called before the first frame update
    void Start()
    {
        currentTransform = transform.GetComponent<RectTransform>();
        parentTransform = transform.parent.GetComponent<RectTransform>();

        successZone.sizeDelta = new Vector2(successWidth,25);
        successZone.offsetMin = new Vector2(successWidth * -1, -parentTransform.rect.height / 2);
        successZone.offsetMax = new Vector2(0, parentTransform.rect.height / 2);

        failureZone.sizeDelta = new Vector2(failureWidth,25);
        failureZone.offsetMin = new Vector2(0, -parentTransform.rect.height / 2);
        failureZone.offsetMax = new Vector2(failureWidth, parentTransform.rect.height / 2);


        originalPosition = currentTransform.localPosition;
        endingPosition = originalPosition;
        endingPosition.x = parentTransform.rect.width / 2 - (currentTransform.rect.width / 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(originalPosition, endingPosition,Mathf.PingPong(Time.time,1.0f));
    }

    public void CheckSuccess() {
        if(transform.localPosition.x >= parentTransform.rect.width / 2 - successWidth) {
            Debug.Log("success");
        } else if (transform.localPosition.x < -parentTransform.rect.width / 2 + failureWidth) {
            Debug.Log("failure");
        } else {
            Debug.Log(transform.localPosition.x);
            Debug.Log("mediocre");
        }
    }
}
