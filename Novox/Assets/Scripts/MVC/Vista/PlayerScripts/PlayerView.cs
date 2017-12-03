using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {
	private Transform SpawnParticule;
	public GameObject DeadParticule;
	public float _moveForce_;
	public float _Fspeed_;
	public float _NoSpeed_;
	public float _MaxSpeed_;
	public float _delay_;
	public bool _InvertedControls_;
	private Rigidbody _rb;
	private ScoreManagerSc SCM;
	private DataScore DS;
	public AudioSource AudioMan;
	public AudioClip[] SFX;
	public int SFXID;
	[SerializeField]
	public ModifiersView MDV;
	[SerializeField]
	PlayerController playerController;
	void Start () 
	{
		_rb = GetComponent <Rigidbody>();
		DS = GameObject.FindGameObjectWithTag ("DataScoreTag").GetComponent <DataScore> ();
		AudioMan = GetComponent<AudioSource>();
		AudioMan.clip=SFX[SFXID];
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
		SpawnParticule = GameObject.FindGameObjectWithTag ("PuntoCalienteManagerTag").GetComponent <Transform>();
		
	}
	
	
	void Update () 
	{
		playerController = new PlayerController (_InvertedControls_,_moveForce_,_NoSpeed_,_Fspeed_,_MaxSpeed_,_delay_,_rb);
		playerController.Prueba();
		playerController.Inputs();
		playerController.FixedUpdate();
		this._InvertedControls_ = MDV._InvertedControls;
		this._moveForce_ = MDV._moveForce;
		this._NoSpeed_ = MDV._NoSpeed;
		this._Fspeed_ = MDV._Fspeed;
		this._MaxSpeed_ = MDV._MaxSpeed;
		this._delay_ = MDV._delay;
	}
	void OnTriggerStay (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			_rb.useGravity = false;
			SCM.ScoreCount += 0.01f;
		}
	}

	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			DS.ItsFinishScoreInGame = true;
			_rb.useGravity = true;
			Instantiate(DeadParticule,SpawnParticule.position,SpawnParticule.rotation);
		}
	}
}
