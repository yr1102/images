Attribute VB_Name = "sacomUsbIoFt"
Declare Function sacomUsbIoOpen Lib "sacom_usb_io_ft" (ByVal id As Long) As Boolean
Declare Function sacomUsbIoClose Lib "sacom_usb_io_ft" (ByVal id As Long) As Boolean
Declare Function sacomUsbIoDirH Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dir As Long) As Boolean
Declare Function sacomUsbIoDirL Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dir As Long) As Boolean
Declare Function sacomUsbIoWriteL Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dat As Long) As Boolean
Declare Function sacomUsbIoWriteH Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dat As Long) As Boolean
Declare Function sacomUsbIoReadL Lib "sacom_usb_io_ft" (ByVal id As Long, ByRef dat As Long) As Boolean
Declare Function sacomUsbIoReadH Lib "sacom_usb_io_ft" (ByVal id As Long, ByRef dat As Long) As Boolean
Declare Function sacomUsbIoDir Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dat As Long) As Boolean
Declare Function sacomUsbIoWrite Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal dat As Long) As Boolean
Declare Function sacomUsbIoRead Lib "sacom_usb_io_ft" (ByVal id As Long, ByRef dat As Long) As Boolean
Declare Function sacomUsbIoBit Lib "sacom_usb_io_ft" (ByVal id As Long, ByVal bit As Long, ByVal data As Boolean) As Boolean
Declare Function sacomUsbIoReadback Lib "sacom_usb_io_ft" (ByVal id As Long, ByRef dat As Long) As Boolean
Declare Function sacomUsbIoUnitID Lib "sacom_usb_io_ft" (ByVal id As Long, ByRef dat As Long) As Boolean

