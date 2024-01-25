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
        Debug.Log("0.5�� �Ŀ� ����˴ϴ�.");
    }

    void Update()
    {
        //if (!isClickProcessed && (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    Vector2 touchPos = Input.mousePosition;

        //    if (RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, touchPos))
        //    {
        //        Debug.Log("Image Clicked!");

        //        // ���⿡ �߰����� ������ �߰��� �� �ֽ��ϴ�.

        //        SwitchToAnotherScene();
        //        isClickProcessed = true;  // Ŭ�� ó�� �Ϸ�
        //    }
        //}
    }

    public void SwitchToAnotherScene()
    {
        SceneManager.LoadScene("_sign in");
    }
}
