//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FannWrapper;
namespace FannWrapperFloat {

public class fann_train_data : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal fann_train_data(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(fann_train_data obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~fann_train_data() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfloatPINVOKE.delete_fann_train_data(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public fann_errno_enum errno_f {
    set {
      fannfloatPINVOKE.fann_train_data_errno_f_set(swigCPtr, (int)value);
    } 
    get {
      fann_errno_enum ret = (fann_errno_enum)fannfloatPINVOKE.fann_train_data_errno_f_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_FILE error_log {
    set {
      fannfloatPINVOKE.fann_train_data_error_log_set(swigCPtr, SWIGTYPE_p_FILE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fannfloatPINVOKE.fann_train_data_error_log_get(swigCPtr);
      SWIGTYPE_p_FILE ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FILE(cPtr, false);
      return ret;
    } 
  }

  public string errstr {
    set {
      fannfloatPINVOKE.fann_train_data_errstr_set(swigCPtr, value);
    } 
    get {
      string ret = fannfloatPINVOKE.fann_train_data_errstr_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_data {
    set {
      fannfloatPINVOKE.fann_train_data_num_data_set(swigCPtr, value);
    } 
    get {
      uint ret = fannfloatPINVOKE.fann_train_data_num_data_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_input {
    set {
      fannfloatPINVOKE.fann_train_data_num_input_set(swigCPtr, value);
    } 
    get {
      uint ret = fannfloatPINVOKE.fann_train_data_num_input_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_output {
    set {
      fannfloatPINVOKE.fann_train_data_num_output_set(swigCPtr, value);
    } 
    get {
      uint ret = fannfloatPINVOKE.fann_train_data_num_output_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_float input {
    set {
      fannfloatPINVOKE.fann_train_data_input_set(swigCPtr, SWIGTYPE_p_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fannfloatPINVOKE.fann_train_data_input_get(swigCPtr);
      SWIGTYPE_p_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_float output {
    set {
      fannfloatPINVOKE.fann_train_data_output_set(swigCPtr, SWIGTYPE_p_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fannfloatPINVOKE.fann_train_data_output_get(swigCPtr);
      SWIGTYPE_p_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_float(cPtr, false);
      return ret;
    } 
  }

  public fann_train_data() : this(fannfloatPINVOKE.new_fann_train_data(), true) {
  }

}

}
