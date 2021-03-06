//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Aqrose.Aidi {

public class AidiImage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AidiImage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AidiImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AidiImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csharpaidiclientPINVOKE.delete_AidiImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AidiImage() : this(csharpaidiclientPINVOKE.new_AidiImage(), true) {
  }

  public void get_mat(SWIGTYPE_p_cv__Mat image) {
    csharpaidiclientPINVOKE.AidiImage_get_mat(swigCPtr, SWIGTYPE_p_cv__Mat.getCPtr(image));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_cv__Mat get_mat_const() {
    SWIGTYPE_p_cv__Mat ret = new SWIGTYPE_p_cv__Mat(csharpaidiclientPINVOKE.AidiImage_get_mat_const(swigCPtr), false);
    return ret;
  }

  public bool empty() {
    bool ret = csharpaidiclientPINVOKE.AidiImage_empty(swigCPtr);
    return ret;
  }

  public void set_mat(SWIGTYPE_p_cv__Mat image) {
    csharpaidiclientPINVOKE.AidiImage_set_mat(swigCPtr, SWIGTYPE_p_cv__Mat.getCPtr(image));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public int data_byte_size() {
    int ret = csharpaidiclientPINVOKE.AidiImage_data_byte_size(swigCPtr);
    return ret;
  }

  public int width() {
    int ret = csharpaidiclientPINVOKE.AidiImage_width(swigCPtr);
    return ret;
  }

  public int height() {
    int ret = csharpaidiclientPINVOKE.AidiImage_height(swigCPtr);
    return ret;
  }

  public int channel() {
    int ret = csharpaidiclientPINVOKE.AidiImage_channel(swigCPtr);
    return ret;
  }

  public void char_ptr_to_mat(byte[] databuf, int rows, int cols, int type) {
    csharpaidiclientPINVOKE.AidiImage_char_ptr_to_mat(swigCPtr, databuf, rows, cols, type);
  }

  public void mat_to_char_ptr(byte[] databuf, uint len) {
    csharpaidiclientPINVOKE.AidiImage_mat_to_char_ptr(swigCPtr, databuf, len);
  }

  public void vector_int_to_mat(IntVector data, int rows, int cols) {
    csharpaidiclientPINVOKE.AidiImage_vector_int_to_mat(swigCPtr, IntVector.getCPtr(data), rows, cols);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void vector_float_to_mat(FloatVector data, int rows, int cols) {
    csharpaidiclientPINVOKE.AidiImage_vector_float_to_mat(swigCPtr, FloatVector.getCPtr(data), rows, cols);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void mat_to_vector_float(FloatVector data) {
    csharpaidiclientPINVOKE.AidiImage_mat_to_vector_float(swigCPtr, FloatVector.getCPtr(data));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void mat_to_vector_int(IntVector data) {
    csharpaidiclientPINVOKE.AidiImage_mat_to_vector_int(swigCPtr, IntVector.getCPtr(data));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void read_image(string path, int flag) {
    csharpaidiclientPINVOKE.AidiImage_read_image__SWIG_0(swigCPtr, path, flag);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void read_image(string path) {
    csharpaidiclientPINVOKE.AidiImage_read_image__SWIG_1(swigCPtr, path);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void show_image(int wait_time) {
    csharpaidiclientPINVOKE.AidiImage_show_image(swigCPtr, wait_time);
  }

  public bool draw_result(string result) {
    bool ret = csharpaidiclientPINVOKE.AidiImage_draw_result(swigCPtr, result);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void save_image(string path) {
    csharpaidiclientPINVOKE.AidiImage_save_image(swigCPtr, path);
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
