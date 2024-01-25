using System.Collections;
using LitJson;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class signup : MonoBehaviour
{
    [SerializeField] public InputField input_id;
    [SerializeField] public InputField input_password;
    [SerializeField] public InputField input_username;
    private string resultJson; // Json 데이터

    public bool IsSuccesSendData = false;
    [SerializeField]
    private string URL = "http://192.168.0.10:18080";

    [SerializeField]
    private float loadProgress;

    // Start is called before the first frame update
    void Start()
    {
        // 화면이 꺼지지 않도록 설정
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        // 디바이스 설정에 맞추어 화면이 꺼지도록 처리 
        //Screen.sleepTimeout = SleepTimeout.SystemSetting;

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.LogError("인터넷 연결 안됨.");
        }
        else
        {
            //StartCoroutine(sendData());
        }
    }

    // json 처리
    void JsonParsing()
    {
        string json = JsonUtility.ToJson(resultJson);
        Debug.Log(json);
    }

    T JsonToObject<T>(string json)
    {
        return JsonUtility.FromJson<T>(json);
    }

    public float getProgress()
    {
        return loadProgress;
    }

    public void startSendData()
    {
        StartCoroutine(sendData());
    }

    // HTTP 통신을 통해 Json 보내는
    public IEnumerator sendData()
    {
        string postDataURL = URL + "/api/members";
        // HTTP Get 요청 보내기
        Debug.Log("Get data url" + postDataURL);

        string username = input_id.text;
        string password = input_password.text;
        string name = input_username.text;

        SignupMember signupMember = new SignupMember(name, username, password);
        string json = JsonMapper.ToJson(signupMember);

        using (UnityWebRequest request = UnityWebRequest.Post(postDataURL, json, "application/json"))
        {
            var asyncOperation = request.SendWebRequest();    // 요청 보내기
            while (!asyncOperation.isDone)
            {
                //Debug.Log(request.downloadProgress);
                loadProgress = request.downloadProgress;
                yield return null;
            }

            if (request.error != null)
            {
                Debug.LogError("API 통신 중 에러 발생", this);
                yield break;
            }
            else
            {
                IsSuccesSendData = true;
                //resultJson = System.Text.Encoding.UTF8.GetString(request.downloadHandler.data);
                //resultJson = request.downloadHandler.text;

                if (request.responseCode != 201) // 200 - OK, 201 - CREATED
                { // 통신 성공
                    // json으로 받기
                    Debug.LogError("통신 실패");
                }
                else
                {
                    SceneManager.LoadScene("_sign in");
                    Debug.Log("회원 가입 완료!");
                }
            }
        }
    }
}