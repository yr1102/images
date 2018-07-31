Option Strict Off
Option Explicit On
Module sacom_usb_io_ft
    Declare Function sacomUsbIoOpen Lib "sacom_usb_io_ft.dll" (ByVal id As Integer) As Boolean
    Declare Function sacomUsbIoClose Lib "sacom_usb_io_ft" (ByVal id As Integer) As Boolean
    Declare Function sacomUsbIoDirH Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dir As Integer) As Boolean
    Declare Function sacomUsbIoDirL Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dir As Integer) As Boolean
    Declare Function sacomUsbIoWriteL Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dat As Integer) As Boolean
    Declare Function sacomUsbIoWriteH Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dat As Integer) As Boolean
    Declare Function sacomUsbIoReadL Lib "sacom_usb_io_ft" (ByVal id As Integer, ByRef dat As Integer) As Boolean
    Declare Function sacomUsbIoReadH Lib "sacom_usb_io_ft" (ByVal id As Integer, ByRef dat As Integer) As Boolean
    Declare Function sacomUsbIoDir Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dat As Integer) As Boolean
    Declare Function sacomUsbIoWrite Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal dat As Integer) As Boolean
    Declare Function sacomUsbIoBit Lib "sacom_usb_io_ft" (ByVal id As Integer, ByVal bit As Integer, ByVal dat As Boolean) As Boolean
    Declare Function sacomUsbIoRead Lib "sacom_usb_io_ft" (ByVal id As Integer, ByRef dat As Integer) As Boolean
    Declare Function sacomUsbIoReadback Lib "sacom_usb_io_ft" (ByVal id As Integer, ByRef dat As Integer) As Boolean
    Declare Function sacomUsbIoUnitID Lib "sacom_usb_io_ft" (ByVal id As Integer, ByRef dat As Integer) As Boolean
End Module
