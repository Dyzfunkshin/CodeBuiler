using UnityEngine;
using System.Collections;

public class And : MonoBehaviour, IComparison 
{
	public bool Evaluate(){return true;}

	public bool Compile(){return true;}
}