using UnityEngine;
using System.Collections;

public interface IVariable : IBuildingBlock 
{
	IType Type{ get; set; }

	object Value{ get; set; }
}
