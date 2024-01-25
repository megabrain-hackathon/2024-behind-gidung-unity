using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class database : MonoBehaviour
{
    #region Singleton
    private static database instance = null;

    public static database Instance
    {
        get
        {
            return instance;
        }
    }
    #endregion

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    [SerializeField]
    public Member loginMember;

    public void setLoginMember(Member member)
    {
        this.loginMember = member;
    }
}