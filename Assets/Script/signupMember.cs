using System;
using LitJson;
public class SignupMember
{
    public class Signreturn { public string name; public string username; public string password; public static string objectToJson(Signreturn member) { string json = JsonMapper.ToJson(member); return json; } }
    public string name; public string username; public string password; public SignupMember(string name, string username, string password) { this.name = name; this.username = username; this.password = password; }
    public string ObjectToJson()
    {         //Member member = new Member();
              SignupMember member;
              member = new SignupMember(name, username, password);
              //member.id = id;
              //member.name = name;
              //member.username = username;
              //member.role = role;
              return JsonMapper.ToJson(member);
              }
             }
