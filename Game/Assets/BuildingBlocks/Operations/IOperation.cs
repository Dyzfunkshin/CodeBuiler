using UnityEngine;
using System.Collections;

public interface IOperation : IBuildingBlock 
{
	object Evaluate();
}
