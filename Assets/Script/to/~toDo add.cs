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
        
        // 이 스크립트가 부착된 GameObject의 Image 컴포넌트 가져오기
        targetImage = GetComponent<Image>();


        // 만약 Image가 없다면, 부모나 자식 등에서 찾을 수 있도록 설정
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
        //// 터치 혹은 마우스 클릭 감지
        //if (!isClickProcessed && (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    Vector2 touchPos = Input.mousePosition;

        //    // 터치 위치를 RectTransform 좌표로 변환
        //    if (RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, touchPos))
        //    {
        //        // 특정 Image에 터치 혹은 마우스 클릭이 감지됨
        //        Debug.Log("Image Clicked!");

        //        // 여기에 추가적인 동작을 추가할 수 있습니다.

        //        SwitchToAnotherScene();
        //        isClickProcessed = true;  // 클릭 처리 완료

        //    }
        //}
    }

    public void SwitchToAnotherScene()
    {
        // 원하는 Scene의 이름을 사용하여 전환
        SceneManager.LoadScene("to Do add");

    }
}
