using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tosignin : MonoBehaviour
{
    private Image targetImage;
    private bool isClickProcessed = false;

    void Start()
    {
        targetImage = GetComponent<Image>();
        if (targetImage == null)
        {
            targetImage = GetComponentInChildren<Image>();
        }
        StartCoroutine(DelayedFunction());
    }

    IEnumerator DelayedFunction()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("0.5초 후에 실행됩니다.");
    }

    void Update()
    {
        //if (!isClickProcessed && (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    Vector2 touchPos = Input.mousePosition;

        //    if (RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, touchPos))
        //    {
        //        Debug.Log("Image Clicked!");

        //        // 여기에 추가적인 동작을 추가할 수 있습니다.

        //        SwitchToAnotherScene();
        //        isClickProcessed = true;  // 클릭 처리 완료
        //    }
        //}
    }

    public void SwitchToAnotherScene()
    {
        SceneManager.LoadScene("_sign in");
    }
}
