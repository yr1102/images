#ifdef SACOM_USB_IO_FT_EXPORTS
#define SACOM_USB_IO_FT_API __declspec(dllexport)
#else
#define SACOM_USB_IO_FT_API __declspec(dllimport)
#endif

SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoOpen(DWORD dwRSWID);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoDir(DWORD dwRSWID, DWORD dwDir);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoDirH(DWORD dwRSWID, DWORD dwDir);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoDirL(DWORD dwRSWID, DWORD dwDir);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoWrite(DWORD dwRSWID, DWORD dwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoWriteH(DWORD dwRSWID, DWORD dwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoWriteL(DWORD dwRSWID, DWORD dwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoBit(DWORD dwRSWID, DWORD dwBit, BOOL bData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoRead(DWORD dwRSWID, LPDWORD lpdwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoReadH(DWORD dwRSWID, LPDWORD lpdwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoReadL(DWORD dwRSWID, LPDWORD lpdwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoReadback(DWORD dwRSWID, LPDWORD lpdwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoUnitID(DWORD dwRSWID, LPDWORD lpdwData);
SACOM_USB_IO_FT_API BOOL _stdcall sacomUsbIoClose(DWORD dwRSWID);
