//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FannWrapperFloat;
namespace FannWrapper {

public class ActivationFunctionArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ActivationFunctionArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ActivationFunctionArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ActivationFunctionArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfloatPINVOKE.delete_ActivationFunctionArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ActivationFunctionArray(int nelements) : this(fannfloatPINVOKE.new_ActivationFunctionArray(nelements), true) {
  }

  public ActivationFunction getitem(int index) {
    ActivationFunction ret = (ActivationFunction)fannfloatPINVOKE.ActivationFunctionArray_getitem(swigCPtr, index);
    return ret;
  }

  public void setitem(int index, ActivationFunction value) {
    fannfloatPINVOKE.ActivationFunctionArray_setitem(swigCPtr, index, (int)value);
  }

  public SWIGTYPE_p_FANN__activation_function_enum cast() {
    global::System.IntPtr cPtr = fannfloatPINVOKE.ActivationFunctionArray_cast(swigCPtr);
    SWIGTYPE_p_FANN__activation_function_enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FANN__activation_function_enum(cPtr, false);
    return ret;
  }

  public static ActivationFunctionArray frompointer(SWIGTYPE_p_FANN__activation_function_enum t) {
    global::System.IntPtr cPtr = fannfloatPINVOKE.ActivationFunctionArray_frompointer(SWIGTYPE_p_FANN__activation_function_enum.getCPtr(t));
    ActivationFunctionArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new ActivationFunctionArray(cPtr, false);
    return ret;
  }

}

}
