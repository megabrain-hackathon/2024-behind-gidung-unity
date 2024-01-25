using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toDo_add : MonoBehaviour
{
    private Image targetImage;
    private bool isClickProcessed = false;


    void Start()
    {
        
        // �� ��ũ��Ʈ�� ������ GameObject�� Image ������Ʈ ��������
        targetImage = GetComponent<Image>();


        // ���� Image�� ���ٸ�, �θ� �ڽ� ��� ã�� �� �ֵ��� ����
        if (targetImage == null)
        {
            targetImage = GetComponentInChildren<Image>();
        }
        StartCoroutine(DelayedFunction());
    }
    IEnumerator DelayedFunction()
    {
        // �������ڸ��� 0.5�� ���� ���
        yield return new WaitForSeconds(0.5f);

        // ���⿡ ������ ���Ŀ� ������ �ڵ带 �߰�
        Debug.Log("0.5�� �Ŀ� ����˴ϴ�.");
    }

    void Update()
    {
        //// ��ġ Ȥ�� ���콺 Ŭ�� ����
        //if (!isClickProcessed && (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    Vector2 touchPos = Input.mousePosition;

        //    // ��ġ ��ġ�� RectTransform ��ǥ�� ��ȯ
        //    if (RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, touchPos))
        //    {
        //        // Ư�� Image�� ��ġ Ȥ�� ���콺 Ŭ���� ������
        //        Debug.Log("Image Clicked!");

        //        // ���⿡ �߰����� ������ �߰��� �� �ֽ��ϴ�.

        //        SwitchToAnotherScene();
        //        isClickProcessed = true;  // Ŭ�� ó�� �Ϸ�

        //    }
        //}
    }

    public void SwitchToAnotherScene()
    {
        // ���ϴ� Scene�� �̸��� ����Ͽ� ��ȯ
        SceneManager.LoadScene("to Do add");

    }
}
