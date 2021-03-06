using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the SRR_S01_SCHEDULE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: SCH (SCH - schedule activity information segment) </li>
///<li>1: NTE (NTE - notes and comments segment) optional repeating</li>
///<li>2: SRR_S01_PATIENT (a Group object) optional repeating</li>
///<li>3: SRR_S01_RESOURCES (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class SRR_S01_SCHEDULE : AbstractGroup {

	///<summary> 
	/// Creates a new SRR_S01_SCHEDULE Group.
	///</summary>
	public SRR_S01_SCHEDULE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SCH), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(SRR_S01_PATIENT), false, true);
	      this.add(typeof(SRR_S01_RESOURCES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SRR_S01_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SCH (SCH - schedule activity information segment) - creates it if necessary
	///</summary>
	public SCH SCH { 
get{
	   SCH ret = null;
	   try {
	      ret = (SCH)this.GetStructure("SCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (NTE - notes and comments segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of SRR_S01_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public SRR_S01_PATIENT GetPATIENT() {
	   SRR_S01_PATIENT ret = null;
	   try {
	      ret = (SRR_S01_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SRR_S01_PATIENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SRR_S01_PATIENT GetPATIENT(int rep) { 
	   return (SRR_S01_PATIENT)this.GetStructure("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRR_S01_PATIENT 
	 */ 
	public int PATIENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SRR_S01_PATIENT results 
	 */ 
	public IEnumerable<SRR_S01_PATIENT> PATIENTs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENTRepetitionsUsed; rep++)
			{
				yield return (SRR_S01_PATIENT)this.GetStructure("PATIENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new SRR_S01_PATIENT
	///</summary>
	public SRR_S01_PATIENT AddPATIENT()
	{
		return this.AddStructure("PATIENT") as SRR_S01_PATIENT;
	}

	///<summary>
	///Removes the given SRR_S01_PATIENT
	///</summary>
	public void RemovePATIENT(SRR_S01_PATIENT toRemove)
	{
		this.RemoveStructure("PATIENT", toRemove);
	}

	///<summary>
	///Removes the SRR_S01_PATIENT at the given index
	///</summary>
	public void RemovePATIENTAt(int index)
	{
		this.RemoveRepetition("PATIENT", index);
	}

	///<summary>
	/// Returns  first repetition of SRR_S01_RESOURCES (a Group object) - creates it if necessary
	///</summary>
	public SRR_S01_RESOURCES GetRESOURCES() {
	   SRR_S01_RESOURCES ret = null;
	   try {
	      ret = (SRR_S01_RESOURCES)this.GetStructure("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SRR_S01_RESOURCES
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SRR_S01_RESOURCES GetRESOURCES(int rep) { 
	   return (SRR_S01_RESOURCES)this.GetStructure("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRR_S01_RESOURCES 
	 */ 
	public int RESOURCESRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RESOURCES").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SRR_S01_RESOURCES results 
	 */ 
	public IEnumerable<SRR_S01_RESOURCES> RESOURCESs 
	{ 
		get
		{
			for (int rep = 0; rep < RESOURCESRepetitionsUsed; rep++)
			{
				yield return (SRR_S01_RESOURCES)this.GetStructure("RESOURCES", rep);
			}
		}
	}

	///<summary>
	///Adds a new SRR_S01_RESOURCES
	///</summary>
	public SRR_S01_RESOURCES AddRESOURCES()
	{
		return this.AddStructure("RESOURCES") as SRR_S01_RESOURCES;
	}

	///<summary>
	///Removes the given SRR_S01_RESOURCES
	///</summary>
	public void RemoveRESOURCES(SRR_S01_RESOURCES toRemove)
	{
		this.RemoveStructure("RESOURCES", toRemove);
	}

	///<summary>
	///Removes the SRR_S01_RESOURCES at the given index
	///</summary>
	public void RemoveRESOURCESAt(int index)
	{
		this.RemoveRepetition("RESOURCES", index);
	}

}
}
