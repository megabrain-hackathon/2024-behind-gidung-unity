using System;
using LitJson;

public class Member
{

    public string name;

    public string username;

    public string role;

    public int id;

    public Member(string name, string username, string role, int id)
    {
        this.name = name;
        this.username = username;
        this.role = role;
        this.id = id;
    }

    public static Member JsonToObject(string json)
    {
        JsonData data = JsonMapper.ToObject(json);
        int id = (int)data["id"];
        string username = (string)data["username"];
        string name = (string)data["name"];
        string role = (string)data["role"];

        Member member = new Member(name, username, role, id);

        return member;
    }
}