using System;
using LitJson;

public class SigninMember
{
    public string username;
    public string password;

    public SigninMember(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public string ObjectToJson()
    {
        //Member member = new Member();
        SigninMember member;
        member = new SigninMember(username, password);
        //member.id = id;
        //member.name = name;
        //member.username = username;
        //member.role = role;

        return JsonMapper.ToJson(member);
    }

    public class Signreturn
    {
        public string username;
        public string password;

        public static string objectToJson(Signreturn member)
        {
            string json = JsonMapper.ToJson(member);
            return json;
        }
    }
}