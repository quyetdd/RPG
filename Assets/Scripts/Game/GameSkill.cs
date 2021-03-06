using UnityEngine;
using System.Collections;

public class GameSkill {

	// Use this for initialization
    private int _damage;
    private TargetTypes _target;
    private TargetAttribute _attribute;
    private string _description;
    private string _name;

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void SetAttributes(string _nam, string _des, int _dam, TargetTypes _tar, TargetAttribute _atr)
    {
        _name = _nam;
        _description = _des;
        _damage = _dam;
        _target = _tar;
        _attribute = _atr;
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    public TargetTypes target
    {
        get { return _target; }
        set { _target = value; }
    }
    public TargetAttribute attribute
    {
        get { return _attribute; }
        set { _attribute = value; }
    }
}