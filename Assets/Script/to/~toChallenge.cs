using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toChallenge : MonoBehaviour
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
        // 시작하자마자 0.5초 동안 대기
        yield return new WaitForSeconds(0.5f);

        // 여기에 딜레이 이후에 실행할 코드를 추가
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

        //        // 다른 Scene으로 전환
        //        SwitchToAnotherScene();
        //        isClickProcessed = true;  // 클릭 처리 완료


        //    }
        }

        public void SwitchToAnotherScene()
        {
            // 원하는 Scene의 이름을 사용하여 전환
            SceneManager.LoadScene("Challenge");
        }
    }
